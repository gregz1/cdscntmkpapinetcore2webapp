#pragma checksum "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\GetFulfilmentSupplyOrderMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "956fb67093d6d553bd73b97d5b6572b3267fbcd2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FBCManager_GetFulfilmentSupplyOrderMessage), @"mvc.1.0.view", @"/Views/FBCManager/GetFulfilmentSupplyOrderMessage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/FBCManager/GetFulfilmentSupplyOrderMessage.cshtml", typeof(AspNetCore.Views_FBCManager_GetFulfilmentSupplyOrderMessage))]
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
#line 1 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\GetFulfilmentSupplyOrderMessage.cshtml"
using cdscntmkpapinetcore2webapp.Models;

#line default
#line hidden
#line 2 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\GetFulfilmentSupplyOrderMessage.cshtml"
using www.cdiscount.com;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"956fb67093d6d553bd73b97d5b6572b3267fbcd2", @"/Views/FBCManager/GetFulfilmentSupplyOrderMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd17dbff09abcace87501202759f4739f3a1335f", @"/Views/_ViewImports.cshtml")]
    public class Views_FBCManager_GetFulfilmentSupplyOrderMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<cdscntmkpapinetcore2webapp.Models.FBCManager.GetFulfilmentSupplyOrderMessage>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(153, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 6 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\GetFulfilmentSupplyOrderMessage.cshtml"
  
    ViewData["Title"] = "GetFulfilmentSupplyOrder";

#line default
#line hidden
            BeginContext(217, 81, true);
            WriteLiteral("\r\n\r\n    <br />\r\n    <br />\r\n    <br />\r\n\r\n    <h4>GetFulfilmentSupplyOrder</h4>\r\n");
            EndContext();
#line 16 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\GetFulfilmentSupplyOrderMessage.cshtml"
     if (Model._OperationSuccess)
    {


#line default
#line hidden
            BeginContext(342, 512, true);
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
            BeginContext(855, 43, false);
#line 30 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\GetFulfilmentSupplyOrderMessage.cshtml"
                                                    Write(Html.DisplayFor(model => model._RequestXML));

#line default
#line hidden
            EndContext();
            BeginContext(898, 447, true);
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
            BeginContext(1346, 43, false);
#line 40 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\GetFulfilmentSupplyOrderMessage.cshtml"
                                                    Write(Html.DisplayFor(model => model._MessageXML));

#line default
#line hidden
            EndContext();
            BeginContext(1389, 84, true);
            WriteLiteral("</pre></div>\r\n            </div>        \r\n        </div>        \r\n    \r\n    </div>\r\n");
            EndContext();
#line 45 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\GetFulfilmentSupplyOrderMessage.cshtml"
    }
    else if (Model._ErrorMessage != "")
    {

#line default
#line hidden
            BeginContext(1528, 97, true);
            WriteLiteral("        <div class=\"alert alert-danger\">\r\n            <strong>Failed!</strong> : error message : ");
            EndContext();
            BeginContext(1626, 19, false);
#line 49 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\GetFulfilmentSupplyOrderMessage.cshtml"
                                                  Write(Model._ErrorMessage);

#line default
#line hidden
            EndContext();
            BeginContext(1645, 482, true);
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
            BeginContext(2128, 43, false);
#line 60 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\GetFulfilmentSupplyOrderMessage.cshtml"
                                                        Write(Html.DisplayFor(model => model._RequestXML));

#line default
#line hidden
            EndContext();
            BeginContext(2171, 103, true);
            WriteLiteral("</pre></div>\r\n                </div>\r\n            </div>\r\n            <div class=\"panel panel-default\">");
            EndContext();
            BeginContext(2275, 43, false);
#line 63 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\GetFulfilmentSupplyOrderMessage.cshtml"
                                        Write(Html.DisplayFor(model => model._RequestXML));

#line default
#line hidden
            EndContext();
            BeginContext(2318, 384, true);
            WriteLiteral(@"
                <div class=""panel-heading"">
                    <h4 class=""panel-title"">
                        <a data-toggle=""collapse"" href=""#MessageXML"">Click  to display the XML Message</a>
                    </h4>
                </div>
                <div id=""MessageXML"" class=""panel-collapse collapse"">
                    <div class=""panel-body""><pre lang=""xml""> ");
            EndContext();
            BeginContext(2703, 43, false);
#line 70 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\GetFulfilmentSupplyOrderMessage.cshtml"
                                                        Write(Html.DisplayFor(model => model._MessageXML));

#line default
#line hidden
            EndContext();
            BeginContext(2746, 85, true);
            WriteLiteral("</pre></div>\r\n                </div>           \r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 74 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\GetFulfilmentSupplyOrderMessage.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(2855, 97, true);
            WriteLiteral("        <div class=\"alert alert-warning\">\r\n            <strong>Warning!</strong> error message : ");
            EndContext();
            BeginContext(2953, 19, false);
#line 78 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\GetFulfilmentSupplyOrderMessage.cshtml"
                                                 Write(Model._ErrorMessage);

#line default
#line hidden
            EndContext();
            BeginContext(2972, 483, true);
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
            BeginContext(3456, 43, false);
#line 89 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\GetFulfilmentSupplyOrderMessage.cshtml"
                                                        Write(Html.DisplayFor(model => model._RequestXML));

#line default
#line hidden
            EndContext();
            BeginContext(3499, 103, true);
            WriteLiteral("</pre></div>\r\n                </div>\r\n            </div>\r\n            <div class=\"panel panel-default\">");
            EndContext();
            BeginContext(3603, 43, false);
#line 92 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\GetFulfilmentSupplyOrderMessage.cshtml"
                                        Write(Html.DisplayFor(model => model._RequestXML));

#line default
#line hidden
            EndContext();
            BeginContext(3646, 384, true);
            WriteLiteral(@"
                <div class=""panel-heading"">
                    <h4 class=""panel-title"">
                        <a data-toggle=""collapse"" href=""#MessageXML"">Click  to display the XML Message</a>
                    </h4>
                </div>
                <div id=""MessageXML"" class=""panel-collapse collapse"">
                    <div class=""panel-body""><pre lang=""xml""> ");
            EndContext();
            BeginContext(4031, 43, false);
#line 99 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\GetFulfilmentSupplyOrderMessage.cshtml"
                                                        Write(Html.DisplayFor(model => model._MessageXML));

#line default
#line hidden
            EndContext();
            BeginContext(4074, 93, true);
            WriteLiteral("</pre></div>\r\n                </div>           \r\n            </div>\r\n        </div>        \r\n");
            EndContext();
#line 103 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\GetFulfilmentSupplyOrderMessage.cshtml"
    }

#line default
#line hidden
            BeginContext(4174, 145, true);
            WriteLiteral("<script>\r\n\r\n    var editor = CodeMirror(document.getElementById(\"RequestXML\"), {\r\n        mode: \"xml\",\r\n        height: \"auto\",\r\n        value: \"");
            EndContext();
            BeginContext(4320, 28, false);
#line 109 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\GetFulfilmentSupplyOrderMessage.cshtml"
           Write(Model._RequestXML.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(4348, 200, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<cdscntmkpapinetcore2webapp.Models.FBCManager.GetFulfilmentSupplyOrderMessage> Html { get; private set; }
    }
}
#pragma warning restore 1591
