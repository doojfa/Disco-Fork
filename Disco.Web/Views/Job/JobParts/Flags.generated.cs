﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Disco.Web.Views.Job.JobParts
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
    using Disco;
    using Disco.BI.Extensions;
    using Disco.Models.Repository;
    using Disco.Services;
    using Disco.Services.Authorization;
    using Disco.Services.Web;
    using Disco.Web;
    using Disco.Web.Extensions;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Job/JobParts/Flags.cshtml")]
    public partial class Flags : Disco.Services.Web.WebViewPage<Disco.Web.Models.Job.ShowModel>
    {
        public Flags()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\Job\JobParts\Flags.cshtml"
  
    Authorization.Require(Claims.Job.ShowFlags);

    var validFlags = Model.Job.ValidFlagsGrouped();
    var canEdit = Authorization.Has(Claims.Job.Properties.Flags);

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" id=\"jobDetailTab-Flags\"");

WriteLiteral(" class=\"jobPart\"");

WriteLiteral(">\r\n    <table");

WriteLiteral(" id=\"jobFlags\"");

WriteLiteral(">\r\n");

            
            #line 10 "..\..\Views\Job\JobParts\Flags.cshtml"
        
            
            #line default
            #line hidden
            
            #line 10 "..\..\Views\Job\JobParts\Flags.cshtml"
         foreach (var flagGroup in validFlags)
        {

            
            #line default
            #line hidden
WriteLiteral("            <tr>\r\n                <th>\r\n                    <span");

WriteLiteral(" class=\"flagGroupName\"");

WriteLiteral(">");

            
            #line 14 "..\..\Views\Job\JobParts\Flags.cshtml"
                                           Write(flagGroup.Key);

            
            #line default
            #line hidden
WriteLiteral("</span><br />\r\n");

WriteLiteral("                    ");

            
            #line 15 "..\..\Views\Job\JobParts\Flags.cshtml"
               Write(AjaxHelpers.AjaxLoader());

            
            #line default
            #line hidden
WriteLiteral("\r\n                </th>\r\n                <td>\r\n");

            
            #line 18 "..\..\Views\Job\JobParts\Flags.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 18 "..\..\Views\Job\JobParts\Flags.cshtml"
                     foreach (var flagItem in flagGroup.Value)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <div>\r\n                            <input");

WriteLiteral(" type=\"checkbox\"");

WriteAttribute("value", Tuple.Create(" value=\"", 728), Tuple.Create("\"", 751)
            
            #line 21 "..\..\Views\Job\JobParts\Flags.cshtml"
, Tuple.Create(Tuple.Create("", 736), Tuple.Create<System.Object, System.Int32>(flagItem.Item1
            
            #line default
            #line hidden
, 736), false)
);

WriteAttribute("id", Tuple.Create(" id=\"", 752), Tuple.Create("\"", 782)
, Tuple.Create(Tuple.Create("", 757), Tuple.Create("jobFlag_", 757), true)
            
            #line 21 "..\..\Views\Job\JobParts\Flags.cshtml"
         , Tuple.Create(Tuple.Create("", 765), Tuple.Create<System.Object, System.Int32>(flagItem.Item1
            
            #line default
            #line hidden
, 765), false)
);

WriteLiteral(" ");

            
            #line 21 "..\..\Views\Job\JobParts\Flags.cshtml"
                                                                                                      Write(flagItem.Item3 ? new HtmlString("checked=\"checked\"") : new HtmlString(string.Empty));

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 21 "..\..\Views\Job\JobParts\Flags.cshtml"
                                                                                                                                                                                               Write(canEdit ? new HtmlString(string.Empty) : new HtmlString("disabled=\"disabled\""));

            
            #line default
            #line hidden
WriteLiteral(" /><label");

WriteAttribute("id", Tuple.Create(" id=\"", 965), Tuple.Create("\"", 1000)
, Tuple.Create(Tuple.Create("", 970), Tuple.Create("jobFlagLabel_", 970), true)
            
            #line 21 "..\..\Views\Job\JobParts\Flags.cshtml"
                                                                                                                                                                                                                                   , Tuple.Create(Tuple.Create("", 983), Tuple.Create<System.Object, System.Int32>(flagItem.Item1
            
            #line default
            #line hidden
, 983), false)
);

WriteAttribute("for", Tuple.Create(" for=\"", 1001), Tuple.Create("\"", 1032)
, Tuple.Create(Tuple.Create("", 1007), Tuple.Create("jobFlag_", 1007), true)
            
            #line 21 "..\..\Views\Job\JobParts\Flags.cshtml"
                                                                                                                                                                                                                                                                  , Tuple.Create(Tuple.Create("", 1015), Tuple.Create<System.Object, System.Int32>(flagItem.Item1
            
            #line default
            #line hidden
, 1015), false)
);

WriteLiteral(">");

            
            #line 21 "..\..\Views\Job\JobParts\Flags.cshtml"
                                                                                                                                                                                                                                                                                                                                                               Write(flagItem.Item2);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                        </div>\r\n");

            
            #line 23 "..\..\Views\Job\JobParts\Flags.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </td>\r\n            </tr>\r\n");

            
            #line 26 "..\..\Views\Job\JobParts\Flags.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </table>\r\n");

            
            #line 28 "..\..\Views\Job\JobParts\Flags.cshtml"
    
            
            #line default
            #line hidden
            
            #line 28 "..\..\Views\Job\JobParts\Flags.cshtml"
     if (canEdit)
    {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" id=\"dialogFlagsAction\"");

WriteLiteral(" title=\"Add Flag\"");

WriteLiteral(">\r\n");

            
            #line 31 "..\..\Views\Job\JobParts\Flags.cshtml"
            
            
            #line default
            #line hidden
            
            #line 31 "..\..\Views\Job\JobParts\Flags.cshtml"
             using (Html.BeginForm(MVC.API.Job.UpdateFlag(Model.Job.Id, null, null, true)))
            {

            
            #line default
            #line hidden
WriteLiteral("                <input");

WriteLiteral(" id=\"dialogFlagsActionFlag\"");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" name=\"Flag\"");

WriteLiteral(" value=\"0\"");

WriteLiteral(" />\r\n");

WriteLiteral("                <h3>Reason:</h3>\r\n");

WriteLiteral("                <p>\r\n                    <textarea");

WriteLiteral(" name=\"Reason\"");

WriteLiteral(" class=\"block\"");

WriteLiteral("></textarea>\r\n                </p>\r\n");

            
            #line 38 "..\..\Views\Job\JobParts\Flags.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\r\n");

WriteLiteral("        <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n            $(\'#jobDetailTabItems\').append(\'<li><a href=\"#jobDetailTab-Flags\">" +
"Flags [");

            
            #line 41 "..\..\Views\Job\JobParts\Flags.cshtml"
                                                                                 Write(validFlags.SelectMany(g => g.Value).Count(f => f.Item3));

            
            #line default
            #line hidden
WriteLiteral(@"]</a></li>');
            $(function () {
                var $flagCheckboxes = $('#jobFlags').find('input[type=""checkbox""]');
                var $dialogFlagsAction = $('#dialogFlagsAction');
                var $flagCheckbox;

                var updateFlags = function () {
                    $flagCheckbox = $(this);
                    var flagValue = $flagCheckbox.val();

                    if ($flagCheckbox.is(':checked')) {
                        // Add
                        $('#dialogFlagsActionFlag').val(flagValue);
                        var title = 'Add Flag: ' + $flagCheckbox.closest('tr').find('th .flagGroupName').text() + ': ' + $('#jobFlagLabel_' + flagValue).text();
                        $dialogFlagsAction.dialog('option', 'title', title);
                        $dialogFlagsAction.dialog('open');
                    } else {
                        // Remove
                        var $ajaxLoading = $flagCheckbox.closest('tr').find('span.ajaxLoading');
                        $ajaxLoading.show();
                        $.getJSON('");

            
            #line 61 "..\..\Views\Job\JobParts\Flags.cshtml"
                               Write(Url.Action(MVC.API.Job.UpdateFlag(Model.Job.Id, null, null, false)));

            
            #line default
            #line hidden
WriteLiteral(@"', { Flag: '-' + flagValue }, function (response, result) {
                        if (result != 'success' || response != 'OK') {
                            alert('Unable to change Flag:\n' + response);
                            $ajaxLoading.hide();
                        } else {
                            $ajaxLoading.hide().next('.ajaxOk').show().delay('fast').fadeOut('slow');
                        }
                    })
                }
            };
            $dialogFlagsAction.dialog({
                resizable: false,
                height: 240,
                modal: true,
                autoOpen: false,
                buttons: {
                    ""Add"": function () {
                        var $this = $(this);
                        $this.dialog(""disable"");
                        $this.dialog(""option"", ""buttons"", null);
                        $this.find('form').first().submit();
                    },
                    Cancel: function () {
                        $(this).dialog(""close"");
                    }
                },
                close: function () {
                    $flagCheckbox.prop('checked', false);
                }
            });

            $flagCheckboxes.click(updateFlags);
        });
        </script>
");

            
            #line 95 "..\..\Views\Job\JobParts\Flags.cshtml"
    }else
    {

            
            #line default
            #line hidden
WriteLiteral("        <script>\r\n            $(\'#jobDetailTabItems\').append(\'<li><a href=\"#jobDe" +
"tailTab-Flags\">Flags [");

            
            #line 98 "..\..\Views\Job\JobParts\Flags.cshtml"
                                                                                 Write(validFlags.SelectMany(g => g.Value).Count(f => f.Item3));

            
            #line default
            #line hidden
WriteLiteral("]</a></li>\');\r\n        </script>\r\n");

            
            #line 100 "..\..\Views\Job\JobParts\Flags.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

        }
    }
}
#pragma warning restore 1591
