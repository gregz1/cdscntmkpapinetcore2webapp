#pragma checksum "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OfferManager\SubmitOfferPackageMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f4a12e0cbef5b9b59d999184e9c94e19844e504c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OfferManager_SubmitOfferPackageMessage), @"mvc.1.0.view", @"/Views/OfferManager/SubmitOfferPackageMessage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/OfferManager/SubmitOfferPackageMessage.cshtml", typeof(AspNetCore.Views_OfferManager_SubmitOfferPackageMessage))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4a12e0cbef5b9b59d999184e9c94e19844e504c", @"/Views/OfferManager/SubmitOfferPackageMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd17dbff09abcace87501202759f4739f3a1335f", @"/Views/_ViewImports.cshtml")]
    public class Views_OfferManager_SubmitOfferPackageMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<cdscntmkpapinetcore2webapp.Models.OfferManager.SubmitOfferPackageMessage>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(81, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OfferManager\SubmitOfferPackageMessage.cshtml"
  
    ViewData["Title"] = "SubmitOfferPackageMessage";

#line default
#line hidden
            BeginContext(144, 57, true);
            WriteLiteral("\r\n<br/>\r\n<br />\r\n<div>\r\n    <h4>SubmitOfferPackage</h4>\r\n");
            EndContext();
#line 11 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OfferManager\SubmitOfferPackageMessage.cshtml"
     if (Model._OperationSuccess)
    {


#line default
#line hidden
            BeginContext(245, 646, true);
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
            BeginContext(892, 43, false);
#line 28 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OfferManager\SubmitOfferPackageMessage.cshtml"
                                                        Write(Html.DisplayFor(model => model._RequestXML));

#line default
#line hidden
            EndContext();
            BeginContext(935, 487, true);
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
            BeginContext(1423, 43, false);
#line 38 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OfferManager\SubmitOfferPackageMessage.cshtml"
                                                        Write(Html.DisplayFor(model => model._MessageXML));

#line default
#line hidden
            EndContext();
            BeginContext(1466, 74, true);
            WriteLiteral("</pre></div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 42 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OfferManager\SubmitOfferPackageMessage.cshtml"
    }
    else if (Model._ErrorMessage != "")
    {

#line default
#line hidden
            BeginContext(1595, 97, true);
            WriteLiteral("        <div class=\"alert alert-danger\">\r\n            <strong>Failed!</strong> : error message : ");
            EndContext();
            BeginContext(1693, 19, false);
#line 46 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OfferManager\SubmitOfferPackageMessage.cshtml"
                                                  Write(Model._ErrorMessage);

#line default
#line hidden
            EndContext();
            BeginContext(1712, 482, true);
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
            BeginContext(2195, 43, false);
#line 57 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OfferManager\SubmitOfferPackageMessage.cshtml"
                                                        Write(Html.DisplayFor(model => model._RequestXML));

#line default
#line hidden
            EndContext();
            BeginContext(2238, 121, true);
            WriteLiteral("</pre></div>\r\n                </div>\r\n            </div>\r\n            <div class=\"panel panel-default\">\r\n                ");
            EndContext();
            BeginContext(2360, 43, false);
#line 61 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OfferManager\SubmitOfferPackageMessage.cshtml"
           Write(Html.DisplayFor(model => model._RequestXML));

#line default
#line hidden
            EndContext();
            BeginContext(2403, 384, true);
            WriteLiteral(@"
                <div class=""panel-heading"">
                    <h4 class=""panel-title"">
                        <a data-toggle=""collapse"" href=""#MessageXML"">Click  to display the XML Message</a>
                    </h4>
                </div>
                <div id=""MessageXML"" class=""panel-collapse collapse"">
                    <div class=""panel-body""><pre lang=""xml""> ");
            EndContext();
            BeginContext(2788, 43, false);
#line 68 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OfferManager\SubmitOfferPackageMessage.cshtml"
                                                        Write(Html.DisplayFor(model => model._MessageXML));

#line default
#line hidden
            EndContext();
            BeginContext(2831, 74, true);
            WriteLiteral("</pre></div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 72 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OfferManager\SubmitOfferPackageMessage.cshtml"

    }
    else
    {

#line default
#line hidden
            BeginContext(2931, 97, true);
            WriteLiteral("        <div class=\"alert alert-warning\">\r\n            <strong>Warning!</strong> error message : ");
            EndContext();
            BeginContext(3029, 19, false);
#line 77 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OfferManager\SubmitOfferPackageMessage.cshtml"
                                                 Write(Model._ErrorMessage);

#line default
#line hidden
            EndContext();
            BeginContext(3048, 19, true);
            WriteLiteral(".\r\n        </div>\r\n");
            EndContext();
#line 79 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OfferManager\SubmitOfferPackageMessage.cshtml"
    }

#line default
#line hidden
            BeginContext(3074, 166, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<cdscntmkpapinetcore2webapp.Models.OfferManager.SubmitOfferPackageMessage> Html { get; private set; }
    }
}
#pragma warning restore 1591
