#pragma checksum "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\CrmManager\CloseDiscussionListMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "058dba58a7e5d8fa58751d75cf9a3bce66677dec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CrmManager_CloseDiscussionListMessage), @"mvc.1.0.view", @"/Views/CrmManager/CloseDiscussionListMessage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CrmManager/CloseDiscussionListMessage.cshtml", typeof(AspNetCore.Views_CrmManager_CloseDiscussionListMessage))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"058dba58a7e5d8fa58751d75cf9a3bce66677dec", @"/Views/CrmManager/CloseDiscussionListMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd17dbff09abcace87501202759f4739f3a1335f", @"/Views/_ViewImports.cshtml")]
    public class Views_CrmManager_CloseDiscussionListMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<cdscntmkpapinetcore2webapp.Models.CrmManager.CloseDiscussionListMessage>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(80, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\CrmManager\CloseDiscussionListMessage.cshtml"
  
    ViewData["Title"] = "CloseDiscussionList";

#line default
#line hidden
            BeginContext(137, 59, true);
            WriteLiteral("\r\n<br />\r\n<br />\r\n<div>\r\n    <h4>CloseDiscussionList</h4>\r\n");
            EndContext();
#line 11 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\CrmManager\CloseDiscussionListMessage.cshtml"
     if (Model._OperationSuccess)
    {


#line default
#line hidden
            BeginContext(240, 646, true);
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
            BeginContext(887, 43, false);
#line 28 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\CrmManager\CloseDiscussionListMessage.cshtml"
                                                        Write(Html.DisplayFor(model => model._RequestXML));

#line default
#line hidden
            EndContext();
            BeginContext(930, 487, true);
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
            BeginContext(1418, 43, false);
#line 38 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\CrmManager\CloseDiscussionListMessage.cshtml"
                                                        Write(Html.DisplayFor(model => model._MessageXML));

#line default
#line hidden
            EndContext();
            BeginContext(1461, 74, true);
            WriteLiteral("</pre></div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 42 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\CrmManager\CloseDiscussionListMessage.cshtml"
    }
    else if (Model._ErrorMessage != "")
    {

#line default
#line hidden
            BeginContext(1590, 97, true);
            WriteLiteral("        <div class=\"alert alert-danger\">\r\n            <strong>Failed!</strong> : error message : ");
            EndContext();
            BeginContext(1688, 19, false);
#line 46 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\CrmManager\CloseDiscussionListMessage.cshtml"
                                                  Write(Model._ErrorMessage);

#line default
#line hidden
            EndContext();
            BeginContext(1707, 482, true);
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
            BeginContext(2190, 43, false);
#line 57 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\CrmManager\CloseDiscussionListMessage.cshtml"
                                                        Write(Html.DisplayFor(model => model._RequestXML));

#line default
#line hidden
            EndContext();
            BeginContext(2233, 121, true);
            WriteLiteral("</pre></div>\r\n                </div>\r\n            </div>\r\n            <div class=\"panel panel-default\">\r\n                ");
            EndContext();
            BeginContext(2355, 43, false);
#line 61 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\CrmManager\CloseDiscussionListMessage.cshtml"
           Write(Html.DisplayFor(model => model._RequestXML));

#line default
#line hidden
            EndContext();
            BeginContext(2398, 384, true);
            WriteLiteral(@"
                <div class=""panel-heading"">
                    <h4 class=""panel-title"">
                        <a data-toggle=""collapse"" href=""#MessageXML"">Click  to display the XML Message</a>
                    </h4>
                </div>
                <div id=""MessageXML"" class=""panel-collapse collapse"">
                    <div class=""panel-body""><pre lang=""xml""> ");
            EndContext();
            BeginContext(2783, 43, false);
#line 68 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\CrmManager\CloseDiscussionListMessage.cshtml"
                                                        Write(Html.DisplayFor(model => model._MessageXML));

#line default
#line hidden
            EndContext();
            BeginContext(2826, 74, true);
            WriteLiteral("</pre></div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 72 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\CrmManager\CloseDiscussionListMessage.cshtml"

    }
    else
    {

#line default
#line hidden
            BeginContext(2926, 97, true);
            WriteLiteral("        <div class=\"alert alert-warning\">\r\n            <strong>Warning!</strong> error message : ");
            EndContext();
            BeginContext(3024, 19, false);
#line 77 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\CrmManager\CloseDiscussionListMessage.cshtml"
                                                 Write(Model._ErrorMessage);

#line default
#line hidden
            EndContext();
            BeginContext(3043, 19, true);
            WriteLiteral(".\r\n        </div>\r\n");
            EndContext();
#line 79 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\CrmManager\CloseDiscussionListMessage.cshtml"
    }

#line default
#line hidden
            BeginContext(3069, 170, true);
            WriteLiteral("\r\n    <script>\r\n\r\n    var editor = CodeMirror(document.getElementById(\"MessageXML2\"), {\r\n        mode: \"xml\",\r\n        height : \"auto\"\r\n    });\r\n    </script>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<cdscntmkpapinetcore2webapp.Models.CrmManager.CloseDiscussionListMessage> Html { get; private set; }
    }
}
#pragma warning restore 1591
