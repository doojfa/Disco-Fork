// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments
#pragma warning disable 1591
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;
namespace Disco.Web.Areas.Public.Controllers
{
    public partial class HeldDevicesController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public HeldDevicesController() { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected HeldDevicesController(Dummy d) { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(Task<ActionResult> taskResult)
        {
            return RedirectToAction(taskResult.Result);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoutePermanent(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(Task<ActionResult> taskResult)
        {
            return RedirectToActionPermanent(taskResult.Result);
        }

        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult HeldDevice()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.HeldDevice);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public HeldDevicesController Actions { get { return MVC.Public.HeldDevices; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "Public";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "HeldDevices";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "HeldDevices";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string Index = "Index";
            public readonly string ReadyForReturnXml = "ReadyForReturnXml";
            public readonly string WaitingForUserActionXml = "WaitingForUserActionXml";
            public readonly string HeldDevicesXml = "HeldDevicesXml";
            public readonly string Noticeboard = "Noticeboard";
            public readonly string HeldDevice = "HeldDevice";
            public readonly string HeldDevices = "HeldDevices";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string Index = "Index";
            public const string ReadyForReturnXml = "ReadyForReturnXml";
            public const string WaitingForUserActionXml = "WaitingForUserActionXml";
            public const string HeldDevicesXml = "HeldDevicesXml";
            public const string Noticeboard = "Noticeboard";
            public const string HeldDevice = "HeldDevice";
            public const string HeldDevices = "HeldDevices";
        }


        static readonly ActionParamsClass_HeldDevice s_params_HeldDevice = new ActionParamsClass_HeldDevice();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_HeldDevice HeldDeviceParams { get { return s_params_HeldDevice; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_HeldDevice
        {
            public readonly string id = "id";
        }
        static readonly ViewsClass s_views = new ViewsClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewsClass Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewsClass
        {
            static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
            public _ViewNamesClass ViewNames { get { return s_ViewNames; } }
            public class _ViewNamesClass
            {
                public readonly string Index = "Index";
                public readonly string Noticeboard = "Noticeboard";
            }
            public readonly string Index = "~/Areas/Public/Views/HeldDevices/Index.cshtml";
            public readonly string Noticeboard = "~/Areas/Public/Views/HeldDevices/Noticeboard.cshtml";
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_HeldDevicesController : Disco.Web.Areas.Public.Controllers.HeldDevicesController
    {
        public T4MVC_HeldDevicesController() : base(Dummy.Instance) { }

        [NonAction]
        partial void IndexOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult Index()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Index);
            IndexOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void ReadyForReturnXmlOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult ReadyForReturnXml()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ReadyForReturnXml);
            ReadyForReturnXmlOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void WaitingForUserActionXmlOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult WaitingForUserActionXml()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.WaitingForUserActionXml);
            WaitingForUserActionXmlOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void HeldDevicesXmlOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult HeldDevicesXml()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.HeldDevicesXml);
            HeldDevicesXmlOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void NoticeboardOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult Noticeboard()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Noticeboard);
            NoticeboardOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void HeldDeviceOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string id);

        [NonAction]
        public override System.Web.Mvc.ActionResult HeldDevice(string id)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.HeldDevice);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            HeldDeviceOverride(callInfo, id);
            return callInfo;
        }

        [NonAction]
        partial void HeldDevicesOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult HeldDevices()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.HeldDevices);
            HeldDevicesOverride(callInfo);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591
