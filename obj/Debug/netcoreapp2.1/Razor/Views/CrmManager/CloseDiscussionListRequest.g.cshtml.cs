#pragma checksum "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\CrmManager\CloseDiscussionListRequest.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3903bfc57f934f8f8993327d39b9f63dab995b6d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CrmManager_CloseDiscussionListRequest), @"mvc.1.0.view", @"/Views/CrmManager/CloseDiscussionListRequest.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CrmManager/CloseDiscussionListRequest.cshtml", typeof(AspNetCore.Views_CrmManager_CloseDiscussionListRequest))]
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
#line 1 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\CrmManager\CloseDiscussionListRequest.cshtml"
using cdscntmkpapinetcore2webapp.Models;

#line default
#line hidden
#line 2 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\CrmManager\CloseDiscussionListRequest.cshtml"
using www.cdiscount.com;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3903bfc57f934f8f8993327d39b9f63dab995b6d", @"/Views/CrmManager/CloseDiscussionListRequest.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd17dbff09abcace87501202759f4739f3a1335f", @"/Views/_ViewImports.cshtml")]
    public class Views_CrmManager_CloseDiscussionListRequest : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<cdscntmkpapinetcore2webapp.Models.CrmManager.CloseDiscussionListRequest>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(148, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 6 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\CrmManager\CloseDiscussionListRequest.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(193, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 11 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\CrmManager\CloseDiscussionListRequest.cshtml"
 using (Html.BeginForm("CloseDiscussionListMessage", "CrmManager", FormMethod.Post, new { enctype = "multipart/form-data" }))
{


#line default
#line hidden
            BeginContext(329, 630, true);
            WriteLiteral(@"    <br />
    <br />
    <h2>CloseDiscussionList</h2>
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
            BeginContext(960, 110, false);
#line 28 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\CrmManager\CloseDiscussionListRequest.cshtml"
                       Write(Html.TextBoxFor(model => model._Login, new { @id = "login", @class = "form-control", @placeholder = "Login" }));

#line default
#line hidden
            EndContext();
            BeginContext(1070, 226, true);
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            <label for=\"psw\"><span class=\"glyphicon glyphicon-eye-open\"></span> Password</label>\r\n                            ");
            EndContext();
            BeginContext(1297, 139, false);
#line 32 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\CrmManager\CloseDiscussionListRequest.cshtml"
                       Write(Html.TextBoxFor(model => model._Password, new { @id = "password", @class = "form-control", @placeholder = "Password", @type = "password" }));

#line default
#line hidden
            EndContext();
            BeginContext(1436, 223, true);
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            <label for=\"token\"><span class=\"glyphicon glyphicon-qrcode\"></span> Token</label>\r\n                            ");
            EndContext();
            BeginContext(1660, 110, false);
#line 36 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\CrmManager\CloseDiscussionListRequest.cshtml"
                       Write(Html.TextBoxFor(model => model._Token, new { @id = "token", @class = "form-control", @placeholder = "Token" }));

#line default
#line hidden
            EndContext();
            BeginContext(1770, 337, true);
            WriteLiteral(@"
                        </div>
                        <div class=""form-group"">
                            <label for=""token""><span class=""glyphicon glyphicon-qrcode""></span> Environment</label>
                            <br />
                            <p class=""nav navbar-nav navbar-left"">
                                ");
            EndContext();
            BeginContext(2108, 149, false);
#line 42 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\CrmManager\CloseDiscussionListRequest.cshtml"
                           Write(Html.DropDownListFor(m => m._EnvironmentSelected, new SelectList(Enum.GetValues(typeof(EnvironmentEnum))),
                    "Select Environment"));

#line default
#line hidden
            EndContext();
            BeginContext(2257, 562, true);
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

                <label for=""DiscussionIds""><span class=""glyphicon glyphicon-comment""></span>DiscussionId</label>
                ");
            EndContext();
            BeginContext(2820, 181, false);
#line 61 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\CrmManager\CloseDiscussionListRequest.cshtml"
           Write(Html.TextBoxFor(model => model._CloseDiscussionRequest.DiscussionIds, new { @id = "DiscussionId", @class = "form-control", @placeholder = "DiscussionId,DiscussionId,DiscussionId" }));

#line default
#line hidden
            EndContext();
            BeginContext(3001, 56, true);
            WriteLiteral("\r\n\r\n            </div>\r\n        </div>\r\n        </div>\r\n");
            EndContext();
            BeginContext(3059, 195, true);
            WriteLiteral("        <div class=\"form-group\">\r\n            <input type=\"submit\" value=\"Send\" class=\"btn btn-info\" />\r\n            <input type=\"reset\" value=\"Reset\" class=\"btn btn-default\" />\r\n        </div>\r\n");
            EndContext();
#line 71 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\CrmManager\CloseDiscussionListRequest.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<cdscntmkpapinetcore2webapp.Models.CrmManager.CloseDiscussionListRequest> Html { get; private set; }
    }
}
#pragma warning restore 1591
