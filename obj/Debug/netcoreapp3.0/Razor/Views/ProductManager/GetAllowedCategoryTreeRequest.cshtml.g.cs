#pragma checksum "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetAllowedCategoryTreeRequest.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9b619ecc4910580330dc3eda104c247e95fde28"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProductManager_GetAllowedCategoryTreeRequest), @"mvc.1.0.view", @"/Views/ProductManager/GetAllowedCategoryTreeRequest.cshtml")]
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
#nullable restore
#line 1 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\_ViewImports.cshtml"
using cdscntmkpapinetcore2webapp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetAllowedCategoryTreeRequest.cshtml"
using cdscntmkpapinetcore2webapp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9b619ecc4910580330dc3eda104c247e95fde28", @"/Views/ProductManager/GetAllowedCategoryTreeRequest.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd17dbff09abcace87501202759f4739f3a1335f", @"/Views/_ViewImports.cshtml")]
    public class Views_ProductManager_GetAllowedCategoryTreeRequest : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<cdscntmkpapinetcore2webapp.Models.ProductManager.GetAllowedCategoryTreeRequest>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 5 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetAllowedCategoryTreeRequest.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 10 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetAllowedCategoryTreeRequest.cshtml"
 using (Html.BeginForm("GetAllowedCategoryTreeMessage", "ProductManager", FormMethod.Post, new { enctype = "multipart/form-data" }))
{


#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <br />
    <br />
    <h2>GetAllowedCategoryTree</h2>
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
#nullable restore
#line 27 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetAllowedCategoryTreeRequest.cshtml"
                       Write(Html.TextBoxFor(model => model._Login, new { @id = "login", @class = "form-control", @placeholder = "Login" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            <label for=\"psw\"><span class=\"glyphicon glyphicon-eye-open\"></span> Password</label>\r\n                            ");
#nullable restore
#line 31 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetAllowedCategoryTreeRequest.cshtml"
                       Write(Html.TextBoxFor(model => model._Password, new { @id = "password", @class = "form-control", @placeholder = "Password", @type = "password" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            <label for=\"token\"><span class=\"glyphicon glyphicon-qrcode\"></span> Token</label>\r\n                            ");
#nullable restore
#line 35 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetAllowedCategoryTreeRequest.cshtml"
                       Write(Html.TextBoxFor(model => model._Token, new { @id = "token", @class = "form-control", @placeholder = "Token" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                        <div class=""form-group"">
                            <label for=""Environment""><span class=""glyphicon glyphicon-qrcode""></span> Environment</label>
                            <br />
                            <p class=""nav navbar-nav navbar-left"">
                                ");
#nullable restore
#line 41 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetAllowedCategoryTreeRequest.cshtml"
                           Write(Html.DropDownListFor(m => m._EnvironmentSelected, new MultiSelectList(Enum.GetValues(typeof(EnvironmentEnum))), "Select Environment"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<br />                                
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
#nullable restore
#line 58 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetAllowedCategoryTreeRequest.cshtml"
                 foreach (var parameter in Model._Parameters)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <br /><label for=\"item\">");
#nullable restore
#line 60 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetAllowedCategoryTreeRequest.cshtml"
                                       Write(parameter.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n");
#nullable restore
#line 61 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetAllowedCategoryTreeRequest.cshtml"
               Write(Html.TextBoxFor(p => p._Parameters.Values, new { @id = "parameter", @class = "form-control", @placeholder = "parameter" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetAllowedCategoryTreeRequest.cshtml"
                                                                                                                                               
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n        </div>\r\n");
            WriteLiteral("        <div class=\"form-group\">\r\n            <input type=\"submit\" value=\"Send\" class=\"btn btn-info\" />\r\n            <input type=\"reset\" value=\"Reset\" class=\"btn btn-default\" />\r\n        </div>\r\n");
#nullable restore
#line 71 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetAllowedCategoryTreeRequest.cshtml"
        }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<cdscntmkpapinetcore2webapp.Models.ProductManager.GetAllowedCategoryTreeRequest> Html { get; private set; }
    }
}
#pragma warning restore 1591
