#pragma checksum "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OfferManager\GetOfferPackageSubmissionResultMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "50db9df13728a9b7bca27b23c461ff778d3813d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OfferManager_GetOfferPackageSubmissionResultMessage), @"mvc.1.0.view", @"/Views/OfferManager/GetOfferPackageSubmissionResultMessage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50db9df13728a9b7bca27b23c461ff778d3813d0", @"/Views/OfferManager/GetOfferPackageSubmissionResultMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd17dbff09abcace87501202759f4739f3a1335f", @"/Views/_ViewImports.cshtml")]
    public class Views_OfferManager_GetOfferPackageSubmissionResultMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<cdscntmkpapinetcore2webapp.Models.OfferManager.GetOfferPackageSubmissionResultMessage>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OfferManager\GetOfferPackageSubmissionResultMessage.cshtml"
  
    ViewData["Title"] = "GetOfferPackageSubmissionResult";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br/>\r\n<br />    \r\n <script src=\"https://cdn.zingchart.com/zingchart.min.js\"></script>\r\n  <div class=\'column\'>\r\n <div id=\"chart21\" class=\"panel panel-info\"></div>\r\n</div>\r\n<div>\r\n    <h4>GetOfferPackageSubmissionResult</h4>    \r\n");
#nullable restore
#line 15 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OfferManager\GetOfferPackageSubmissionResultMessage.cshtml"
     if (Model._OperationSuccess)
    {


#line default
#line hidden
#nullable disable
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
#nullable restore
#line 32 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OfferManager\GetOfferPackageSubmissionResultMessage.cshtml"
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
#line 42 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OfferManager\GetOfferPackageSubmissionResultMessage.cshtml"
                                                        Write(Html.DisplayFor(model => model._MessageXML));

#line default
#line hidden
#nullable disable
            WriteLiteral("</pre></div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 46 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OfferManager\GetOfferPackageSubmissionResultMessage.cshtml"
    }
    else if (Model._ErrorMessage != "")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-danger\">\r\n            <strong>Failed!</strong> : error message : ");
#nullable restore
#line 50 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OfferManager\GetOfferPackageSubmissionResultMessage.cshtml"
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
#line 61 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OfferManager\GetOfferPackageSubmissionResultMessage.cshtml"
                                                        Write(Html.DisplayFor(model => model._RequestXML));

#line default
#line hidden
#nullable disable
            WriteLiteral("</pre></div>\r\n                </div>\r\n            </div>\r\n            <div class=\"panel panel-default\">\r\n                ");
#nullable restore
#line 65 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OfferManager\GetOfferPackageSubmissionResultMessage.cshtml"
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
#line 72 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OfferManager\GetOfferPackageSubmissionResultMessage.cshtml"
                                                        Write(Html.DisplayFor(model => model._MessageXML));

#line default
#line hidden
#nullable disable
            WriteLiteral("</pre></div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 76 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OfferManager\GetOfferPackageSubmissionResultMessage.cshtml"

    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-warning\">\r\n            <strong>Warning!</strong> error message : ");
#nullable restore
#line 81 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OfferManager\GetOfferPackageSubmissionResultMessage.cshtml"
                                                 Write(Model._ErrorMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral(".\r\n        </div>\r\n");
#nullable restore
#line 83 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OfferManager\GetOfferPackageSubmissionResultMessage.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <script>
 zingchart.render({
            id: 'chart21',
            height: '100%',
            width: '100%',
            data: {
                type: ""pie"",
                ""labels"":[
                        { //Label One
                            ""text"":""50%"",
                            ""font-family"":""Calibri"",
                            ""font-size"":""50"",
                            ""text-align"":""center"",
                            ""x"":""80%"",
                            ""y"":""0%""
                        },
                        { //Label Two
                            ""text"":""des offres actives<br>du Top 100 vendeurs <br> sont en ligne <br> sur la dernière heure"",
                            ""font-family"":""Calibri"",
                            ""font-size"":""18"",
                            ""text-align"":""left"",
                            ""x"":""80%"",
                            ""y"":""10%""
                        }],
                backgroundColor: ""#5BC254"",
            ");
            WriteLiteral(@"    title: {
                    text: ""Top 100 vendeur"",
                    textAlign: ""left"",
                    marginLeft: ""10px"",
                    adjustLayout: true,
                    fontColor: ""white""
                },
                subtitle: {
                    text: ""Pourcentage <br>d'offres publiées <br> sur le top 100 vendeur"",
                    textAlign: ""left"",
                    marginLeft: ""10px"",
                    fontColor: ""white""
                },
                borderRadius: 4,
                valueBox: {
                    visible: true
                },
                plot: {
                    slice: 90,
                    refAngle: 270,
                    detach: false,
                    hoverState: {
                        visible: false
                    },
                    valueBox: {
                        visible: true,
                        type: ""first"",
                        connected: false,
                  ");
            WriteLiteral(@"      placement: ""center"",
                        text: ""%v%"",
                        fontColor: ""white"",
                        fontSize: ""20px""
                    },
                    tooltip: {
                        fontColor: ""#333"",
                        rules: [{
                            rule: ""%i == 0"",
                            text: ""%v Created"",
                            shadow: false,
                            borderRadius: 4
                        }, {
                            rule: ""%i == 1"",
                            text: ""%v Left"",
                            shadow: false,
                            borderRadius: 4
                        }]
                    }
                },
                plotarea: {
                    margin: ""dynamic"",
                },
                series: [{
                    values: ""50%"",
                    backgroundColor: ""#ffffff"",
                    borderWidth: ""0px"",
                    shadow:");
            WriteLiteral(@" 0
                }, {
                    values: ""50%"",
                    backgroundColor: ""#dadada"",
                    alpha: ""0.5"",
                    borderWidth: ""1px"",
                    shadow: 0,
                    valueBox: {
                        visible: false
                    }
                }]

            }
        });
    var editor = CodeMirror(document.getElementById(""MessageXML2""), {
        mode: ""xml"",
        height : ""auto""
    });
    </script>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<cdscntmkpapinetcore2webapp.Models.OfferManager.GetOfferPackageSubmissionResultMessage> Html { get; private set; }
    }
}
#pragma warning restore 1591