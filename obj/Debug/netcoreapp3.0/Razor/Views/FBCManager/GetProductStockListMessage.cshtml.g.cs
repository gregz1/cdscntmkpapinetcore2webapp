#pragma checksum "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\GetProductStockListMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff5fad8a7401aa32dcd131ca09a54e95d51e9c71"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FBCManager_GetProductStockListMessage), @"mvc.1.0.view", @"/Views/FBCManager/GetProductStockListMessage.cshtml")]
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
#line 2 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\_ViewImports.cshtml"
using cdscntmkpapinetcore2webapp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff5fad8a7401aa32dcd131ca09a54e95d51e9c71", @"/Views/FBCManager/GetProductStockListMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd17dbff09abcace87501202759f4739f3a1335f", @"/Views/_ViewImports.cshtml")]
    public class Views_FBCManager_GetProductStockListMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<cdscntmkpapinetcore2webapp.Models.FBCManager.GetProductStockListMessage>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\GetProductStockListMessage.cshtml"
  
    ViewData["Title"] = "GetProductStockList";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n<br />\r\n<br />\r\n<div>\r\n    <h4>GetProductStockList</h4>\r\n");
#nullable restore
#line 12 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\GetProductStockListMessage.cshtml"
    if (Model._OperationSuccess)
   {


#line default
#line hidden
#nullable disable
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
#nullable restore
#line 27 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\GetProductStockListMessage.cshtml"
                                                    Write(Html.DisplayFor(model => model._RequestXML));

#line default
#line hidden
#nullable disable
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
#nullable restore
#line 37 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\GetProductStockListMessage.cshtml"
                                                    Write(Html.DisplayFor(model => model._MessageXML));

#line default
#line hidden
#nullable disable
            WriteLiteral("</pre></div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <br />\r\n");
#nullable restore
#line 42 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\GetProductStockListMessage.cshtml"
   }
   else if (Model._ErrorMessage != "")
   {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger\">\r\n        <strong>Failed!</strong> : error message : ");
#nullable restore
#line 46 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\GetProductStockListMessage.cshtml"
                                              Write(Model._ErrorMessage);

#line default
#line hidden
#nullable disable
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
#nullable restore
#line 57 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\GetProductStockListMessage.cshtml"
                                                    Write(Html.DisplayFor(model => model._RequestXML));

#line default
#line hidden
#nullable disable
            WriteLiteral("</pre></div>\r\n            </div>\r\n        </div>\r\n        <div class=\"panel panel-default\">\r\n            ");
#nullable restore
#line 61 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\GetProductStockListMessage.cshtml"
       Write(Html.DisplayFor(model => model._RequestXML));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        <div class=""panel-heading"">
            <h4 class=""panel-title"">
                <a data-toggle=""collapse"" href=""#MessageXML"">Click  to display the XML Message</a>
            </h4>
        </div>
        <div id=""MessageXML"" class=""panel-collapse collapse"">
            <div class=""panel-body""><pre lang=""xml""> ");
#nullable restore
#line 68 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\GetProductStockListMessage.cshtml"
                                                Write(Html.DisplayFor(model => model._MessageXML));

#line default
#line hidden
#nullable disable
            WriteLiteral("</pre></div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 72 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\GetProductStockListMessage.cshtml"

   }
   else
   {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-warning\">\r\n        <strong>Warning!</strong> error message : ");
#nullable restore
#line 77 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\GetProductStockListMessage.cshtml"
                                             Write(Model._ErrorMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral(".\r\n    </div>\r\n");
#nullable restore
#line 79 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\GetProductStockListMessage.cshtml"
   }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<cdscntmkpapinetcore2webapp.Models.FBCManager.GetProductStockListMessage> Html { get; private set; }
    }
}
#pragma warning restore 1591
