#pragma checksum "C:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\AccountManager\GetSellerInformationRequest.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c4c9b2f5a655c4d4c49a296eb45346b29c55a924"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AccountManager_GetSellerInformationRequest), @"mvc.1.0.view", @"/Views/AccountManager/GetSellerInformationRequest.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AccountManager/GetSellerInformationRequest.cshtml", typeof(AspNetCore.Views_AccountManager_GetSellerInformationRequest))]
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
#line 1 "C:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\AccountManager\GetSellerInformationRequest.cshtml"
using cdscntmkpapinetcore2webapp.Models;

#line default
#line hidden
#line 2 "C:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\AccountManager\GetSellerInformationRequest.cshtml"
using www.cdiscount.com;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4c9b2f5a655c4d4c49a296eb45346b29c55a924", @"/Views/AccountManager/GetSellerInformationRequest.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd17dbff09abcace87501202759f4739f3a1335f", @"/Views/_ViewImports.cshtml")]
    public class Views_AccountManager_GetSellerInformationRequest : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<cdscntmkpapinetcore2webapp.Models.AccountManager.GetSellerInformationRequest>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(153, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 6 "C:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\AccountManager\GetSellerInformationRequest.cshtml"
  
    ViewData["Title"] = "GetSellerInformation";

#line default
#line hidden
            BeginContext(213, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 11 "C:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\AccountManager\GetSellerInformationRequest.cshtml"
 using (Html.BeginForm("GetSellerInformationMessage", "AccountManager", FormMethod.Post, new { enctype = "multipart/form-data" }))
{


#line default
#line hidden
            BeginContext(354, 638, true);
            WriteLiteral(@"    <br />
    <br />
    <h2>GetSellerInformationRequest</h2>
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
            BeginContext(993, 110, false);
#line 28 "C:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\AccountManager\GetSellerInformationRequest.cshtml"
                       Write(Html.TextBoxFor(model => model._Login, new { @id = "login", @class = "form-control", @placeholder = "Login" }));

#line default
#line hidden
            EndContext();
            BeginContext(1103, 226, true);
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            <label for=\"psw\"><span class=\"glyphicon glyphicon-eye-open\"></span> Password</label>\r\n                            ");
            EndContext();
            BeginContext(1330, 139, false);
#line 32 "C:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\AccountManager\GetSellerInformationRequest.cshtml"
                       Write(Html.TextBoxFor(model => model._Password, new { @id = "password", @class = "form-control", @placeholder = "Password", @type = "password" }));

#line default
#line hidden
            EndContext();
            BeginContext(1469, 223, true);
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            <label for=\"token\"><span class=\"glyphicon glyphicon-qrcode\"></span> Token</label>\r\n                            ");
            EndContext();
            BeginContext(1693, 110, false);
#line 36 "C:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\AccountManager\GetSellerInformationRequest.cshtml"
                       Write(Html.TextBoxFor(model => model._Token, new { @id = "token", @class = "form-control", @placeholder = "Token" }));

#line default
#line hidden
            EndContext();
            BeginContext(1803, 337, true);
            WriteLiteral(@"
                        </div>
                        <div class=""form-group"">
                            <label for=""token""><span class=""glyphicon glyphicon-qrcode""></span> Environment</label>
                            <br />
                            <p class=""nav navbar-nav navbar-left"">
                                ");
            EndContext();
            BeginContext(2141, 149, false);
#line 42 "C:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\AccountManager\GetSellerInformationRequest.cshtml"
                           Write(Html.DropDownListFor(m => m._EnvironmentSelected, new SelectList(Enum.GetValues(typeof(EnvironmentEnum))),
                    "Select Environment"));

#line default
#line hidden
            EndContext();
            BeginContext(2290, 206, true);
            WriteLiteral("\r\n                            </p>\r\n                            <br />\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n");
            EndContext();
            BeginContext(2504, 179, true);
            WriteLiteral("    <div class=\"form-group\">\r\n        <input type=\"submit\" value=\"Send\" class=\"btn btn-info\" />\r\n        <input type=\"reset\" value=\"Reset\" class=\"btn btn-default\" />\r\n    </div>\r\n");
            EndContext();
#line 59 "C:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\AccountManager\GetSellerInformationRequest.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<cdscntmkpapinetcore2webapp.Models.AccountManager.GetSellerInformationRequest> Html { get; private set; }
    }
}
#pragma warning restore 1591
