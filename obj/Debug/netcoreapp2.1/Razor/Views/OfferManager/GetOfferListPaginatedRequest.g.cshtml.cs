#pragma checksum "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OfferManager\GetOfferListPaginatedRequest.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d307c2aa3c9fea3859d9a08627cd0829474cad1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OfferManager_GetOfferListPaginatedRequest), @"mvc.1.0.view", @"/Views/OfferManager/GetOfferListPaginatedRequest.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/OfferManager/GetOfferListPaginatedRequest.cshtml", typeof(AspNetCore.Views_OfferManager_GetOfferListPaginatedRequest))]
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
#line 1 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OfferManager\GetOfferListPaginatedRequest.cshtml"
using cdscntmkpapinetcore2webapp.Models;

#line default
#line hidden
#line 2 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OfferManager\GetOfferListPaginatedRequest.cshtml"
using www.cdiscount.com;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d307c2aa3c9fea3859d9a08627cd0829474cad1", @"/Views/OfferManager/GetOfferListPaginatedRequest.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd17dbff09abcace87501202759f4739f3a1335f", @"/Views/_ViewImports.cshtml")]
    public class Views_OfferManager_GetOfferListPaginatedRequest : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<cdscntmkpapinetcore2webapp.Models.OfferManager.GetOfferListPaginatedRequest>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(152, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 6 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OfferManager\GetOfferListPaginatedRequest.cshtml"
  
    ViewData["Title"] = "GetOfferListPaginated";

#line default
#line hidden
            BeginContext(213, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 11 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OfferManager\GetOfferListPaginatedRequest.cshtml"
 using (Html.BeginForm("GetOfferListPaginatedMessage", "OfferManager", FormMethod.Post, new { enctype = "multipart/form-data" }))
{


#line default
#line hidden
            BeginContext(353, 632, true);
            WriteLiteral(@"    <br />
    <br />
    <h2>GetOfferListPaginated</h2>
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
            BeginContext(986, 110, false);
#line 28 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OfferManager\GetOfferListPaginatedRequest.cshtml"
                       Write(Html.TextBoxFor(model => model._Login, new { @id = "login", @class = "form-control", @placeholder = "Login" }));

#line default
#line hidden
            EndContext();
            BeginContext(1096, 226, true);
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            <label for=\"psw\"><span class=\"glyphicon glyphicon-eye-open\"></span> Password</label>\r\n                            ");
            EndContext();
            BeginContext(1323, 139, false);
#line 32 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OfferManager\GetOfferListPaginatedRequest.cshtml"
                       Write(Html.TextBoxFor(model => model._Password, new { @id = "password", @class = "form-control", @placeholder = "Password", @type = "password" }));

#line default
#line hidden
            EndContext();
            BeginContext(1462, 223, true);
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            <label for=\"token\"><span class=\"glyphicon glyphicon-qrcode\"></span> Token</label>\r\n                            ");
            EndContext();
            BeginContext(1686, 110, false);
#line 36 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OfferManager\GetOfferListPaginatedRequest.cshtml"
                       Write(Html.TextBoxFor(model => model._Token, new { @id = "token", @class = "form-control", @placeholder = "Token" }));

#line default
#line hidden
            EndContext();
            BeginContext(1796, 343, true);
            WriteLiteral(@"
                        </div>
                        <div class=""form-group"">
                            <label for=""Environment""><span class=""glyphicon glyphicon-qrcode""></span> Environment</label>
                            <br />
                            <p class=""nav navbar-nav navbar-left"">
                                ");
            EndContext();
            BeginContext(2140, 133, false);
#line 42 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OfferManager\GetOfferListPaginatedRequest.cshtml"
                           Write(Html.DropDownListFor(m => m._EnvironmentSelected, new MultiSelectList(Enum.GetValues(typeof(EnvironmentEnum))), "Select Environment"));

#line default
#line hidden
            EndContext();
            BeginContext(2273, 619, true);
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
                <label for=""Select Filter Criterion""><span class=""glyphicon glyphicon-filter""></span> Select Filter Criterion</label>
                ");
            EndContext();
            BeginContext(2893, 181, false);
#line 59 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OfferManager\GetOfferListPaginatedRequest.cshtml"
           Write(Html.DropDownListFor(m => m._OfferFilterPaginated.OfferFilterCriterion, new SelectList(Enum.GetValues(typeof(OfferFilterCriterion))),
                    "Select Filter Criterion"));

#line default
#line hidden
            EndContext();
            BeginContext(3074, 151, true);
            WriteLiteral("<br />\r\n                <label for=\"Select Sort Order\"><span class=\"glyphicon glyphicon-arrow-down\"></span> Select Sort Order</label>\r\n                ");
            EndContext();
            BeginContext(3226, 163, false);
#line 62 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OfferManager\GetOfferListPaginatedRequest.cshtml"
           Write(Html.DropDownListFor(m => m._OfferFilterPaginated.OfferSortOrder, new SelectList(Enum.GetValues(typeof(OfferSortOrder))),
                    "Select Sort Order"));

#line default
#line hidden
            EndContext();
            BeginContext(3389, 124, true);
            WriteLiteral("<br />\r\n                <label for=\"OfferPoolId\"><span class=\"glyphicon badge\"></span> OfferPoolId</label>\r\n                ");
            EndContext();
            BeginContext(3514, 139, false);
#line 65 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OfferManager\GetOfferListPaginatedRequest.cshtml"
           Write(Html.TextBoxFor(model => model._OfferFilterPaginated.OfferPoolId, new { @id = "poolId", @class = "form-control", @placeholder = "poolId" }));

#line default
#line hidden
            EndContext();
            BeginContext(3653, 131, true);
            WriteLiteral("<br />\r\n                <label for=\"PageNumber\"><span class=\"glyphicon glyphicon-book\"></span> PageNumber</label>\r\n                ");
            EndContext();
            BeginContext(3785, 146, false);
#line 67 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OfferManager\GetOfferListPaginatedRequest.cshtml"
           Write(Html.TextBoxFor(model => model._OfferFilterPaginated.PageNumber, new { @id = "PageNumber", @class = "form-control", @placeholder = "PageNumber" }));

#line default
#line hidden
            EndContext();
            BeginContext(3931, 60, true);
            WriteLiteral("<br />\r\n            </div>\r\n        </div>\r\n        </div>\r\n");
            EndContext();
            BeginContext(3995, 195, true);
            WriteLiteral("        <div class=\"form-group\">\r\n            <input type=\"submit\" value=\"Send\" class=\"btn btn-info\" />\r\n            <input type=\"reset\" value=\"Reset\" class=\"btn btn-default\" />\r\n        </div>\r\n");
            EndContext();
#line 77 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OfferManager\GetOfferListPaginatedRequest.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<cdscntmkpapinetcore2webapp.Models.OfferManager.GetOfferListPaginatedRequest> Html { get; private set; }
    }
}
#pragma warning restore 1591
