#pragma checksum "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetAllAllowedCategoryTreeRequest.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac8ec87ba7a6a302033ed02ebb94948c2bdfee7a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProductManager_GetAllAllowedCategoryTreeRequest), @"mvc.1.0.view", @"/Views/ProductManager/GetAllAllowedCategoryTreeRequest.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ProductManager/GetAllAllowedCategoryTreeRequest.cshtml", typeof(AspNetCore.Views_ProductManager_GetAllAllowedCategoryTreeRequest))]
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
#line 1 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\_ViewImports.cshtml"
using cdscntmkpapinetcore2webapp;

#line default
#line hidden
#line 1 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetAllAllowedCategoryTreeRequest.cshtml"
using cdscntmkpapinetcore2webapp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac8ec87ba7a6a302033ed02ebb94948c2bdfee7a", @"/Views/ProductManager/GetAllAllowedCategoryTreeRequest.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd17dbff09abcace87501202759f4739f3a1335f", @"/Views/_ViewImports.cshtml")]
    public class Views_ProductManager_GetAllAllowedCategoryTreeRequest : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<cdscntmkpapinetcore2webapp.Models.ProductManager.GetAllAllowedCategoryTreeRequest>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(132, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
#line 6 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetAllAllowedCategoryTreeRequest.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(179, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 11 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetAllAllowedCategoryTreeRequest.cshtml"
 using (Html.BeginForm("GetAllAllowedCategoryTreeMessage", "ProductManager", FormMethod.Post, new { enctype = "multipart/form-data" }))
{


#line default
#line hidden
            BeginContext(325, 636, true);
            WriteLiteral(@"    <br />
    <br />
    <h2>GetAllAllowedCategoryTree</h2>
    <div class=""col-xs-3"">
        <div class=""panel panel-info"">
            <div class=""panel-heading"">
                <h3 class=""panel-title"">Identification</h3>
            </div>
            <div class=""panel-body"">
                <div class=""tab-content"">
                    <br />
                    <div role=""tabpanel"" class=""tab-pane active"" id=""loginTab"">
                        <div class=""form-group"">
                            <label for=""usrname""><span class=""glyphicon glyphicon-user""></span> Username</label>
                            ");
            EndContext();
            BeginContext(962, 110, false);
#line 28 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetAllAllowedCategoryTreeRequest.cshtml"
                       Write(Html.TextBoxFor(model => model._Login, new { @id = "login", @class = "form-control", @placeholder = "Login" }));

#line default
#line hidden
            EndContext();
            BeginContext(1072, 226, true);
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            <label for=\"psw\"><span class=\"glyphicon glyphicon-eye-open\"></span> Password</label>\r\n                            ");
            EndContext();
            BeginContext(1299, 139, false);
#line 32 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetAllAllowedCategoryTreeRequest.cshtml"
                       Write(Html.TextBoxFor(model => model._Password, new { @id = "password", @class = "form-control", @placeholder = "Password", @type = "password" }));

#line default
#line hidden
            EndContext();
            BeginContext(1438, 223, true);
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            <label for=\"token\"><span class=\"glyphicon glyphicon-qrcode\"></span> Token</label>\r\n                            ");
            EndContext();
            BeginContext(1662, 110, false);
#line 36 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetAllAllowedCategoryTreeRequest.cshtml"
                       Write(Html.TextBoxFor(model => model._Token, new { @id = "token", @class = "form-control", @placeholder = "Token" }));

#line default
#line hidden
            EndContext();
            BeginContext(1772, 343, true);
            WriteLiteral(@"
                        </div>
                        <div class=""form-group"">
                            <label for=""Environment""><span class=""glyphicon glyphicon-qrcode""></span> Environment</label>
                            <br />
                            <p class=""nav navbar-nav navbar-left"">
                                ");
            EndContext();
            BeginContext(2116, 148, false);
#line 42 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetAllAllowedCategoryTreeRequest.cshtml"
                           Write(Html.DropDownListFor(m => m._EnvironmentSelected,new SelectList(Enum.GetValues(typeof(EnvironmentEnum))),
                    "Select Environment"));

#line default
#line hidden
            EndContext();
            BeginContext(2264, 432, true);
            WriteLiteral(@"
                            </p>
                            <br />
                        </div>
                    </div>
                </div>
            </div>

        </div>
    </div>
    <div class=""col-xs-5"">
        <div class=""panel panel-info"">
            <div class=""panel-heading"">
                <h3 class=""panel-title"">Parameters</h3>
            </div>
            <div class=""panel-body"">

");
            EndContext();
#line 60 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetAllAllowedCategoryTreeRequest.cshtml"
                 foreach (var parameter in Model._Parameters)
                {

#line default
#line hidden
            BeginContext(2778, 44, true);
            WriteLiteral("                    <br /><label for=\"item\">");
            EndContext();
            BeginContext(2823, 13, false);
#line 62 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetAllAllowedCategoryTreeRequest.cshtml"
                                       Write(parameter.Key);

#line default
#line hidden
            EndContext();
            BeginContext(2836, 10, true);
            WriteLiteral("</label>\r\n");
            EndContext();
            BeginContext(2867, 122, false);
#line 63 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetAllAllowedCategoryTreeRequest.cshtml"
               Write(Html.TextBoxFor(p => p._Parameters.Values, new { @id = "parameter", @class = "form-control", @placeholder = "parameter" }));

#line default
#line hidden
            EndContext();
#line 63 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetAllAllowedCategoryTreeRequest.cshtml"
                                                                                                                                               
                }

#line default
#line hidden
            BeginContext(3010, 48, true);
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
            BeginContext(3060, 195, true);
            WriteLiteral("        <div class=\"form-group\">\r\n            <input type=\"submit\" value=\"Send\" class=\"btn btn-info\" />\r\n            <input type=\"reset\" value=\"Reset\" class=\"btn btn-default\" />\r\n        </div>\r\n");
            EndContext();
#line 73 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetAllAllowedCategoryTreeRequest.cshtml"
        }

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<cdscntmkpapinetcore2webapp.Models.ProductManager.GetAllAllowedCategoryTreeRequest> Html { get; private set; }
    }
}
#pragma warning restore 1591