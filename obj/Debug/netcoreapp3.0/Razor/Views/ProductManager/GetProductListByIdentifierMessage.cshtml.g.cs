#pragma checksum "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetProductListByIdentifierMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "adf078c56b5f37e089bed0b7c7a173e8f3facaed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProductManager_GetProductListByIdentifierMessage), @"mvc.1.0.view", @"/Views/ProductManager/GetProductListByIdentifierMessage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"adf078c56b5f37e089bed0b7c7a173e8f3facaed", @"/Views/ProductManager/GetProductListByIdentifierMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd17dbff09abcace87501202759f4739f3a1335f", @"/Views/_ViewImports.cshtml")]
    public class Views_ProductManager_GetProductListByIdentifierMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<cdscntmkpapinetcore2webapp.Models.ProductManager.GetProductListByIdentifierMessage>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetProductListByIdentifierMessage.cshtml"
  
    ViewData["Title"] = "GetProductListByIdentifier";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<br/>\r\n<br />\r\n<div>\r\n    <div class=\"container\">\r\n        <h2>GetProductListByIdentifier</h2>\r\n");
#nullable restore
#line 14 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetProductListByIdentifierMessage.cshtml"
        if (Model._OperationSuccess)
       {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-success\">\r\n            <strong>Success!</strong>\r\n        </div>\r\n        <hr />\r\n        <div id=\"MessageXML2\" class=\"panel panel-default\">\r\n        </div>\r\n");
            WriteLiteral(@"        <div class=""panel-group"">
            <p>Click on the collapsible panel to request.</p>
            <div class=""panel panel-default"">
                <div class=""panel-heading"">
                    <h4 class=""panel-title"">
                        <a data-toggle=""collapse"" href=""#RequestXML"">RequestXML</a>
                    </h4>
                </div>
                <div id=""RequestXML"" class=""panel-collapse collapse"">
                    <div class=""panel-body""><pre lang=""xml""> ");
#nullable restore
#line 33 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetProductListByIdentifierMessage.cshtml"
                                                        Write(Html.DisplayFor(model => model._RequestXML));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</pre></div>
                </div>
            </div>
            <p>Click on the collapsible panel to response.</p>
            <div class=""panel panel-default"">
                <div class=""panel-heading"">
                    <h4 class=""panel-title"">
                        <a data-toggle=""collapse"" href=""#MessageXML"">MessageXML</a>
                    </h4>
                </div>
                <div id=""MessageXML"" class=""panel-collapse collapse"">
                    <div class=""panel-body""><pre lang=""xml""> ");
#nullable restore
#line 44 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetProductListByIdentifierMessage.cshtml"
                                                        Write(Html.DisplayFor(model => model._MessageXML));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</pre></div>
                </div>
            </div>
            <p>Click on the collapsible panel to response.</p>
            <div class=""panel panel-default"">
                <div class=""panel-heading"">
                    <h4 class=""panel-title"">
                        <a data-toggle=""collapse"" href=""#Results"">Results</a>
                    </h4>
                </div>
                <div id=""Results"" class=""panel-collapse collapse"">
                    <div class=""table-responsive"">
                        <table class=""table"">
                            <thead>
                                <tr>
                                    <th>Picture</th>
                                    <th>Ean</th>
                                    <th>Brand</th>
                                    <th>Category</th>
                                    <th>Sku</th>
                                    <th>Name</th>
                                    <th>Color</th>
                            ");
            WriteLiteral("        <th>Size</th>\r\n                                    <th>ErrorMessage</th>\r\n                                </tr>\r\n                            </thead>\r\n                            <tbody>\r\n");
#nullable restore
#line 71 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetProductListByIdentifierMessage.cshtml"
                                 foreach (var pi in Model._ProductListByIdentifierMessage.ProductListByIdentifier)
                                {
                                    if(@pi.HasError==true)
                                    { 

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr class=\"bg-danger\">\r\n                                        <td>\r\n                                            <div class=\"thumbnail\">\r\n                                                <a");
            BeginWriteAttribute("href", " href=", 3315, "", 3333, 1);
#nullable restore
#line 78 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetProductListByIdentifierMessage.cshtml"
WriteAttributeValue("", 3321, pi.ImageUrl, 3321, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">\r\n                                                    <img");
            BeginWriteAttribute("src", " src=", 3408, "", 3425, 1);
#nullable restore
#line 79 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetProductListByIdentifierMessage.cshtml"
WriteAttributeValue("", 3413, pi.ImageUrl, 3413, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""Lights"" style=""width:100%"">
                                                    <div class=""caption"">
                                                        <p>Picture</p>
                                                    </div>
                                                </a>
                                            </div>
                                        </td>
                                        <td>");
#nullable restore
#line 86 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetProductListByIdentifierMessage.cshtml"
                                       Write(pi.Ean);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 87 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetProductListByIdentifierMessage.cshtml"
                                       Write(pi.BrandName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 88 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetProductListByIdentifierMessage.cshtml"
                                       Write(pi.CategoryCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 89 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetProductListByIdentifierMessage.cshtml"
                                       Write(pi.FatherProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 90 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetProductListByIdentifierMessage.cshtml"
                                       Write(pi.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 91 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetProductListByIdentifierMessage.cshtml"
                                       Write(pi.Color);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 92 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetProductListByIdentifierMessage.cshtml"
                                       Write(pi.Size);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>                                        \r\n                                        <td>");
#nullable restore
#line 93 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetProductListByIdentifierMessage.cshtml"
                                       Write(pi.ErrorMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    </tr>");
#nullable restore
#line 94 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetProductListByIdentifierMessage.cshtml"
                                         }
                                    else {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr class=\"bg-success\">\r\n                                            <td>\r\n                                                <div class=\"thumbnail\">\r\n                                                    <a");
            BeginWriteAttribute("href", " href=", 4694, "", 4712, 1);
#nullable restore
#line 99 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetProductListByIdentifierMessage.cshtml"
WriteAttributeValue("", 4700, pi.ImageUrl, 4700, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">\r\n                                                        <img");
            BeginWriteAttribute("src", " src=", 4791, "", 4808, 1);
#nullable restore
#line 100 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetProductListByIdentifierMessage.cshtml"
WriteAttributeValue("", 4796, pi.ImageUrl, 4796, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""Lights"" style=""width:100%"">
                                                        <div class=""caption"">
                                                            <p>Click to display</p>
                                                        </div>
                                                    </a>
                                                </div>
                                            </td>
                                            <td>");
#nullable restore
#line 107 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetProductListByIdentifierMessage.cshtml"
                                           Write(pi.Ean);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 108 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetProductListByIdentifierMessage.cshtml"
                                           Write(pi.BrandName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 109 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetProductListByIdentifierMessage.cshtml"
                                           Write(pi.CategoryCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 110 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetProductListByIdentifierMessage.cshtml"
                                           Write(pi.FatherProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 111 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetProductListByIdentifierMessage.cshtml"
                                           Write(pi.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 112 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetProductListByIdentifierMessage.cshtml"
                                           Write(pi.Color);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 113 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetProductListByIdentifierMessage.cshtml"
                                           Write(pi.Size);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 114 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetProductListByIdentifierMessage.cshtml"
                                           Write(pi.ErrorMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        </tr>");
#nullable restore
#line 115 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetProductListByIdentifierMessage.cshtml"
                                             }
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 123 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetProductListByIdentifierMessage.cshtml"
        }
        else if (Model._ErrorMessage != "")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"alert alert-warning\">\r\n                <strong>Warning!</strong> error message : ");
#nullable restore
#line 127 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetProductListByIdentifierMessage.cshtml"
                                                     Write(Model._ErrorMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral(@".
            </div>
            <div class=""panel-group"">
                <p>Click on the collapsible panel to request.</p>
                <div class=""panel panel-default"">
                    <div class=""panel-heading"">
                        <h4 class=""panel-title"">
                            <a data-toggle=""collapse"" href=""#RequestXML"">RequestXML</a>
                        </h4>
                    </div>
                    <div id=""RequestXML"" class=""panel-collapse collapse"">
                        <div class=""panel-body""><pre lang=""xml""> ");
#nullable restore
#line 138 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetProductListByIdentifierMessage.cshtml"
                                                            Write(Html.DisplayFor(model => model._RequestXML));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</pre></div>
                    </div>
                </div>
                <p>Click on the collapsible panel to response.</p>
                <div class=""panel panel-default"">
                    <div class=""panel-heading"">
                        <h4 class=""panel-title"">
                            <a data-toggle=""collapse"" href=""#MessageXML"">MessageXML</a>
                        </h4>
                    </div>
                    <div id=""MessageXML"" class=""panel-collapse collapse"">
                        <div class=""panel-body""><pre lang=""xml""> ");
#nullable restore
#line 149 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetProductListByIdentifierMessage.cshtml"
                                                            Write(Html.DisplayFor(model => model._MessageXML));

#line default
#line hidden
#nullable disable
            WriteLiteral("</pre></div>\r\n                    </div>\r\n                </div>\r\n                </div>\r\n");
#nullable restore
#line 153 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetProductListByIdentifierMessage.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"alert alert-success\">\r\n                    <strong>Success!</strong>\r\n                </div>\r\n");
#nullable restore
#line 159 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetProductListByIdentifierMessage.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n\r\n                <h4>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "adf078c56b5f37e089bed0b7c7a173e8f3facaed21135", async() => {
                WriteLiteral("Export your Product list");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 7760, "~/ProductManager/Download/?SellerLogin=", 7760, 39, true);
#nullable restore
#line 162 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetProductListByIdentifierMessage.cshtml"
AddHtmlAttributeValue("", 7799, Model._ProductListByIdentifierMessage.TokenId, 7799, 46, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h4>\r\n           \r\n</div>\r\n\r\n<script>\r\n\r\n    var editor = CodeMirror(document.getElementById(\"MessageXML2\"), {\r\n        mode: \"xml\",\r\n        height : \"auto\"\r\n    });\r\n</script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<cdscntmkpapinetcore2webapp.Models.ProductManager.GetProductListByIdentifierMessage> Html { get; private set; }
    }
}
#pragma warning restore 1591
