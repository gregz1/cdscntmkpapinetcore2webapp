#pragma checksum "C:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetModelListMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a10d827c9a7c797a7be32ddcd928eec2c0e54710"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProductManager_GetModelListMessage), @"mvc.1.0.view", @"/Views/ProductManager/GetModelListMessage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ProductManager/GetModelListMessage.cshtml", typeof(AspNetCore.Views_ProductManager_GetModelListMessage))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a10d827c9a7c797a7be32ddcd928eec2c0e54710", @"/Views/ProductManager/GetModelListMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd17dbff09abcace87501202759f4739f3a1335f", @"/Views/_ViewImports.cshtml")]
    public class Views_ProductManager_GetModelListMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<cdscntmkpapinetcore2webapp.Models.ProductManager.GetModelListMessage>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(77, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetModelListMessage.cshtml"
  
    ViewData["Title"] = "GetAllModelList";

#line default
#line hidden
            BeginContext(130, 248, true);
            WriteLiteral("\r\n<link rel=\"stylesheet\" href=\"src/jquery.treefilter.css\">\r\n<br />\r\n<br />\r\n<div>\r\n    <div class=\"container\">\r\n        <br />\r\n        <br />\r\n        <br />\r\n        <br />\r\n        <br />\r\n        <br />\r\n\r\n        <h4>GetModelListMessage</h4>\r\n");
            EndContext();
#line 20 "C:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetModelListMessage.cshtml"
         if (Model._OperationSuccess)
        {


#line default
#line hidden
            BeginContext(430, 706, true);
            WriteLiteral(@"            <div class=""alert alert-success"">
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
            BeginContext(1137, 43, false);
#line 37 "C:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetModelListMessage.cshtml"
                                                            Write(Html.DisplayFor(model => model._RequestXML));

#line default
#line hidden
            EndContext();
            BeginContext(1180, 527, true);
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
            BeginContext(1708, 43, false);
#line 47 "C:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetModelListMessage.cshtml"
                                                            Write(Html.DisplayFor(model => model._MessageXML));

#line default
#line hidden
            EndContext();
            BeginContext(1751, 86, true);
            WriteLiteral("</pre></div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 51 "C:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetModelListMessage.cshtml"
        }
        else if (Model._ErrorMessage != "")
        {

#line default
#line hidden
            BeginContext(1904, 105, true);
            WriteLiteral("            <div class=\"alert alert-danger\">\r\n                <strong>Failed!</strong> : error message : ");
            EndContext();
            BeginContext(2010, 19, false);
#line 55 "C:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetModelListMessage.cshtml"
                                                      Write(Model._ErrorMessage);

#line default
#line hidden
            EndContext();
            BeginContext(2029, 526, true);
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
            BeginContext(2556, 43, false);
#line 66 "C:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetModelListMessage.cshtml"
                                                            Write(Html.DisplayFor(model => model._RequestXML));

#line default
#line hidden
            EndContext();
            BeginContext(2599, 137, true);
            WriteLiteral("</pre></div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"panel panel-default\">\r\n                    ");
            EndContext();
            BeginContext(2737, 43, false);
#line 70 "C:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetModelListMessage.cshtml"
               Write(Html.DisplayFor(model => model._RequestXML));

#line default
#line hidden
            EndContext();
            BeginContext(2780, 412, true);
            WriteLiteral(@"
                    <div class=""panel-heading"">
                        <h4 class=""panel-title"">
                            <a data-toggle=""collapse"" href=""#MessageXML"">Click  to display the XML Message</a>
                        </h4>
                    </div>
                    <div id=""MessageXML"" class=""panel-collapse collapse"">
                        <div class=""panel-body""><pre lang=""xml""> ");
            EndContext();
            BeginContext(3193, 43, false);
#line 77 "C:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetModelListMessage.cshtml"
                                                            Write(Html.DisplayFor(model => model._MessageXML));

#line default
#line hidden
            EndContext();
            BeginContext(3236, 86, true);
            WriteLiteral("</pre></div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 81 "C:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetModelListMessage.cshtml"

        }
        else
        {

#line default
#line hidden
            BeginContext(3360, 105, true);
            WriteLiteral("            <div class=\"alert alert-warning\">\r\n                <strong>Warning!</strong> error message : ");
            EndContext();
            BeginContext(3466, 19, false);
#line 86 "C:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetModelListMessage.cshtml"
                                                     Write(Model._ErrorMessage);

#line default
#line hidden
            EndContext();
            BeginContext(3485, 23, true);
            WriteLiteral(".\r\n            </div>\r\n");
            EndContext();
#line 88 "C:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetModelListMessage.cshtml"
        }

#line default
#line hidden
            BeginContext(3519, 178, true);
            WriteLiteral("\r\n        <script>\r\n\r\n    var editor = CodeMirror(document.getElementById(\"MessageXML2\"), {\r\n        mode: \"xml\",\r\n        height : \"auto\"\r\n    });\r\n        </script>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<cdscntmkpapinetcore2webapp.Models.ProductManager.GetModelListMessage> Html { get; private set; }
    }
}
#pragma warning restore 1591