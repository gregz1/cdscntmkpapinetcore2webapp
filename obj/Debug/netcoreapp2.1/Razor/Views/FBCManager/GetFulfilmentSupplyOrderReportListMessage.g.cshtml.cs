#pragma checksum "C:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\GetFulfilmentSupplyOrderReportListMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "991511f5b9b8236080af1c639b504cc6d134312e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FBCManager_GetFulfilmentSupplyOrderReportListMessage), @"mvc.1.0.view", @"/Views/FBCManager/GetFulfilmentSupplyOrderReportListMessage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/FBCManager/GetFulfilmentSupplyOrderReportListMessage.cshtml", typeof(AspNetCore.Views_FBCManager_GetFulfilmentSupplyOrderReportListMessage))]
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
#line 1 "C:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\GetFulfilmentSupplyOrderReportListMessage.cshtml"
using cdscntmkpapinetcore2webapp.Models;

#line default
#line hidden
#line 2 "C:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\GetFulfilmentSupplyOrderReportListMessage.cshtml"
using www.cdiscount.com;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"991511f5b9b8236080af1c639b504cc6d134312e", @"/Views/FBCManager/GetFulfilmentSupplyOrderReportListMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd17dbff09abcace87501202759f4739f3a1335f", @"/Views/_ViewImports.cshtml")]
    public class Views_FBCManager_GetFulfilmentSupplyOrderReportListMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<cdscntmkpapinetcore2webapp.Models.FBCManager.GetFulfilmentSupplyOrderReportListMessage>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(163, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 6 "C:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\GetFulfilmentSupplyOrderReportListMessage.cshtml"
  
    ViewData["Title"] = "GetFulfilmentSupplyOrderReportList";

#line default
#line hidden
            BeginContext(237, 91, true);
            WriteLiteral("\r\n\r\n    <br />\r\n    <br />\r\n    <br />\r\n\r\n    <h4>GetFulfilmentSupplyOrderReportList</h4>\r\n");
            EndContext();
#line 16 "C:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\GetFulfilmentSupplyOrderReportListMessage.cshtml"
     if (Model._OperationSuccess)
    {


#line default
#line hidden
            BeginContext(372, 512, true);
            WriteLiteral(@"        <div class=""alert alert-success"">
            <strong>Success!</strong>
        </div>
    <div><hr />
        <div class=""panel panel-default"">
            <div class=""panel-heading"">
                <h4 class=""panel-title"">
                    <a data-toggle=""collapse"" href=""#RequestXML"">Click  to display the XML Request</a>
                </h4>
            </div>
            <div id=""RequestXML"" class=""panel-collapse collapse"">
                <div class=""panel-body""><pre lang=""xml""> ");
            EndContext();
            BeginContext(885, 43, false);
#line 30 "C:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\GetFulfilmentSupplyOrderReportListMessage.cshtml"
                                                    Write(Html.DisplayFor(model => model._RequestXML));

#line default
#line hidden
            EndContext();
            BeginContext(928, 447, true);
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
            BeginContext(1376, 43, false);
#line 40 "C:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\GetFulfilmentSupplyOrderReportListMessage.cshtml"
                                                    Write(Html.DisplayFor(model => model._MessageXML));

#line default
#line hidden
            EndContext();
            BeginContext(1419, 84, true);
            WriteLiteral("</pre></div>\r\n            </div>        \r\n        </div>        \r\n    \r\n    </div>\r\n");
            EndContext();
#line 45 "C:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\GetFulfilmentSupplyOrderReportListMessage.cshtml"
    }
    else if (Model._ErrorMessage != "")
    {

#line default
#line hidden
            BeginContext(1558, 97, true);
            WriteLiteral("        <div class=\"alert alert-danger\">\r\n            <strong>Failed!</strong> : error message : ");
            EndContext();
            BeginContext(1656, 19, false);
#line 49 "C:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\GetFulfilmentSupplyOrderReportListMessage.cshtml"
                                                  Write(Model._ErrorMessage);

#line default
#line hidden
            EndContext();
            BeginContext(1675, 482, true);
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
            BeginContext(2158, 43, false);
#line 60 "C:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\GetFulfilmentSupplyOrderReportListMessage.cshtml"
                                                        Write(Html.DisplayFor(model => model._RequestXML));

#line default
#line hidden
            EndContext();
            BeginContext(2201, 103, true);
            WriteLiteral("</pre></div>\r\n                </div>\r\n            </div>\r\n            <div class=\"panel panel-default\">");
            EndContext();
            BeginContext(2305, 43, false);
#line 63 "C:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\GetFulfilmentSupplyOrderReportListMessage.cshtml"
                                        Write(Html.DisplayFor(model => model._RequestXML));

#line default
#line hidden
            EndContext();
            BeginContext(2348, 384, true);
            WriteLiteral(@"
                <div class=""panel-heading"">
                    <h4 class=""panel-title"">
                        <a data-toggle=""collapse"" href=""#MessageXML"">Click  to display the XML Message</a>
                    </h4>
                </div>
                <div id=""MessageXML"" class=""panel-collapse collapse"">
                    <div class=""panel-body""><pre lang=""xml""> ");
            EndContext();
            BeginContext(2733, 43, false);
#line 70 "C:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\GetFulfilmentSupplyOrderReportListMessage.cshtml"
                                                        Write(Html.DisplayFor(model => model._MessageXML));

#line default
#line hidden
            EndContext();
            BeginContext(2776, 85, true);
            WriteLiteral("</pre></div>\r\n                </div>           \r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 74 "C:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\GetFulfilmentSupplyOrderReportListMessage.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(2885, 97, true);
            WriteLiteral("        <div class=\"alert alert-warning\">\r\n            <strong>Warning!</strong> error message : ");
            EndContext();
            BeginContext(2983, 19, false);
#line 78 "C:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\GetFulfilmentSupplyOrderReportListMessage.cshtml"
                                                 Write(Model._ErrorMessage);

#line default
#line hidden
            EndContext();
            BeginContext(3002, 483, true);
            WriteLiteral(@".
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
            BeginContext(3486, 43, false);
#line 89 "C:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\GetFulfilmentSupplyOrderReportListMessage.cshtml"
                                                        Write(Html.DisplayFor(model => model._RequestXML));

#line default
#line hidden
            EndContext();
            BeginContext(3529, 103, true);
            WriteLiteral("</pre></div>\r\n                </div>\r\n            </div>\r\n            <div class=\"panel panel-default\">");
            EndContext();
            BeginContext(3633, 43, false);
#line 92 "C:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\GetFulfilmentSupplyOrderReportListMessage.cshtml"
                                        Write(Html.DisplayFor(model => model._RequestXML));

#line default
#line hidden
            EndContext();
            BeginContext(3676, 384, true);
            WriteLiteral(@"
                <div class=""panel-heading"">
                    <h4 class=""panel-title"">
                        <a data-toggle=""collapse"" href=""#MessageXML"">Click  to display the XML Message</a>
                    </h4>
                </div>
                <div id=""MessageXML"" class=""panel-collapse collapse"">
                    <div class=""panel-body""><pre lang=""xml""> ");
            EndContext();
            BeginContext(4061, 43, false);
#line 99 "C:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\GetFulfilmentSupplyOrderReportListMessage.cshtml"
                                                        Write(Html.DisplayFor(model => model._MessageXML));

#line default
#line hidden
            EndContext();
            BeginContext(4104, 93, true);
            WriteLiteral("</pre></div>\r\n                </div>           \r\n            </div>\r\n        </div>        \r\n");
            EndContext();
#line 103 "C:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\GetFulfilmentSupplyOrderReportListMessage.cshtml"
    }

#line default
#line hidden
            BeginContext(4204, 145, true);
            WriteLiteral("<script>\r\n\r\n    var editor = CodeMirror(document.getElementById(\"RequestXML\"), {\r\n        mode: \"xml\",\r\n        height: \"auto\",\r\n        value: \"");
            EndContext();
            BeginContext(4350, 28, false);
#line 109 "C:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\GetFulfilmentSupplyOrderReportListMessage.cshtml"
           Write(Model._RequestXML.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(4378, 200, true);
            WriteLiteral("\",\r\n        smartIndent: \"true\",\r\n        xml: \"true\",\r\n        htmlMode: \"true\"\r\n\r\n    }); \r\n\r\n    function showCode() {\r\n        var text = editor.getValue();\r\n        alert(text);\r\n    }\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<cdscntmkpapinetcore2webapp.Models.FBCManager.GetFulfilmentSupplyOrderReportListMessage> Html { get; private set; }
    }
}
#pragma warning restore 1591
