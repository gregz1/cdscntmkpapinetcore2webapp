#pragma checksum "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\GetExternalOrderStatusMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d2551cd179c2cfb5d8e21084abc551c01dc4d3d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FBCManager_GetExternalOrderStatusMessage), @"mvc.1.0.view", @"/Views/FBCManager/GetExternalOrderStatusMessage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/FBCManager/GetExternalOrderStatusMessage.cshtml", typeof(AspNetCore.Views_FBCManager_GetExternalOrderStatusMessage))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d2551cd179c2cfb5d8e21084abc551c01dc4d3d", @"/Views/FBCManager/GetExternalOrderStatusMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd17dbff09abcace87501202759f4739f3a1335f", @"/Views/_ViewImports.cshtml")]
    public class Views_FBCManager_GetExternalOrderStatusMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<cdscntmkpapinetcore2webapp.Models.FBCManager.GetExternalOrderStatusMessage>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(83, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\GetExternalOrderStatusMessage.cshtml"
  
    ViewData["Title"] = "GetExternalOrderStatus";

#line default
#line hidden
            BeginContext(143, 70, true);
            WriteLiteral("\r\n<br />\r\n<br />\r\n<br />\r\n<div>\r\n    <h4>GetExternalOrderStatus</h4>\r\n");
            EndContext();
#line 12 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\GetExternalOrderStatusMessage.cshtml"
    if (Model._OperationSuccess)
   {


#line default
#line hidden
            BeginContext(255, 510, true);
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
            BeginContext(766, 43, false);
#line 27 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\GetExternalOrderStatusMessage.cshtml"
                                                    Write(Html.DisplayFor(model => model._RequestXML));

#line default
#line hidden
            EndContext();
            BeginContext(809, 447, true);
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
            BeginContext(1257, 43, false);
#line 37 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\GetExternalOrderStatusMessage.cshtml"
                                                    Write(Html.DisplayFor(model => model._MessageXML));

#line default
#line hidden
            EndContext();
            BeginContext(1300, 74, true);
            WriteLiteral("</pre></div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <br />\r\n");
            EndContext();
#line 42 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\GetExternalOrderStatusMessage.cshtml"
   }
   else if (Model._ErrorMessage != "")
   {

#line default
#line hidden
            BeginContext(1426, 89, true);
            WriteLiteral("    <div class=\"alert alert-danger\">\r\n        <strong>Failed!</strong> : error message : ");
            EndContext();
            BeginContext(1516, 19, false);
#line 46 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\GetExternalOrderStatusMessage.cshtml"
                                              Write(Model._ErrorMessage);

#line default
#line hidden
            EndContext();
            BeginContext(1535, 438, true);
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
            BeginContext(1974, 43, false);
#line 57 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\GetExternalOrderStatusMessage.cshtml"
                                                    Write(Html.DisplayFor(model => model._RequestXML));

#line default
#line hidden
            EndContext();
            BeginContext(2017, 105, true);
            WriteLiteral("</pre></div>\r\n            </div>\r\n        </div>\r\n        <div class=\"panel panel-default\">\r\n            ");
            EndContext();
            BeginContext(2123, 43, false);
#line 61 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\GetExternalOrderStatusMessage.cshtml"
       Write(Html.DisplayFor(model => model._RequestXML));

#line default
#line hidden
            EndContext();
            BeginContext(2166, 328, true);
            WriteLiteral(@"
        <div class=""panel-heading"">
            <h4 class=""panel-title"">
                <a data-toggle=""collapse"" href=""#MessageXML"">Click  to display the XML Message</a>
            </h4>
        </div>
        <div id=""MessageXML"" class=""panel-collapse collapse"">
            <div class=""panel-body""><pre lang=""xml""> ");
            EndContext();
            BeginContext(2495, 43, false);
#line 68 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\GetExternalOrderStatusMessage.cshtml"
                                                Write(Html.DisplayFor(model => model._MessageXML));

#line default
#line hidden
            EndContext();
            BeginContext(2538, 50, true);
            WriteLiteral("</pre></div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
#line 72 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\GetExternalOrderStatusMessage.cshtml"

   }
   else
   {

#line default
#line hidden
            BeginContext(2611, 89, true);
            WriteLiteral("    <div class=\"alert alert-warning\">\r\n        <strong>Warning!</strong> error message : ");
            EndContext();
            BeginContext(2701, 19, false);
#line 77 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\GetExternalOrderStatusMessage.cshtml"
                                             Write(Model._ErrorMessage);

#line default
#line hidden
            EndContext();
            BeginContext(2720, 15, true);
            WriteLiteral(".\r\n    </div>\r\n");
            EndContext();
#line 79 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\GetExternalOrderStatusMessage.cshtml"
   }

#line default
#line hidden
            BeginContext(2741, 270, true);
            WriteLiteral(@"
<script>

    var editor = CodeMirror(document.getElementById(""MessageXML2""), {
        mode: ""xml"",
        height: ""auto"",
        lineNumbers: ""true"",
        lineWrapping: ""true"",

    });
    editor.CodeMirror(document.textContent=""test"");
</script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<cdscntmkpapinetcore2webapp.Models.FBCManager.GetExternalOrderStatusMessage> Html { get; private set; }
    }
}
#pragma warning restore 1591
