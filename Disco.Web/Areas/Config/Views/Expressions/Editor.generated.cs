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

namespace Disco.Web.Areas.Config.Views.Expressions
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Config/Views/Expressions/Editor.cshtml")]
    public partial class Editor : Disco.Services.Web.WebViewPage<Disco.Web.Areas.Config.Models.Expressions.EditorModel>
    {
        public Editor()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Areas\Config\Views\Expressions\Editor.cshtml"
  
    // Under Construction - Not In Production
    
    Authorization.Require(Claims.DiscoAdminAccount);
    
    ViewBag.Title = Html.ToBreadcrumb("Configuration", MVC.Config.Config.Index(), "Expressions");
    Html.BundleDeferred("~/ClientScripts/Modules/Disco-ExpressionEditor");

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" id=\"expressionEditor\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" id=\"expressionEditorContainer\"");

WriteLiteral(">\r\n    </div>\r\n    <div");

WriteLiteral(" id=\"expressionEditorExceptionContainer\"");

WriteLiteral(">\r\n        <h3>\r\n            Parse Error:</h3>\r\n        <div");

WriteLiteral(" id=\"expressionEditorException\"");

WriteLiteral(">\r\n        </div>\r\n    </div>\r\n    <button");

WriteLiteral(" id=\"expressionEditorValidateButton\"");

WriteLiteral(">\r\n        Validate</button>\r\n");

WriteLiteral("\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n        $(function () {\r\n            var initExpression = \'");

            
            #line 25 "..\..\Areas\Config\Views\Expressions\Editor.cshtml"
                              Write(Model.Expression);

            
            #line default
            #line hidden
WriteLiteral("\';\r\n            var hostSrcUrl = \'");

            
            #line 26 "..\..\Areas\Config\Views\Expressions\Editor.cshtml"
                          Write(Links.ClientSource.Style.ExpressionEditor_htm);

            
            #line default
            #line hidden
WriteLiteral(@"';
            var host = $('<iframe>').attr('src', hostSrcUrl).css({ width: '100%', height: 100, border: 'none' });
            $('#expressionEditorContainer').append(host);

            var $expressionEditorExceptionContainer = $('#expressionEditorExceptionContainer');
            var $expressionEditorException = $('#expressionEditorException');

            var editor = new DiscoExpressionEditor(host, '");

            
            #line 33 "..\..\Areas\Config\Views\Expressions\Editor.cshtml"
                                                      Write(Url.Action(MVC.API.Expressions.ValidateExpression()));

            
            #line default
            #line hidden
WriteLiteral(@"', initExpression);

            editor.expressionExceptionChanged = function (e) {
                if (e && !e.ExpressionValid) {
                    $expressionEditorException.text(e.Message);
                    $expressionEditorExceptionContainer.slideDown();
                } else {
                    $expressionEditorExceptionContainer.slideUp();
                }
            };
            editor.expressionValidated = function (result, e) {
                if (result)
                    alert('Validation Passed');
            };

            $('#expressionEditorValidateButton').click(function () {
                editor.validateExpression();
            });


            editor.hostInit();
        });
    </script>
</div>
");

        }
    }
}
#pragma warning restore 1591
