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

namespace Disco.Web.Areas.Config.Views.Shared
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.5.4.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Config/Views/Shared/LogEvents.cshtml")]
    public partial class LogEvents : System.Web.Mvc.WebViewPage<Disco.Web.Areas.Config.Models.Shared.LogEventsModel>
    {
        public LogEvents()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Areas\Config\Views\Shared\LogEvents.cshtml"
  
    Html.BundleDeferred("~/ClientScripts/Modules/Knockout");
    Html.BundleDeferred("~/ClientScripts/Modules/jQuery-SignalR");
    var uniqueId = Guid.NewGuid().ToString("N");

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteAttribute("id", Tuple.Create(" id=\"", 251), Tuple.Create("\"", 277)
, Tuple.Create(Tuple.Create("", 256), Tuple.Create("LogEvents_", 256), true)
            
            #line 7 "..\..\Areas\Config\Views\Shared\LogEvents.cshtml"
, Tuple.Create(Tuple.Create("", 266), Tuple.Create<System.Object, System.Int32>(uniqueId
            
            #line default
            #line hidden
, 266), false)
);

WriteLiteral(" class=\"logEventsViewport\"");

WriteLiteral(">\r\n    <table");

WriteLiteral(" class=\"logEventsViewport\"");

WriteLiteral(">\r\n        <thead>\r\n            <tr>\r\n                <th");

WriteLiteral(" class=\"icon\"");

WriteLiteral(">&nbsp;\r\n                </th>\r\n                <th");

WriteLiteral(" class=\"timestamp\"");

WriteLiteral(">Date/Time\r\n                </th>\r\n                <th");

WriteLiteral(" class=\"eventType\"");

WriteLiteral(">Event Type\r\n                </th>\r\n                <th");

WriteLiteral(" class=\"message\"");

WriteLiteral(">Message\r\n                </th>\r\n            </tr>\r\n        </thead>\r\n    </table" +
">\r\n    <div");

WriteLiteral(" class=\"logEventsViewportContainer\"");

WriteAttribute("style", Tuple.Create(" style=\"", 752), Tuple.Create("\"", 962)
            
            #line 22 "..\..\Areas\Config\Views\Shared\LogEvents.cshtml"
, Tuple.Create(Tuple.Create("", 760), Tuple.Create<System.Object, System.Int32>(Model.ViewPortWidth.HasValue ? string.Format("width:{0}px;", Model.ViewPortWidth.Value) : null
            
            #line default
            #line hidden
, 760), false)
            
            #line 22 "..\..\Areas\Config\Views\Shared\LogEvents.cshtml"
                                                                      , Tuple.Create(Tuple.Create("", 857), Tuple.Create<System.Object, System.Int32>(Model.ViewPortHeight.HasValue ? string.Format("height:{0}px;", Model.ViewPortHeight.Value - 18) : null
            
            #line default
            #line hidden
, 857), false)
);

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"logEventsViewportNoLogs\"");

WriteLiteral(" data-bind=\"visible: EventLogs().length == 0\"");

WriteLiteral("\r\n            style=\"display: none\"");

WriteLiteral(">\r\n            No logs\r\n        </div>\r\n        <table");

WriteLiteral(" class=\"logEventsViewport\"");

WriteLiteral(" data-bind=\"visible: EventLogs().length > 0\"");

WriteLiteral(" style=\"display: none\"");

WriteLiteral(">\r\n            <tbody");

WriteLiteral(" data-bind=\"foreach: EventLogs\"");

WriteLiteral(">\r\n                <tr>\r\n                    <td");

WriteLiteral(" class=\"icon\"");

WriteLiteral(" data-bind=\"css: {information: EventTypeSeverity == 0, warning: EventTypeSeverity" +
" == 1, error: EventTypeSeverity == 2}\"");

WriteLiteral(">&nbsp;\r\n                    </td>\r\n                    <td");

WriteLiteral(" class=\"timestamp\"");

WriteLiteral(" data-bind=\"text: FormattedTimestamp\"");

WriteLiteral("></td>\r\n                    <td");

WriteLiteral(" class=\"eventType\"");

WriteLiteral(" data-bind=\"text: EventTypeName, attr: {title: ModuleDescription}\"");

WriteLiteral("></td>\r\n                    <td");

WriteLiteral(" class=\"message\"");

WriteLiteral(" data-bind=\"text: FormattedMessage, attr: {title: $parent.LogArguments($data)}\"");

WriteLiteral("></td>\r\n                </tr>\r\n            </tbody>\r\n        </table>\r\n    </div>" +
"\r\n");

            
            #line 39 "..\..\Areas\Config\Views\Shared\LogEvents.cshtml"
    
            
            #line default
            #line hidden
            
            #line 39 "..\..\Areas\Config\Views\Shared\LogEvents.cshtml"
      
        var eventTypesFilterJson = (Model.EventTypesFilter != null) ? Newtonsoft.Json.JsonConvert.SerializeObject(Model.EventTypesFilter.Select(et => et.Id).ToArray()) : "null";
    
            
            #line default
            #line hidden
WriteLiteral("\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n        $(function () {\r\n            var logEventsHost = $(\'LogEvents_");

            
            #line 44 "..\..\Areas\Config\Views\Shared\LogEvents.cshtml"
                                         Write(uniqueId);

            
            #line default
            #line hidden
