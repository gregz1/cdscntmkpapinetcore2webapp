#pragma checksum "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\SoapCall\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c720cb92722a7339cfeb1f99f55186e933d9d9b8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SoapCall_Index), @"mvc.1.0.view", @"/Views/SoapCall/Index.cshtml")]
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
#line 1 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\SoapCall\Index.cshtml"
using cdscntmkpapinetcore2webapp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c720cb92722a7339cfeb1f99f55186e933d9d9b8", @"/Views/SoapCall/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd17dbff09abcace87501202759f4739f3a1335f", @"/Views/_ViewImports.cshtml")]
    public class Views_SoapCall_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<cdscntmkpapinetcore2webapp.Models.SoapClient>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!--");
#nullable restore
#line 3 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\SoapCall\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>Hello from our View Template!</p>\r\n");
#nullable restore
#line 10 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\SoapCall\Index.cshtml"
 if(Model._ErrorMessage != null && Model._ErrorMessage !="")
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\SoapCall\Index.cshtml"
Write(Model._ErrorMessage);

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\SoapCall\Index.cshtml"
                        
}        
else{

#line default
#line hidden
#nullable disable
            WriteLiteral("     <ul>\r\n");
#nullable restore
#line 16 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\SoapCall\Index.cshtml"
     foreach(SoapCall s in Model._methodList)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>");
#nullable restore
#line 18 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\SoapCall\Index.cshtml"
       Write(s._methodName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 19 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\SoapCall\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n");
#nullable restore
#line 21 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\SoapCall\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("-->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<cdscntmkpapinetcore2webapp.Models.SoapClient> Html { get; private set; }
    }
}
#pragma warning restore 1591
