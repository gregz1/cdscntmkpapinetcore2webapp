#pragma checksum "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\CrmManager\GetOrderClaimListMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aea77ab8888db6ff6ffae66c9af60ed0f43c8b4d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CrmManager_GetOrderClaimListMessage), @"mvc.1.0.view", @"/Views/CrmManager/GetOrderClaimListMessage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CrmManager/GetOrderClaimListMessage.cshtml", typeof(AspNetCore.Views_CrmManager_GetOrderClaimListMessage))]
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
#line 2 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\_ViewImports.cshtml"
using cdscntmkpapinetcore2webapp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aea77ab8888db6ff6ffae66c9af60ed0f43c8b4d", @"/Views/CrmManager/GetOrderClaimListMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd17dbff09abcace87501202759f4739f3a1335f", @"/Views/_ViewImports.cshtml")]
    public class Views_CrmManager_GetOrderClaimListMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<cdscntmkpapinetcore2webapp.Models.CrmManager.GetOrderClaimListMessage>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(78, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\CrmManager\GetOrderClaimListMessage.cshtml"
  
    ViewData["Title"] = "GetOrderClaimList";

#line default
#line hidden
            BeginContext(133, 143, true);
            WriteLiteral("\r\n<br />\r\n<br />\r\n<div>\r\n    <br />\r\n    <br />\r\n    <br />\r\n    <br />\r\n    <br />\r\n    <br />\r\n\r\n    <h4>GetOrderClaimList</h4>\r\n    <hr />\r\n");
            EndContext();
#line 19 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\CrmManager\GetOrderClaimListMessage.cshtml"
 if (Model._OperationSuccess)
{

#line default
#line hidden
            BeginContext(310, 510, true);
            WriteLiteral(@"    <div class=""alert alert-success"">
        <strong>Success!</strong>
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
            BeginContext(821, 43, false);
#line 33 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\CrmManager\GetOrderClaimListMessage.cshtml"
                                                    Write(Html.DisplayFor(model => model._RequestXML));

#line default
#line hidden
            EndContext();
            BeginContext(864, 447, true);
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
            BeginContext(1312, 43, false);
#line 43 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\CrmManager\GetOrderClaimListMessage.cshtml"
                                                    Write(Html.DisplayFor(model => model._MessageXML));

#line default
#line hidden
            EndContext();
            BeginContext(1355, 62, true);
            WriteLiteral("</pre></div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 47 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\CrmManager\GetOrderClaimListMessage.cshtml"
}
else if (Model._ErrorMessage != "")
{

#line default
#line hidden
            BeginContext(1460, 89, true);
            WriteLiteral("    <div class=\"alert alert-danger\">\r\n        <strong>Failed!</strong> : error message : ");
            EndContext();
            BeginContext(1550, 19, false);
#line 51 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\CrmManager\GetOrderClaimListMessage.cshtml"
                                              Write(Model._ErrorMessage);

#line default
#line hidden
            EndContext();
            BeginContext(1569, 438, true);
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
            BeginContext(2008, 43, false);
#line 62 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\CrmManager\GetOrderClaimListMessage.cshtml"
                                                    Write(Html.DisplayFor(model => model._RequestXML));

#line default
#line hidden
            EndContext();
            BeginContext(2051, 447, true);
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
            BeginContext(2499, 43, false);
#line 72 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\CrmManager\GetOrderClaimListMessage.cshtml"
                                                    Write(Html.DisplayFor(model => model._MessageXML));

#line default
#line hidden
            EndContext();
            BeginContext(2542, 62, true);
            WriteLiteral("</pre></div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 76 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\CrmManager\GetOrderClaimListMessage.cshtml"

}
else
{

#line default
#line hidden
            BeginContext(2618, 89, true);
            WriteLiteral("    <div class=\"alert alert-warning\">\r\n        <strong>Warning!</strong> error message : ");
            EndContext();
            BeginContext(2708, 19, false);
#line 81 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\CrmManager\GetOrderClaimListMessage.cshtml"
                                             Write(Model._ErrorMessage);

#line default
#line hidden
            EndContext();
            BeginContext(2727, 15, true);
            WriteLiteral(".\r\n    </div>\r\n");
            EndContext();
#line 83 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\CrmManager\GetOrderClaimListMessage.cshtml"
}

#line default
#line hidden
            BeginContext(2745, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<cdscntmkpapinetcore2webapp.Models.CrmManager.GetOrderClaimListMessage> Html { get; private set; }
    }
}
#pragma warning restore 1591
