#pragma checksum "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetBrandListRequest.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd1b64fcefdb88d603e24185489e60515c378c9b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProductManager_GetBrandListRequest), @"mvc.1.0.view", @"/Views/ProductManager/GetBrandListRequest.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ProductManager/GetBrandListRequest.cshtml", typeof(AspNetCore.Views_ProductManager_GetBrandListRequest))]
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
#line 1 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetBrandListRequest.cshtml"
using cdscntmkpapinetcore2webapp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd1b64fcefdb88d603e24185489e60515c378c9b", @"/Views/ProductManager/GetBrandListRequest.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd17dbff09abcace87501202759f4739f3a1335f", @"/Views/_ViewImports.cshtml")]
    public class Views_ProductManager_GetBrandListRequest : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<cdscntmkpapinetcore2webapp.Models.ProductManager.GetBrandListRequest>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(119, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 5 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetBrandListRequest.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(164, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 10 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetBrandListRequest.cshtml"
 using (Html.BeginForm("GetBrandListMessage", "ProductManager", FormMethod.Post, new { enctype = "multipart/form-data" }))
{

    

#line default
#line hidden
            BeginContext(303, 674, true);
            WriteLiteral(@"    <br/>  
    <br />
    <h2>GetBrandList</h2>
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
            BeginContext(978, 110, false);
#line 28 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetBrandListRequest.cshtml"
                           Write(Html.TextBoxFor(model => model._Login, new { @id = "login", @class = "form-control", @placeholder = "Login" }));

#line default
#line hidden
            EndContext();
            BeginContext(1088, 242, true);
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"form-group\">\r\n                                <label for=\"psw\"><span class=\"glyphicon glyphicon-eye-open\"></span> Password</label>\r\n                                ");
            EndContext();
            BeginContext(1331, 139, false);
#line 32 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetBrandListRequest.cshtml"
                           Write(Html.TextBoxFor(model => model._Password, new { @id = "password", @class = "form-control", @placeholder = "Password", @type = "password" }));

#line default
#line hidden
            EndContext();
            BeginContext(1470, 239, true);
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"form-group\">\r\n                                <label for=\"token\"><span class=\"glyphicon glyphicon-qrcode\"></span> Token</label>\r\n                                ");
            EndContext();
            BeginContext(1710, 110, false);
#line 36 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetBrandListRequest.cshtml"
                           Write(Html.TextBoxFor(model => model._Token, new { @id = "token", @class = "form-control", @placeholder = "Token" }));

#line default
#line hidden
            EndContext();
            BeginContext(1820, 383, true);
            WriteLiteral(@"                                
                            </div>
                            <div class=""form-group"">
                            <label for=""Environment""><span class=""glyphicon glyphicon-qrcode""></span> Environment</label>
                            <br />
                            <p class=""nav navbar-nav navbar-left"">
                                ");
            EndContext();
            BeginContext(2204, 133, false);
#line 42 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetBrandListRequest.cshtml"
                           Write(Html.DropDownListFor(m => m._EnvironmentSelected, new MultiSelectList(Enum.GetValues(typeof(EnvironmentEnum))), "Select Environment"));

#line default
#line hidden
            EndContext();
            BeginContext(2337, 514, true);
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
            EndContext();
#line 59 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetBrandListRequest.cshtml"
                     foreach (var parameter in Model._Parameters)
                {

#line default
#line hidden
            BeginContext(2937, 48, true);
            WriteLiteral("                        <br /><label for=\"item\">");
            EndContext();
            BeginContext(2986, 13, false);
#line 61 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetBrandListRequest.cshtml"
                                           Write(parameter.Key);

#line default
#line hidden
            EndContext();
            BeginContext(2999, 10, true);
            WriteLiteral("</label>\r\n");
            EndContext();
            BeginContext(3034, 122, false);
#line 62 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetBrandListRequest.cshtml"
                   Write(Html.TextBoxFor(p => p._Parameters.Values, new { @id = "parameter", @class = "form-control", @placeholder = "parameter" }));

#line default
#line hidden
            EndContext();
#line 62 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetBrandListRequest.cshtml"
                                                                                                                                                   
                    }

#line default
#line hidden
            BeginContext(3181, 64, true);
            WriteLiteral("                </div>\r\n            </div>\r\n            </div>\r\n");
            EndContext();
            BeginContext(3247, 211, true);
            WriteLiteral("            <div class=\"form-group\">\r\n                <input type=\"submit\" value=\"Send\" class=\"btn btn-info\" />\r\n                <input type=\"reset\" value=\"Reset\" class=\"btn btn-default\" />\r\n            </div>\r\n");
            EndContext();
#line 72 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetBrandListRequest.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<cdscntmkpapinetcore2webapp.Models.ProductManager.GetBrandListRequest> Html { get; private set; }
    }
}
#pragma warning restore 1591
