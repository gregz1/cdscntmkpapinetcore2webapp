#pragma checksum "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OfferManager\GetOfferListInFileMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e97556900d906e0596ba95c314d8e39cc64b6813"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OfferManager_GetOfferListInFileMessage), @"mvc.1.0.view", @"/Views/OfferManager/GetOfferListInFileMessage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e97556900d906e0596ba95c314d8e39cc64b6813", @"/Views/OfferManager/GetOfferListInFileMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd17dbff09abcace87501202759f4739f3a1335f", @"/Views/_ViewImports.cshtml")]
    public class Views_OfferManager_GetOfferListInFileMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<cdscntmkpapinetcore2webapp.Models.OfferManager.GetOfferListInFileMessage>
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
#line 3 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OfferManager\GetOfferListInFileMessage.cshtml"
  
    ViewData["Title"] = "GetOfferListInFile";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n<br />\r\n<br />\r\n<div>\r\n    <h4>GetOfferListInFileMessage</h4>\r\n");
#nullable restore
#line 12 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OfferManager\GetOfferListInFileMessage.cshtml"
 if (Model._OperationSuccess)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success\">\r\n        <strong>\r\n            Success! ");
#nullable restore
#line 17 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OfferManager\GetOfferListInFileMessage.cshtml"
                Write(Model._Filepath);

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n        </strong>\r\n        <strong>\r\n            ");
#nullable restore
#line 20 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OfferManager\GetOfferListInFileMessage.cshtml"
       Write(Model._MyOfferList.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <h4>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e97556900d906e0596ba95c314d8e39cc64b68134697", async() => {
                WriteLiteral("Export your Offer list");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 446, "~/OfferManager/Download/?OfferExtractFile=", 446, 42, true);
#nullable restore
#line 21 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OfferManager\GetOfferListInFileMessage.cshtml"
AddHtmlAttributeValue("", 488, Model._Filepath, 488, 16, false);

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
            WriteLiteral(@"</h4>
        </strong>    
    
    </div>
   <div class=""table-responsive"">
                        <table class=""table"">
                            <thead>
                                <tr>
                                    <th>Your Reference</th>
                                    <th>Ean</th>
                                    <th>ProductCondition</th>
                                    <th>Stock</th>
                                    <th>Price</th>
                                    <th>VAT</th>
                                    <th>EcoPart</th>
                                    <th>DEA</th>
                                    <th>PackagingUnit</th>
                                    <th>ProductPackaging</th>
                                    <th>ReferencePrice</th>
                                    <th>Comment</th>
                                    <th>PromotionType</th>
                                    <th>PromotionStartDate</th>
                        ");
            WriteLiteral(@"            <th>PromotionEndDate</th>
                                    <th>Discount</th>
                                    <th>ReferencePrice</th>
                                    <th>AutomaticallySetToBestOffer</th>
                                    <th>MinimumPrice</th>
                                    <th>PreparationTime</th>
                                    <th>MainDeliveryFees Tracked</th>
                                    <th>AdditionalDeliveryFees Tracked</th>
                                    <th>MainDeliveryFees Registered</th>
                                    <th>AdditionalDeliveryFees Registered</th>
                                    <th>PriceBenchmark Sku</th>
                                    <th>PriceBenchmark OfferStatus</th>
                                    <th>PriceBenchmark BestOfferPrice</th>
                                    <th>PriceBenchmark BestOfferShippingFee</th>
                                    <th>PriceBenchmark BestOfferCondition</t");
            WriteLiteral(@"h>
                                    <th>OfferTypology</th>
                                </tr>
                            </thead>
                            <tbody>
                                
                            </tbody>
                        </table>
                    </div>     
");
#nullable restore
#line 66 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OfferManager\GetOfferListInFileMessage.cshtml"
   
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-warning\">\r\n        <strong>Warning!</strong> error message : ");
#nullable restore
#line 71 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OfferManager\GetOfferListInFileMessage.cshtml"
                                             Write(Model._ErrorMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral(".\r\n    </div>\r\n");
#nullable restore
#line 73 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OfferManager\GetOfferListInFileMessage.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<script>\r\n\r\n    var editor = CodeMirror(document.getElementById(\"MessageXML2\"), {\r\n        mode: \"xml\",\r\n        height : \"auto\"\r\n    });\r\n</script>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<cdscntmkpapinetcore2webapp.Models.OfferManager.GetOfferListInFileMessage> Html { get; private set; }
    }
}
#pragma warning restore 1591
