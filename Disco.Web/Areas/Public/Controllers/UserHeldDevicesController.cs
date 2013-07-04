﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Disco.BI;
using Disco.BI.Extensions;
using Disco.Models.Repository;

namespace Disco.Web.Areas.Public.Controllers
{
    public partial class UserHeldDevicesController : dbController
    {
        #region Helpers

        private List<Models.UserHeldDevices.UserHeldDeviceModel> GetUserHeldDevices(IQueryable<Job> query)
        {
            var jobs = query.Where(j =>
                !j.ClosedDate.HasValue && j.Device.AssignedUserId != null &&
                j.DeviceSerialNumber != null &&
                ((j.DeviceHeld.HasValue && !j.DeviceReturnedDate.HasValue) || j.WaitingForUserAction.HasValue)
                ).Select(j => new Models.UserHeldDevices.HeldJobDeviceModel
                {
                    JobId = j.Id,
                    WaitingForUserAction = j.WaitingForUserAction.HasValue || ((j.JobMetaNonWarranty.AccountingChargeRequiredDate.HasValue || j.JobMetaNonWarranty.AccountingChargeAddedDate.HasValue) && !j.JobMetaNonWarranty.AccountingChargePaidDate.HasValue),
                    WaitingForUserActionSince = j.WaitingForUserAction.HasValue ? j.WaitingForUserAction : (j.JobMetaNonWarranty.AccountingChargeRequiredDate.HasValue ? j.JobMetaNonWarranty.AccountingChargeRequiredDate : j.JobMetaNonWarranty.AccountingChargeAddedDate),
                    ReadyForReturn = j.DeviceReadyForReturn.HasValue,
                    EstimatedReturnTime = j.ExpectedClosedDate,
                    ReadyForReturnSince = j.DeviceReadyForReturn,
                    UserId = j.Device.AssignedUserId,
                    UserDisplayName = j.Device.AssignedUser.DisplayName,
                    DeviceProfileId = j.Device.DeviceProfileId,
                    DeviceAddressId = j.Device.DeviceProfile.DefaultOrganisationAddress
                }).GroupBy(j => j.UserId);

            var thd = new List<Models.UserHeldDevices.UserHeldDeviceModel>();
            foreach (var job in jobs)
            {
                if (job.Any(j => j.WaitingForUserAction))
                {
                    thd.Add(job.Where(j => j.WaitingForUserAction).OrderBy(j => j.WaitingForUserActionSince).FirstOrDefault().ToUserHeldDeviceModel(dbContext));
                }
                else
                {
                    if (job.All(j => j.ReadyForReturn))
                    {
                        thd.Add(job.FirstOrDefault().ToUserHeldDeviceModel(dbContext));
                    }
                    else
                    {
                        thd.Add(job.Where(j => !j.ReadyForReturn).OrderByDescending(j => j.EstimatedReturnTime).FirstOrDefault().ToUserHeldDeviceModel(dbContext));
                    }
                }
            }
            return thd;
        }

        #endregion

        private List<Models.UserHeldDevices.UserHeldDeviceModel> GetUserHeldDevices()
        {
            return GetUserHeldDevices(dbContext.Jobs);
        }
        private Models.UserHeldDevices.UserHeldDeviceModel GetUserHeldDevice(string UserId)
        {
            return GetUserHeldDevices(dbContext.Jobs.Where(j => j.Device.AssignedUserId == UserId)).FirstOrDefault();
        }

        public virtual ActionResult Index()
        {
            return View(GetUserHeldDevices());
        }

        public virtual ActionResult ReadyForReturnXml()
        {
            var readyForReturn = GetUserHeldDevices().Where(j => j.ReadyForReturn && !j.WaitingForUserAction).ToArray();
            return new Extensions.XmlResult(readyForReturn);
        }
        public virtual ActionResult WaitingForUserActionXml()
        {
            var userHeldDevices = GetUserHeldDevices().Where(j => j.WaitingForUserAction).ToArray();
            return new Extensions.XmlResult(userHeldDevices);
        }
        public virtual ActionResult UserHeldDevicesXml()
        {
            var userHeldDevices = GetUserHeldDevices().Where(j => !j.ReadyForReturn && !j.WaitingForUserAction).ToArray();
            return new Extensions.XmlResult(userHeldDevices);
        }

        public virtual ActionResult Noticeboard()
        {
            return View();
        }

        public virtual ActionResult UserHeldDevice(string id)
        {
            var uhd = GetUserHeldDevice(id);
            return Json(uhd, JsonRequestBehavior.AllowGet);
        }
        public virtual ActionResult UserHeldDevices()
        {
            var uhd = GetUserHeldDevices();
            return Json(uhd, JsonRequestBehavior.AllowGet);
        }

    }
}
