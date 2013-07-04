﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18033
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Disco.Web.Areas.Public.Views.UserHeldDevices
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Disco.BI.Extensions;
    using Disco.Models.Repository;
    using Disco.Web;
    using Disco.Web.Extensions;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Public/Views/UserHeldDevices/Index.cshtml")]
    public partial class Index : System.Web.Mvc.WebViewPage<IEnumerable<Disco.Web.Areas.Public.Models.UserHeldDevices.UserHeldDeviceModel>>
    {
        public Index()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Areas\Public\Views\UserHeldDevices\Index.cshtml"
  
    ViewBag.Title = Html.ToBreadcrumb("Public Reports", MVC.Public.Public.Index(), "Held Devices for Users", null);
    Html.BundleDeferred("~/Style/Public/HeldDevices");

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"clearfix page\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"column1\"");

WriteLiteral(">\r\n");

            
            #line 8 "..\..\Areas\Public\Views\UserHeldDevices\Index.cshtml"
        
            
            #line default
            #line hidden
            
            #line 8 "..\..\Areas\Public\Views\UserHeldDevices\Index.cshtml"
          
            var DevicesInProcess = Model.Where(i => !i.ReadyForReturn && !i.WaitingForUserAction).ToArray();
        
            
            #line default
            #line hidden
WriteLiteral("\r\n        <h2>\r\n            In Process (");

            
            #line 12 "..\..\Areas\Public\Views\UserHeldDevices\Index.cshtml"
                   Write(DevicesInProcess.Length);

            
            #line default
            #line hidden
WriteLiteral(")</h2>\r\n        <table");

WriteLiteral(" class=\"dataTable\"");

