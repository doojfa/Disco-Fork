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

namespace Disco.Web.Areas.Public.Views.Public
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Public/Views/Public/Index.cshtml")]
    public partial class Index : System.Web.Mvc.WebViewPage<dynamic>
    {
        public Index()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Areas\Public\Views\Public\Index.cshtml"
  
    ViewBag.Title = Html.ToBreadcrumb("Public Reports", null);

            
            #line default
            #line hidden
WriteLiteral("\r\n<table");

WriteLiteral(" id=\"pageMenu\"");

WriteLiteral(">\r\n    <tr>\r\n        <td");

WriteLiteral(" style=\"width: 50%\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"pageMenuArea\"");

WriteLiteral(">\r\n                <h2>Technician Held Devices for Users</h2>\r\n");

WriteLiteral("                ");

            
            #line 9 "..\..\Areas\Public\Views\Public\Index.cshtml"
           Write(Html.ActionLinkClass("Report", MVC.Public.UserHeldDevices.Index(), "report"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                <div");

WriteLiteral(" class=\"pageMenuBlurb\"");

WriteLiteral(@">
                    Display users involved in current jobs where the user's device is held by the technicians.
                    Also displays users which should report to the technicians to collect their device
                    which is ready to be returned to them.
                </div>
");

WriteLiteral("                ");

            
            #line 15 "..\..\Areas\Public\Views\Public\Index.cshtml"
           Write(Html.ActionLinkClass("Noticeboard", MVC.Public.UserHeldDevices.Noticeboard(), "noticeboard"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                <div");

WriteLiteral(" class=\"pageMenuBlurb\"");

WriteLiteral(@">
                    Display a full-screen active noticeboard screen which lists users involved in current
                    jobs where the user's device is held by the technicians. Also displays users which
                    should report to the technicians to collect their device which is ready to be returned
                    to them.
                </div>
            </div>
        </td>
        <td");

WriteLiteral(" style=\"width: 50%\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"pageMenuArea\"");

WriteLiteral(">\r\n                <h2>Technician Held Devices</h2>\r\n");

WriteLiteral("                ");

            
            #line 27 "..\..\Areas\Public\Views\Public\Index.cshtml"
           Write(Html.ActionLinkClass("Report", MVC.Public.HeldDevices.Index(), "report"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                <div");

WriteLiteral(" class=\"pageMenuBlurb\"");

WriteLiteral(">\r\n                    Display devices involved in current jobs where the device " +
"is held by the technicians.\r\n                    Also displays devices which are" +
" ready to be collected.\r\n                </div>\r\n");

WriteLiteral("                ");

            
            #line 32 "..\..\Areas\Public\Views\Public\Index.cshtml"
           Write(Html.ActionLinkClass("Noticeboard", MVC.Public.HeldDevices.Noticeboard(), "noticeboard"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                <div");

WriteLiteral(" class=\"pageMenuBlurb\"");

WriteLiteral(@">
                    Display a full-screen active noticeboard screen which lists devices involved in current
                    jobs where the device is held by the technicians. Also displays devices which are ready to be collected.
                </div>
            </div>
        </td>
    </tr>
</table>
");

        }
    }
}
#pragma warning restore 1591
