#pragma checksum "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OfferManager\GetOfferListPaginatedMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19fad6617103e1a0ef972a5cdca23ab3c62bc509"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OfferManager_GetOfferListPaginatedMessage), @"mvc.1.0.view", @"/Views/OfferManager/GetOfferListPaginatedMessage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/OfferManager/GetOfferListPaginatedMessage.cshtml", typeof(AspNetCore.Views_OfferManager_GetOfferListPaginatedMessage))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19fad6617103e1a0ef972a5cdca23ab3c62bc509", @"/Views/OfferManager/GetOfferListPaginatedMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd17dbff09abcace87501202759f4739f3a1335f", @"/Views/_ViewImports.cshtml")]
    public class Views_OfferManager_GetOfferListPaginatedMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<cdscntmkpapinetcore2webapp.Models.OfferManager.GetOfferListPaginatedMessage>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(84, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OfferManager\GetOfferListPaginatedMessage.cshtml"
  
    ViewData["Title"] = "GetOfferListPaginated";

#line default
#line hidden
            BeginContext(143, 69, true);
            WriteLiteral("\r\n<br />\r\n<br />\r\n<br />\r\n<div>\r\n    <h4>GetOfferListPaginated</h4>\r\n");
            EndContext();
#line 12 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OfferManager\GetOfferListPaginatedMessage.cshtml"
 if (Model._OperationSuccess)
{


#line default
#line hidden
            BeginContext(248, 586, true);
            WriteLiteral(@"    <div class=""alert alert-success"">
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
            BeginContext(835, 43, false);
#line 29 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OfferManager\GetOfferListPaginatedMessage.cshtml"
                                                    Write(Html.DisplayFor(model => model._RequestXML));

#line default
#line hidden
            EndContext();
            BeginContext(878, 447, true);
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
            BeginContext(1326, 43, false);
#line 39 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OfferManager\GetOfferListPaginatedMessage.cshtml"
                                                    Write(Html.DisplayFor(model => model._MessageXML));

#line default
#line hidden
            EndContext();
            BeginContext(1369, 62, true);
            WriteLiteral("</pre></div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 43 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OfferManager\GetOfferListPaginatedMessage.cshtml"
}
else if (Model._ErrorMessage != "")
{

#line default
#line hidden
            BeginContext(1474, 89, true);
            WriteLiteral("    <div class=\"alert alert-danger\">\r\n        <strong>Failed!</strong> : error message : ");
            EndContext();
            BeginContext(1564, 19, false);
#line 47 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OfferManager\GetOfferListPaginatedMessage.cshtml"
                                              Write(Model._ErrorMessage);

#line default
#line hidden
            EndContext();
            BeginContext(1583, 438, true);
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
            BeginContext(2022, 43, false);
#line 58 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OfferManager\GetOfferListPaginatedMessage.cshtml"
                                                    Write(Html.DisplayFor(model => model._RequestXML));

#line default
#line hidden
            EndContext();
            BeginContext(2065, 105, true);
            WriteLiteral("</pre></div>\r\n            </div>\r\n        </div>\r\n        <div class=\"panel panel-default\">\r\n            ");
            EndContext();
            BeginContext(2171, 43, false);
#line 62 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OfferManager\GetOfferListPaginatedMessage.cshtml"
       Write(Html.DisplayFor(model => model._RequestXML));

#line default
#line hidden
            EndContext();
            BeginContext(2214, 328, true);
            WriteLiteral(@"
        <div class=""panel-heading"">
            <h4 class=""panel-title"">
                <a data-toggle=""collapse"" href=""#MessageXML"">Click  to display the XML Message</a>
            </h4>
        </div>
        <div id=""MessageXML"" class=""panel-collapse collapse"">
            <div class=""panel-body""><pre lang=""xml""> ");
            EndContext();
            BeginContext(2543, 43, false);
#line 69 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OfferManager\GetOfferListPaginatedMessage.cshtml"
                                                Write(Html.DisplayFor(model => model._MessageXML));

#line default
#line hidden
            EndContext();
            BeginContext(2586, 50, true);
            WriteLiteral("</pre></div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
#line 73 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OfferManager\GetOfferListPaginatedMessage.cshtml"

}
else
{

#line default
#line hidden
            BeginContext(2650, 89, true);
            WriteLiteral("    <div class=\"alert alert-warning\">\r\n        <strong>Warning!</strong> error message : ");
            EndContext();
            BeginContext(2740, 19, false);
#line 78 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OfferManager\GetOfferListPaginatedMessage.cshtml"
                                             Write(Model._ErrorMessage);

#line default
#line hidden
            EndContext();
            BeginContext(2759, 15, true);
            WriteLiteral(".\r\n    </div>\r\n");
            EndContext();
#line 80 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OfferManager\GetOfferListPaginatedMessage.cshtml"
}

#line default
#line hidden
            BeginContext(2777, 162, true);
            WriteLiteral("\r\n<script>\r\n\r\n    var editor = CodeMirror(document.getElementById(\"MessageXML2\"), {\r\n        mode: \"xml\",\r\n        height : \"auto\"\r\n    });\r\n</script>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<cdscntmkpapinetcore2webapp.Models.OfferManager.GetOfferListPaginatedMessage> Html { get; private set; }
    }
}
#pragma warning restore 1591