WriteLiteral(">\r\n");

            
            #line 14 "..\..\Areas\Public\Views\UserHeldDevices\Index.cshtml"
            
            
            #line default
            #line hidden
            
            #line 14 "..\..\Areas\Public\Views\UserHeldDevices\Index.cshtml"
             foreach (var item in DevicesInProcess)
            {

            
            #line default
            #line hidden
WriteLiteral("                <tr>\r\n                    <td");

WriteLiteral(" class=\"id\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 18 "..\..\Areas\Public\Views\UserHeldDevices\Index.cshtml"
                   Write(item.UserId);

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </td>\r\n                    <td");

WriteLiteral(" class=\"description\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 21 "..\..\Areas\Public\Views\UserHeldDevices\Index.cshtml"
                   Write(item.UserDisplayName);

            
            #line default
            #line hidden
            
            #line 21 "..\..\Areas\Public\Views\UserHeldDevices\Index.cshtml"
                                               
                if (!string.IsNullOrEmpty(item.EstimatedReturnTime))
                { 

            
            #line default
            #line hidden
WriteLiteral("                            <span");

WriteLiteral(" class=\"smallMessage\"");

WriteLiteral(">(Expected: ");

            
            #line 24 "..\..\Areas\Public\Views\UserHeldDevices\Index.cshtml"
                                                             Write(item.EstimatedReturnTime);

            
            #line default
            #line hidden
WriteLiteral(")</span>\r\n");

            
            #line 25 "..\..\Areas\Public\Views\UserHeldDevices\Index.cshtml"
                }
                        
            
            #line default
            #line hidden
WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");

            
            #line 29 "..\..\Areas\Public\Views\UserHeldDevices\Index.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </table>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"column2\"");

WriteLiteral(">\r\n");

            
            #line 33 "..\..\Areas\Public\Views\UserHeldDevices\Index.cshtml"
        
            
            #line default
            #line hidden
            
            #line 33 "..\..\Areas\Public\Views\UserHeldDevices\Index.cshtml"
          
            var WaitingForUserActionJobs = Model.Where(i => i.WaitingForUserAction).ToArray();
        
            
            #line default
            #line hidden
WriteLiteral("\r\n        <h2>\r\n            Waiting for User Action (");

            
            #line 37 "..\..\Areas\Public\Views\UserHeldDevices\Index.cshtml"
                                Write(WaitingForUserActionJobs.Length);

            
            #line default
            #line hidden
WriteLiteral(")</h2>\r\n        <table");

WriteLiteral(" class=\"dataTable\"");

WriteLiteral(">\r\n");

            
            #line 39 "..\..\Areas\Public\Views\UserHeldDevices\Index.cshtml"
            
            
            #line default
            #line hidden
            
            #line 39 "..\..\Areas\Public\Views\UserHeldDevices\Index.cshtml"
             foreach (var item in WaitingForUserActionJobs)
            {

            
            #line default
            #line hidden
WriteLiteral("                <tr>\r\n                    <td");

WriteLiteral(" class=\"id\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 43 "..\..\Areas\Public\Views\UserHeldDevices\Index.cshtml"
                   Write(item.UserId);

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </td>\r\n                    <td");

WriteLiteral(" class=\"description\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 46 "..\..\Areas\Public\Views\UserHeldDevices\Index.cshtml"
                   Write(item.UserDisplayName);

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </td>\r\n                    <td");

WriteAttribute("class", Tuple.Create(" class=\"", 1795), Tuple.Create("\"", 1853)
, Tuple.Create(Tuple.Create("", 1803), Tuple.Create("timestamp", 1803), true)
            
            #line 48 "..\..\Areas\Public\Views\UserHeldDevices\Index.cshtml"
, Tuple.Create(Tuple.Create("", 1812), Tuple.Create<System.Object, System.Int32>(item.IsAlert ? " Alert" : string.Empty
            
            #line default
            #line hidden
, 1812), false)
);

WriteLiteral(">\r\n                        Since ");

            
            #line 49 "..\..\Areas\Public\Views\UserHeldDevices\Index.cshtml"
                         Write(item.WaitingForUserActionSince);

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");

            
            #line 52 "..\..\Areas\Public\Views\UserHeldDevices\Index.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </table>\r\n        <hr />\r\n");

            
            #line 55 "..\..\Areas\Public\Views\UserHeldDevices\Index.cshtml"
        
            
            #line default
            #line hidden
            
            #line 55 "..\..\Areas\Public\Views\UserHeldDevices\Index.cshtml"
          
            var DevicesReadyForReturn = Model.Where(i => i.ReadyForReturn && !i.WaitingForUserAction).ToArray();
        
            
            #line default
            #line hidden
WriteLiteral("\r\n        <h2>\r\n            Ready for Return (");

            
            #line 59 "..\..\Areas\Public\Views\UserHeldDevices\Index.cshtml"
                         Write(DevicesReadyForReturn.Length);

            
            #line default
            #line hidden
WriteLiteral(")</h2>\r\n        <table");

WriteLiteral(" class=\"dataTable\"");

WriteLiteral(">\r\n");

            
            #line 61 "..\..\Areas\Public\Views\UserHeldDevices\Index.cshtml"
            
            
            #line default
            #line hidden
            
            #line 61 "..\..\Areas\Public\Views\UserHeldDevices\Index.cshtml"
             foreach (var item in DevicesReadyForReturn)
            {

            
            #line default
            #line hidden
WriteLiteral("                <tr>\r\n                    <td");

WriteLiteral(" class=\"id\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 65 "..\..\Areas\Public\Views\UserHeldDevices\Index.cshtml"
                   Write(item.UserId);

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </td>\r\n                    <td");

WriteLiteral(" class=\"description\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 68 "..\..\Areas\Public\Views\UserHeldDevices\Index.cshtml"
                   Write(item.UserDisplayName);

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </td>\r\n                    <td");

WriteAttribute("class", Tuple.Create(" class=\"", 2612), Tuple.Create("\"", 2670)
, Tuple.Create(Tuple.Create("", 2620), Tuple.Create("timestamp", 2620), true)
            
            #line 70 "..\..\Areas\Public\Views\UserHeldDevices\Index.cshtml"
, Tuple.Create(Tuple.Create("", 2629), Tuple.Create<System.Object, System.Int32>(item.IsAlert ? " Alert" : string.Empty
            
            #line default
            #line hidden
, 2629), false)
);

WriteLiteral(">\r\n                        Ready ");

            
            #line 71 "..\..\Areas\Public\Views\UserHeldDevices\Index.cshtml"
                         Write(item.ReadyForReturnSince);

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");

            
            #line 74 "..\..\Areas\Public\Views\UserHeldDevices\Index.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </table>\r\n    </div>\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
