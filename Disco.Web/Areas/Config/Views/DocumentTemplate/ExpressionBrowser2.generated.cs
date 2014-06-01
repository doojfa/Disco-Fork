﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Disco.Web.Areas.Config.Views.DocumentTemplate
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Config/Views/DocumentTemplate/ExpressionBrowser.cshtml")]
    public partial class ExpressionBrowser : Disco.Services.Web.WebViewPage<Disco.Web.Areas.Config.Models.DocumentTemplate.ExpressionBrowserModel>
    {
        public ExpressionBrowser()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Areas\Config\Views\DocumentTemplate\ExpressionBrowser.cshtml"
  
    Authorization.Require(Claims.Config.Show);
    
    ViewBag.Title = Html.ToBreadcrumb("Configuration", MVC.Config.Config.Index(), "Document Templates", MVC.Config.DocumentTemplate.Index(null), "Expression Browser");
    Html.BundleDeferred("~/Style/jQueryUI/dynatree");
    Html.BundleDeferred("~/ClientScripts/Modules/jQueryUI-DynaTree");

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" id=\"configurationDocumentTemplateExpressionBrowser\"");

WriteLiteral(">\r\n    Expressions within Disco are based on the <a");

WriteLiteral(" href=\"http://www.springframework.net/\"");

WriteLiteral("\r\n        target=\"_blank\"");

WriteLiteral(">Spring.NET Framework</a>. Please refer to the <a");

WriteLiteral(" href=\"http://www.springframework.net/doc-latest/reference/html/expressions.html\"" +
"");

WriteLiteral("\r\n            target=\"_blank\"");

WriteLiteral(">Expression Evaluation</a> documentation.\r\n    <h2>\r\n        Device Scope</h2>\r\n " +
"   <div");

WriteLiteral(" id=\"deviceScopeTree\"");

WriteLiteral(" class=\"expressionTree\"");

WriteLiteral(">\r\n    </div>\r\n    <h2>\r\n        Job Scope</h2>\r\n    <div");

WriteLiteral(" id=\"jobScopeTree\"");

WriteLiteral(" class=\"expressionTree\"");

WriteLiteral(">\r\n    </div>\r\n    <h2>\r\n        User Scope</h2>\r\n    <div");

WriteLiteral(" id=\"userScopeTree\"");

WriteLiteral(" class=\"expressionTree\"");

WriteLiteral(">\r\n    </div>\r\n    <h2>\r\n        Variables\r\n    </h2>\r\n    <div");

WriteLiteral(" id=\"variableScopeTree\"");

WriteLiteral(" class=\"expressionTree\"");

WriteLiteral(">\r\n    </div>\r\n    <h2>\r\n        Extension Libraries</h2>\r\n    <div");

WriteLiteral(" id=\"extScopeTree\"");

WriteLiteral(" class=\"expressionTree\"");

WriteLiteral(">\r\n    </div>\r\n</div>\r\n<script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n    $(function () {\r\n        if (!document.DiscoFunctions) {\r\n            docu" +
"ment.DiscoFunctions = {};\r\n        }\r\n\r\n        var typeLib = {};\r\n        var l" +
"oadTypeUrl = \'");

            
            #line 42 "..\..\Areas\Config\Views\DocumentTemplate\ExpressionBrowser.cshtml"
                       Write(Url.Action(MVC.Config.DocumentTemplate.ExpressionBrowser()));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n        var deviceScopeTree = $(\'#deviceScopeTree\');\r\n        var jobScopeTre" +
"e = $(\'#jobScopeTree\');\r\n        var userScopeTree = $(\'#userScopeTree\');\r\n     " +
"   var variableScopeTree = $(\'#variableScopeTree\');\r\n        var extScopeTree = " +
"$(\'#extScopeTree\');\r\n\r\n        var lazyLoadNode = function (node) {\r\n           " +
" if (node.data.expressionType) {\r\n                node.setLazyNodeStatus(DTNodeS" +
"tatus_Loading);\r\n                loadType(node, node.data.expressionType, node.d" +
"ata.staticDeclaredMembersOnly);\r\n            } else {\r\n                if (node." +
"data.memberDescriptor) {\r\n                    loadMember(node);\r\n               " +
" } else {\r\n                    node.setLazyNodeStatus(DTNodeStatus_Ok);\r\n       " +
"         }\r\n            }\r\n        }\r\n        var loadMember = function (memberN" +
"ode) {\r\n            var previousUpdateMode = memberNode.tree.enableUpdate(false)" +
";\r\n            var memberDescriptor = memberNode.data.memberDescriptor;\r\n       " +
"     // Return Type\r\n            memberNode.addChild({ title: \'Returns: \' + memb" +
"erDescriptor.ReturnType, tooltip: memberDescriptor.ReturnExpressionType, isFolde" +
"r: true, expressionType: memberDescriptor.ReturnExpressionType, isLazy: true, ad" +
"dClass: \'object\' });\r\n            // Parameters\r\n            var parametersNode " +
"= memberNode.addChild({ title: \'Parameters\', isFolder: true, addClass: \'paramete" +
"r\' });\r\n            for (var i = 0; i < memberDescriptor.Parameters.length; i++)" +
" {\r\n                var p = memberDescriptor.Parameters[i];\r\n                par" +
"ametersNode.addChild({ title: p.Name + \' [\' + p.ReturnType + \']\', tooltip: p.Ret" +
"urnExpressionType, addClass: \'object\' });\r\n            }\r\n            memberNode" +
".setLazyNodeStatus(DTNodeStatus_Ok);\r\n            memberNode.tree.enableUpdate(p" +
"reviousUpdateMode);\r\n        }\r\n        var typeLoaded = function (parentNode, t" +
"ypeDescriptor) {\r\n            var previousUpdateMode = parentNode.tree.enableUpd" +
"ate(false);\r\n            for (var i = 0; i < typeDescriptor.Members.length; i++)" +
" {\r\n                var memberDescriptor = typeDescriptor.Members[i];\r\n         " +
"       parentNode.addChild({ title: memberDescriptor.Name, tooltip: memberDescri" +
"ptor.ReturnType, isFolder: true, addClass: memberDescriptor.Kind, memberDescript" +
"or: memberDescriptor, isLazy: true });\r\n            }\r\n            parentNode.se" +
"tLazyNodeStatus(DTNodeStatus_Ok);\r\n            parentNode.tree.enableUpdate(prev" +
"iousUpdateMode);\r\n        }\r\n\r\n        var loadType = function (parentNode, type" +
", staticDeclaredMembersOnly) {\r\n            if (typeLib[type]) {\r\n              " +
"  typeLoaded(parentNode, typeLib[type]);\r\n            } else {\r\n                " +
"var requestData = { type: type, StaticDeclaredMembersOnly: staticDeclaredMembers" +
"Only };\r\n                $.getJSON(loadTypeUrl, requestData, function (data) {\r\n" +
"                    typeLib[type] = data;\r\n                    typeLoaded(parent" +
"Node, data);\r\n                });\r\n            }\r\n        }\r\n\r\n        var initV" +
"ariable = function (name, type) {\r\n            variableScopeTree.dynatree(\'getRo" +
"ot\').addChild({ title: name, tooltip: type, isFolder: true, addClass: \'object\', " +
"expressionType: type, isLazy: true });\r\n        }\r\n        var initExpressionLib" +
"rary = function (name, type) {\r\n            extScopeTree.dynatree(\'getRoot\').add" +
"Child({ title: name, tooltip: type, isFolder: true, addClass: \'object\', expressi" +
"onType: type, staticDeclaredMembersOnly: true, isLazy: true });\r\n        }\r\n\r\n  " +
"      // Init\r\n        deviceScopeTree.dynatree({ onLazyRead: lazyLoadNode });\r\n" +
"        loadType(deviceScopeTree.dynatree(\'getRoot\'), \'");

            
            #line 106 "..\..\Areas\Config\Views\DocumentTemplate\ExpressionBrowser.cshtml"
                                                   Write(Model.DeviceType);

            
            #line default
            #line hidden