WriteLiteral("\');\r\n            var logModuleId = \'");

            
            #line 45 "..\..\Areas\Config\Views\Shared\LogEvents.cshtml"
                           Write(Model.ModuleFilter != null ? Model.ModuleFilter.ModuleId.ToString() : null);

            
            #line default
            #line hidden
WriteLiteral("\';\r\n            var logModuleLiveGroupName = \'");

            
            #line 46 "..\..\Areas\Config\Views\Shared\LogEvents.cshtml"
                                      Write(Model.ModuleFilter != null ? Model.ModuleFilter.LiveLogGroupName : Disco.BI.Interop.SignalRHandlers.LogNotifications.AllNotifications);

            
            #line default
            #line hidden
WriteLiteral("\';\r\n            var logEventTypeFiltered = ");

            
            #line 47 "..\..\Areas\Config\Views\Shared\LogEvents.cshtml"
                                   Write(eventTypesFilterJson);

            
            #line default
            #line hidden
WriteLiteral(";\r\n            var logStartFiler = ");

            
            #line 48 "..\..\Areas\Config\Views\Shared\LogEvents.cshtml"
                            Write(AjaxHelpers.JsonDate(Model.StartFilter));

            
            #line default
            #line hidden
WriteLiteral(";\r\n            var logEndFiler = ");

            
            #line 49 "..\..\Areas\Config\Views\Shared\LogEvents.cshtml"
                          Write(AjaxHelpers.JsonDate(Model.EndFilter));

            
            #line default
            #line hidden
WriteLiteral(";\r\n            var logTakeFiler = \'");

            
            #line 50 "..\..\Areas\Config\Views\Shared\LogEvents.cshtml"
                            Write(Model.TakeFilter);

            
            #line default
            #line hidden
WriteLiteral("\';\r\n            var liveConnection = null;\r\n            var liveEventReceivedFunc" +
"tion = \'");

            
            #line 52 "..\..\Areas\Config\Views\Shared\LogEvents.cshtml"
                                         Write(Model.JavascriptLiveEventFunctionName);

            
            #line default
            #line hidden
WriteLiteral("\';\r\n            var useLive = (\'True\'===\'");

            
            #line 53 "..\..\Areas\Config\Views\Shared\LogEvents.cshtml"
                                 Write(Model.IsLive);

            
            #line default
            #line hidden
WriteLiteral(@"');

            // View Model
            var logsViewModel;
            function LogsViewModel(initialLogs){
                var self = this;

                self.EventLogs = ko.observableArray(initialLogs);
                self.LogArguments = function(log){
                    if (log.Arguments)
                        return log.Arguments.join('\n');
                    else
                        return null;
                };
            }
            function formatDate(d){
                if (d){
                    return d.getFullYear() + '-' + (d.getMonth() + 1) + '-' + d.getDate() + ' ' + d.getHours() + ':'+d.getMinutes()+':'+d.getSeconds();
                }else{
                    return null;
                }
            }
            function loadInitialData(){
                // Load Data
                var loadData = {
                    Format: ""json"",
                    Start: formatDate(logStartFiler),
                    End: logEndFiler,
                    ModuleId: logModuleId,
                    Take: logTakeFiler
                };
                if (logEventTypeFiltered)
                    loadData[""EventTypeIds""] = logEventTypeFiltered;
                $.ajax({
                    url: '");

            
            #line 87 "..\..\Areas\Config\Views\Shared\LogEvents.cshtml"
                      Write(Url.Action(MVC.API.Logging.RetrieveEvents()));

            
            #line default
            #line hidden
WriteLiteral(@"',
                    dataType: 'json',
                    type: 'POST',
                    data: loadData,
                    success: function (d) {
                        initLogs(d);
                    },
                    error: function (jqXHR, textStatus, errorThrown) {
                        alert('Unable to retrieve logs: ' + textStatus);
                    }
                });
            }

            function initLogs(loadedLogs){
                logsViewModel = new LogsViewModel(loadedLogs);
                ko.applyBindings(logsViewModel, logEventsHost.get(0));

                if (useLive){
                    if (liveEventReceivedFunction){
                        if (!document.DiscoFunctions) document.DiscoFunctions = {};
                        if (!document.DiscoFunctions.LogEventsFunctions) document.DiscoFunctions.LogEventsFunctions = {};
                        if (document.DiscoFunctions.LogEventsFunctions[liveEventReceivedFunction]){
                            liveEventReceivedFunction = document.DiscoFunctions.LogEventsFunctions[liveEventReceivedFunction];
                        }else{
                            liveEventReceivedFunction = null;
                        }
                    }

                    liveConnection = $.connection('");

            
            #line 115 "..\..\Areas\Config\Views\Shared\LogEvents.cshtml"
                                               Write(Url.Content("~/API/Logging/Notifications"));

            
            #line default
            #line hidden
WriteLiteral(@"');
                    liveConnection.received(logReceived);
                    liveConnection.error(function(e){if (e.status != 200) alert('Live-Log Error: '+e.statusText +': '+e.responseText);});
                    liveConnection.start(function(){
                        if (logModuleLiveGroupName){
                            liveConnection.send('/addToGroups:' + logModuleLiveGroupName);
                        }
                    });
                }
            }

            function logReceived(log){
                if (log.UseDisplay) logsViewModel.EventLogs.unshift(log);
                if (liveEventReceivedFunction) liveEventReceivedFunction(log);
            }

            loadInitialData();
        });
    </script>
</div>
");

        }
    }
}
#pragma warning restore 1591
