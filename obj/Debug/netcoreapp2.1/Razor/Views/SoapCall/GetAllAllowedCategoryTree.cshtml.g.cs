#pragma checksum "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\SoapCall\GetAllAllowedCategoryTree.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79bc55f6499ea3c6cdb789a40266684c4f6ae87c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SoapCall_GetAllAllowedCategoryTree), @"mvc.1.0.view", @"/Views/SoapCall/GetAllAllowedCategoryTree.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SoapCall/GetAllAllowedCategoryTree.cshtml", typeof(AspNetCore.Views_SoapCall_GetAllAllowedCategoryTree))]
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
#line 1 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\SoapCall\GetAllAllowedCategoryTree.cshtml"
using cdscntmkpapinetcore2webapp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79bc55f6499ea3c6cdb789a40266684c4f6ae87c", @"/Views/SoapCall/GetAllAllowedCategoryTree.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd17dbff09abcace87501202759f4739f3a1335f", @"/Views/_ViewImports.cshtml")]
    public class Views_SoapCall_GetAllAllowedCategoryTree : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<cdscntmkpapinetcore2webapp.Models.SoapCall>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 4, true);
            WriteLiteral("<!--");
            EndContext();
#line 3 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\SoapCall\GetAllAllowedCategoryTree.cshtml"
  
    ViewData["Title"] = "SoapCall";

#line default
#line hidden
            BeginContext(141, 61, true);
            WriteLiteral("\r\n<h2>SoapCall</h2>\r\n\r\n<p>Hello from our View Template!</p>\r\n");
            EndContext();
#line 10 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\SoapCall\GetAllAllowedCategoryTree.cshtml"
 if(Model._ErrorMessage != null && Model._ErrorMessage !="")
{
    

#line default
#line hidden
            BeginContext(272, 19, false);
#line 12 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\SoapCall\GetAllAllowedCategoryTree.cshtml"
Write(Model._ErrorMessage);

#line default
#line hidden
            EndContext();
#line 12 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\SoapCall\GetAllAllowedCategoryTree.cshtml"
                        
}        
else{
    

#line default
#line hidden
            BeginContext(316, 45, false);
#line 15 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\SoapCall\GetAllAllowedCategoryTree.cshtml"
Write(Model._CategoryTreeMessage.Result.SellerLogin);

#line default
#line hidden
            EndContext();
            BeginContext(368, 45, false);
#line 16 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\SoapCall\GetAllAllowedCategoryTree.cshtml"
Write(Model._CategoryTreeMessage.Result.SellerLogin);

#line default
#line hidden
            EndContext();
            BeginContext(420, 75, false);
#line 17 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\SoapCall\GetAllAllowedCategoryTree.cshtml"
Write(Model._CategoryTreeMessage.Result.CategoryTree.ChildrenCategoryList[0].Name);

#line default
#line hidden
            EndContext();
            BeginContext(502, 75, false);
#line 18 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\SoapCall\GetAllAllowedCategoryTree.cshtml"
Write(Model._CategoryTreeMessage.Result.CategoryTree.ChildrenCategoryList[1].Name);

#line default
#line hidden
            EndContext();
            BeginContext(584, 75, false);
#line 19 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\SoapCall\GetAllAllowedCategoryTree.cshtml"
Write(Model._CategoryTreeMessage.Result.CategoryTree.ChildrenCategoryList[2].Name);

#line default
#line hidden
            EndContext();
            BeginContext(666, 75, false);
#line 20 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\SoapCall\GetAllAllowedCategoryTree.cshtml"
Write(Model._CategoryTreeMessage.Result.CategoryTree.ChildrenCategoryList[3].Name);

#line default
#line hidden
            EndContext();
#line 20 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\SoapCall\GetAllAllowedCategoryTree.cshtml"
                                                                                
    
}

#line default
#line hidden
            BeginContext(750, 3, true);
            WriteLiteral("-->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<cdscntmkpapinetcore2webapp.Models.SoapCall> Html { get; private set; }
    }
}
#pragma warning restore 1591
