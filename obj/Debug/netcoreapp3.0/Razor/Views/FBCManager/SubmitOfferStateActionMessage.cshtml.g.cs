#pragma checksum "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\SubmitOfferStateActionMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "204ec2ec9df2178009a2ac43769cd15ba73478e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FBCManager_SubmitOfferStateActionMessage), @"mvc.1.0.view", @"/Views/FBCManager/SubmitOfferStateActionMessage.cshtml")]
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
#line 1 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\SubmitOfferStateActionMessage.cshtml"
using cdscntmkpapinetcore2webapp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\SubmitOfferStateActionMessage.cshtml"
using www.cdiscount.com;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\SubmitOfferStateActionMessage.cshtml"
using Cdiscount.Service.Marketplace.API.External.Contract.Data.Fulfilment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\SubmitOfferStateActionMessage.cshtml"
using Cdiscount.Service.Marketplace.API.External.Contract.Data.Order;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"204ec2ec9df2178009a2ac43769cd15ba73478e5", @"/Views/FBCManager/SubmitOfferStateActionMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd17dbff09abcace87501202759f4739f3a1335f", @"/Views/_ViewImports.cshtml")]
    public class Views_FBCManager_SubmitOfferStateActionMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<cdscntmkpapinetcore2webapp.Models.FBCManager.SubmitOfferStateActionMessage>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 8 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\SubmitOfferStateActionMessage.cshtml"
  
    ViewData["Title"] = "SubmitOfferStateAction";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    <br />\r\n    <br />\r\n    <br />\r\n\r\n    <h4>SubmitOfferStateAction</h4>\r\n");
#nullable restore
#line 18 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\SubmitOfferStateActionMessage.cshtml"
     if (Model._OperationSuccess)
    {


#line default
#line hidden
#nullable disable
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
#nullable restore
#line 32 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\SubmitOfferStateActionMessage.cshtml"
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
#line 42 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\SubmitOfferStateActionMessage.cshtml"
                                                    Write(Html.DisplayFor(model => model._MessageXML));

#line default
#line hidden
#nullable disable
            WriteLiteral("</pre></div>\r\n            </div>        \r\n        </div>        \r\n    \r\n    </div>\r\n");
#nullable restore
#line 47 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\SubmitOfferStateActionMessage.cshtml"
    }
    else if (Model._ErrorMessage != "")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-danger\">\r\n            <strong>Failed!</strong> : error message : ");
#nullable restore
#line 51 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\SubmitOfferStateActionMessage.cshtml"
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
#line 62 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\SubmitOfferStateActionMessage.cshtml"
                                                        Write(Html.DisplayFor(model => model._RequestXML));

#line default
#line hidden
#nullable disable
            WriteLiteral("</pre></div>\r\n                </div>\r\n            </div>\r\n            <div class=\"panel panel-default\">");
#nullable restore
#line 65 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\SubmitOfferStateActionMessage.cshtml"
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
#line 72 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\SubmitOfferStateActionMessage.cshtml"
                                                        Write(Html.DisplayFor(model => model._MessageXML));

#line default
#line hidden
#nullable disable
            WriteLiteral("</pre></div>\r\n                </div>           \r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 76 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\SubmitOfferStateActionMessage.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-warning\">\r\n            <strong>Warning!</strong> error message : ");
#nullable restore
#line 80 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\SubmitOfferStateActionMessage.cshtml"
                                                 Write(Model._ErrorMessage);

#line default
#line hidden
#nullable disable
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
#nullable restore
#line 91 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\SubmitOfferStateActionMessage.cshtml"
                                                        Write(Html.DisplayFor(model => model._RequestXML));

#line default
#line hidden
#nullable disable
            WriteLiteral("</pre></div>\r\n                </div>\r\n            </div>\r\n            <div class=\"panel panel-default\">");
#nullable restore
#line 94 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\SubmitOfferStateActionMessage.cshtml"
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
#line 101 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\SubmitOfferStateActionMessage.cshtml"
                                                        Write(Html.DisplayFor(model => model._MessageXML));

#line default
#line hidden
#nullable disable
            WriteLiteral("</pre></div>\r\n                </div>           \r\n            </div>\r\n        </div>        \r\n");
#nullable restore
#line 105 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\SubmitOfferStateActionMessage.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("<script>\r\n\r\n    var editor = CodeMirror(document.getElementById(\"RequestXML\"), {\r\n        mode: \"xml\",\r\n        height: \"auto\",\r\n        value: \"");
#nullable restore
#line 111 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\SubmitOfferStateActionMessage.cshtml"
           Write(Model._RequestXML.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\",\r\n        smartIndent: \"true\",\r\n        xml: \"true\",\r\n        htmlMode: \"true\"\r\n\r\n    }); \r\n\r\n    function showCode() {\r\n        var text = editor.getValue();\r\n        alert(text);\r\n    }\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<cdscntmkpapinetcore2webapp.Models.FBCManager.SubmitOfferStateActionMessage> Html { get; private set; }
    }
}
#pragma warning restore 1591