WriteLiteral("\');\r\n\r\n        jobScopeTree.dynatree({ onLazyRead: lazyLoadNode });\r\n        load" +
"Type(jobScopeTree.dynatree(\'getRoot\'), \'");

            
            #line 109 "..\..\Areas\Config\Views\DocumentTemplate\ExpressionBrowser.cshtml"
                                                Write(Model.JobType);

            
            #line default
            #line hidden
WriteLiteral("\');\r\n\r\n        userScopeTree.dynatree({ onLazyRead: lazyLoadNode });\r\n        loa" +
"dType(userScopeTree.dynatree(\'getRoot\'), \'");

            
            #line 112 "..\..\Areas\Config\Views\DocumentTemplate\ExpressionBrowser.cshtml"
                                                 Write(Model.UserType);

            
            #line default
            #line hidden
WriteLiteral(@"');

        variableScopeTree.dynatree({ onLazyRead: lazyLoadNode });
        document.DiscoFunctions.expressionInitVariable = initVariable;
        
        extScopeTree.dynatree({ onLazyRead: lazyLoadNode });
        document.DiscoFunctions.expressionInitExpressionLibrary = initExpressionLibrary;
    });
</script>
    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n        $(function () {\r\n");

            
            #line 123 "..\..\Areas\Config\Views\DocumentTemplate\ExpressionBrowser.cshtml"
  
foreach (var variable in Model.Variables)
{

            
            #line default
            #line hidden
WriteLiteral("           ");

WriteLiteral("document.DiscoFunctions.expressionInitVariable(\'");

            
            #line 126 "..\..\Areas\Config\Views\DocumentTemplate\ExpressionBrowser.cshtml"
                                                             Write(variable.Key);

            
            #line default
            #line hidden
WriteLiteral("\', \'");

            
            #line 126 "..\..\Areas\Config\Views\DocumentTemplate\ExpressionBrowser.cshtml"
                                                                               Write(variable.Value);

            
            #line default
            #line hidden
WriteLiteral("\');");

WriteLiteral("\r\n");

            
            #line 127 "..\..\Areas\Config\Views\DocumentTemplate\ExpressionBrowser.cshtml"
}
foreach (var variable in Model.ExtensionLibraries)
{

            
            #line default
            #line hidden
WriteLiteral("           ");

WriteLiteral("document.DiscoFunctions.expressionInitExpressionLibrary(\'");

            
            #line 130 "..\..\Areas\Config\Views\DocumentTemplate\ExpressionBrowser.cshtml"
                                                                      Write(variable.Key);

            
            #line default
            #line hidden
WriteLiteral("\', \'");

            
            #line 130 "..\..\Areas\Config\Views\DocumentTemplate\ExpressionBrowser.cshtml"
                                                                                        Write(variable.Value);

            
            #line default
            #line hidden
WriteLiteral("\');");

WriteLiteral("\r\n");

            
            #line 131 "..\..\Areas\Config\Views\DocumentTemplate\ExpressionBrowser.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("\r\n        });\r\n    </script>");

        }
    }
}
#pragma warning restore 1591
