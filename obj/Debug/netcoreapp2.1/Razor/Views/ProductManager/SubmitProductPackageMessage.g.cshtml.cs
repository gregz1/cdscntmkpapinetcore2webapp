#pragma checksum "C:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\SubmitProductPackageMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "102c8e0d13222c7d3704e82bf40325ded4e9c9b3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProductManager_SubmitProductPackageMessage), @"mvc.1.0.view", @"/Views/ProductManager/SubmitProductPackageMessage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ProductManager/SubmitProductPackageMessage.cshtml", typeof(AspNetCore.Views_ProductManager_SubmitProductPackageMessage))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\_ViewImports.cshtml"
using cdscntmkpapinetcore2webapp;

#line default
#line hidden
#line 2 "C:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\_ViewImports.cshtml"
using cdscntmkpapinetcore2webapp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"102c8e0d13222c7d3704e82bf40325ded4e9c9b3", @"/Views/ProductManager/SubmitProductPackageMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd17dbff09abcace87501202759f4739f3a1335f", @"/Views/_ViewImports.cshtml")]
    public class Views_ProductManager_SubmitProductPackageMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<cdscntmkpapinetcore2webapp.Models.ProductManager.SubmitProductPackageMessage>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(85, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\SubmitProductPackageMessage.cshtml"
  
    ViewData["Title"] = "SubmitProductPackageMessage";

#line default
#line hidden
            BeginContext(150, 84, true);
            WriteLiteral("\r\n<h2>SubmitProductPackageMessage</h2>\r\n\r\n<div>\r\n    <h4>SubmitProductPackage</h4>\r\n");
            EndContext();
#line 11 "C:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\SubmitProductPackageMessage.cshtml"
     if (Model._OperationSuccess)
    {


#line default
#line hidden
            BeginContext(278, 646, true);
            WriteLiteral(@"        <div class=""alert alert-success"">
            <strong>Success!</strong>
        </div>
        <div>
            <hr />
            <div id=""MessageXML2"" class=""panel panel-default"">
            </div>
            <div class=""panel panel-default"">
                <div class=""panel-heading"">
                    <h4 class=""panel-title"">
                        <a data-toggle=""collapse"" href=""#RequestXML"">Click  to display the XML Request</a>
                    </h4>
                </div>
                <div id=""RequestXML"" class=""panel-collapse collapse"">
                    <div class=""panel-body""><pre lang=""xml""> ");
            EndContext();
            BeginContext(925, 43, false);
#line 28 "C:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\SubmitProductPackageMessage.cshtml"
                                                        Write(Html.DisplayFor(model => model._RequestXML));

#line default
#line hidden
            EndContext();
            BeginContext(968, 487, true);
            WriteLiteral(@"</pre></div>
                </div>
            </div>
            <div class=""panel panel-default"">
                <div class=""panel-heading"">
                    <h4 class=""panel-title"">
                        <a data-toggle=""collapse"" href=""#MessageXML"">Click  to display the XML Message</a>
                    </h4>
                </div>
                <div id=""MessageXML"" class=""panel-collapse collapse"">
                    <div class=""panel-body""><pre lang=""xml""> ");
            EndContext();
            BeginContext(1456, 43, false);
#line 38 "C:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\SubmitProductPackageMessage.cshtml"
                                                        Write(Html.DisplayFor(model => model._MessageXML));

#line default
#line hidden
            EndContext();
            BeginContext(1499, 74, true);
            WriteLiteral("</pre></div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 42 "C:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\SubmitProductPackageMessage.cshtml"
    }
    else if (Model._ErrorMessage != "")
    {

#line default
#line hidden
            BeginContext(1628, 97, true);
            WriteLiteral("        <div class=\"alert alert-danger\">\r\n            <strong>Failed!</strong> : error message : ");
            EndContext();
            BeginContext(1726, 19, false);
#line 46 "C:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\SubmitProductPackageMessage.cshtml"
                                                  Write(Model._ErrorMessage);

#line default
#line hidden
            EndContext();
            BeginContext(1745, 482, true);
            WriteLiteral(@"
        </div>
        <div>
            <hr />
            <div class=""panel panel-default"">
                <div class=""panel-heading"">
                    <h4 class=""panel-title"">
                        <a data-toggle=""collapse"" href=""#RequestXML"">Click  to display the XML Request</a>
                    </h4>
                </div>
                <div id=""RequestXML"" class=""panel-collapse collapse"">
                    <div class=""panel-body""><pre lang=""xml""> ");
            EndContext();
            BeginContext(2228, 43, false);
#line 57 "C:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\SubmitProductPackageMessage.cshtml"
                                                        Write(Html.DisplayFor(model => model._RequestXML));

#line default
#line hidden
            EndContext();
            BeginContext(2271, 121, true);
            WriteLiteral("</pre></div>\r\n                </div>\r\n            </div>\r\n            <div class=\"panel panel-default\">\r\n                ");
            EndContext();
            BeginContext(2393, 43, false);
#line 61 "C:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\SubmitProductPackageMessage.cshtml"
           Write(Html.DisplayFor(model => model._RequestXML));

#line default
#line hidden
            EndContext();
            BeginContext(2436, 384, true);
            WriteLiteral(@"
                <div class=""panel-heading"">
                    <h4 class=""panel-title"">
                        <a data-toggle=""collapse"" href=""#MessageXML"">Click  to display the XML Message</a>
                    </h4>
                </div>
                <div id=""MessageXML"" class=""panel-collapse collapse"">
                    <div class=""panel-body""><pre lang=""xml""> ");
            EndContext();
            BeginContext(2821, 43, false);
#line 68 "C:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\SubmitProductPackageMessage.cshtml"
                                                        Write(Html.DisplayFor(model => model._MessageXML));

#line default
#line hidden
            EndContext();
            BeginContext(2864, 74, true);
            WriteLiteral("</pre></div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 72 "C:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\SubmitProductPackageMessage.cshtml"

    }
    else
    {

#line default
#line hidden
            BeginContext(2964, 97, true);
            WriteLiteral("        <div class=\"alert alert-warning\">\r\n            <strong>Warning!</strong> error message : ");
            EndContext();
            BeginContext(3062, 19, false);
#line 77 "C:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\SubmitProductPackageMessage.cshtml"
                                                 Write(Model._ErrorMessage);

#line default
#line hidden
            EndContext();
            BeginContext(3081, 19, true);
            WriteLiteral(".\r\n        </div>\r\n");
            EndContext();
#line 79 "C:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\SubmitProductPackageMessage.cshtml"
    }

#line default
#line hidden
            BeginContext(3107, 166, true);
            WriteLiteral("\r\n    <script>\r\n\r\n    var editor = CodeMirror(document.getElementById(\"MessageXML2\"), {\r\n        mode: \"xml\",\r\n        height : \"auto\"\r\n    });\r\n    </script>\r\n</div>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<cdscntmkpapinetcore2webapp.Models.ProductManager.SubmitProductPackageMessage> Html { get; private set; }
    }
}
#pragma warning restore 1591
