#pragma checksum "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetAllAllowedCategoryTreeMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb12ed107398043f9dab2c4a1bc33cda008976b2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProductManager_GetAllAllowedCategoryTreeMessage), @"mvc.1.0.view", @"/Views/ProductManager/GetAllAllowedCategoryTreeMessage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb12ed107398043f9dab2c4a1bc33cda008976b2", @"/Views/ProductManager/GetAllAllowedCategoryTreeMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd17dbff09abcace87501202759f4739f3a1335f", @"/Views/_ViewImports.cshtml")]
    public class Views_ProductManager_GetAllAllowedCategoryTreeMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<cdscntmkpapinetcore2webapp.Models.ProductManager.GetAllAllowedCategoryTreeMessage>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetAllAllowedCategoryTreeMessage.cshtml"
  
    ViewData["Title"] = "GetAllAllowedCategoryTree";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<link rel=\"stylesheet\" href=\"src/jquery.treefilter.css\">\r\n<br/>\r\n<br />\r\n<div>\r\n    <div class=\"container\">\r\n        <h2>GetAllAllowedCategoryTree</h2>\r\n");
#nullable restore
#line 13 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetAllAllowedCategoryTreeMessage.cshtml"
         if (Model._OperationSuccess)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""alert alert-success"">
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
#line 30 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetAllAllowedCategoryTreeMessage.cshtml"
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
#line 40 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetAllAllowedCategoryTreeMessage.cshtml"
                                                            Write(Html.DisplayFor(model => model._MessageXML));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</pre></div>
                    </div>
                </div>
                <div class=""panel panel-default"">
                    <div class=""panel panel-default"">
                        <div class=""panel-heading"">
                            <h4 class=""panel-title"">
                                <a data-toggle=""collapse"" href=""#CategoryTree"">Click  to display the Cdicount Category Tree</a>
                            </h4>
                        </div>
                        <div id=""CategoryTree"" class=""panel-collapse collapse"">
                            <ul class=""list-group"">

");
#nullable restore
#line 53 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetAllAllowedCategoryTreeMessage.cshtml"
                                 foreach (var pi1 in Model._AllCategoryTreeMessage.Result.CategoryTree.ChildrenCategoryList)
                                {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    <li class=""list-group-item"">

                                        <div class=""panel panel-default"">
                                            <div class=""panel-heading"">
                                                <table class=""table"">
                                                    <thead>
                                                        <tr>
                                                            <th>Name</th>
                                                            <th>Code</th>
                                                            <th>AllowOfferIntegration</th>
                                                            <th>AllowProductIntegration</th>
                                                        </tr>
                                                    </thead>
                                                    <tbody>
                                                        <tr>
                              ");
            WriteLiteral("                              <td><a data-toggle=\"collapse\"");
            BeginWriteAttribute("href", " href=\"", 3538, "\"", 3555, 2);
            WriteAttributeValue("", 3545, "#", 3545, 1, true);
#nullable restore
#line 71 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetAllAllowedCategoryTreeMessage.cshtml"
WriteAttributeValue("", 3546, pi1.Code, 3546, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 3556, "\"", 3591, 3);
            WriteAttributeValue("", 3566, "location.href=#", 3566, 15, true);
#nullable restore
#line 71 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetAllAllowedCategoryTreeMessage.cshtml"
WriteAttributeValue("", 3581, pi1.Code, 3581, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3590, ";", 3590, 1, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 71 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetAllAllowedCategoryTreeMessage.cshtml"
                                                                                                                                           Write(pi1.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                                                            <td>");
#nullable restore
#line 72 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetAllAllowedCategoryTreeMessage.cshtml"
                                                           Write(pi1.Code);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                            <td>");
#nullable restore
#line 73 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetAllAllowedCategoryTreeMessage.cshtml"
                                                           Write(pi1.AllowOfferIntegration);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                            <td>");
#nullable restore
#line 74 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetAllAllowedCategoryTreeMessage.cshtml"
                                                           Write(pi1.AllowProductIntegration);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                                        </tr>
                                                    </tbody>
                                                </table>
                                            </div>
                                            <div");
            BeginWriteAttribute("id", " id=\"", 4172, "\"", 4186, 1);
#nullable restore
#line 79 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetAllAllowedCategoryTreeMessage.cshtml"
WriteAttributeValue("", 4177, pi1.Code, 4177, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"panel-collapse collapse\">\r\n\r\n                                                <ul class=\"list-group\">\r\n\r\n");
#nullable restore
#line 83 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetAllAllowedCategoryTreeMessage.cshtml"
                                                     foreach (var pi2 in pi1.ChildrenCategoryList)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                        <li class=""list-group-item"">
                                                            <div class=""panel panel-default"">
                                                                <div class=""panel-heading"">
                                                                    <table class=""table"">
                                                                        <tbody>
                                                                            <tr>
                                                                                <td><a data-toggle=""collapse""");
            BeginWriteAttribute("href", " href=\"", 5091, "\"", 5108, 2);
            WriteAttributeValue("", 5098, "#", 5098, 1, true);
#nullable restore
#line 91 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetAllAllowedCategoryTreeMessage.cshtml"
WriteAttributeValue("", 5099, pi2.Code, 5099, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 5109, "\"", 5144, 3);
            WriteAttributeValue("", 5119, "location.href=#", 5119, 15, true);
#nullable restore
#line 91 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetAllAllowedCategoryTreeMessage.cshtml"
WriteAttributeValue("", 5134, pi2.Code, 5134, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5143, ";", 5143, 1, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 91 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetAllAllowedCategoryTreeMessage.cshtml"
                                                                                                                                                               Write(pi2.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                                                                                <td>");
#nullable restore
#line 92 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetAllAllowedCategoryTreeMessage.cshtml"
                                                                               Write(pi2.Code);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                                                <td>");
#nullable restore
#line 93 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetAllAllowedCategoryTreeMessage.cshtml"
                                                                               Write(pi2.AllowOfferIntegration);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                                                <td>");
#nullable restore
#line 94 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetAllAllowedCategoryTreeMessage.cshtml"
                                                                               Write(pi2.AllowProductIntegration);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                                                            </tr>
                                                                        </tbody>
                                                                    </table>
                                                                </div>
                                                                <div");
            BeginWriteAttribute("id", " id=\"", 5885, "\"", 5899, 1);
#nullable restore
#line 99 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetAllAllowedCategoryTreeMessage.cshtml"
WriteAttributeValue("", 5890, pi2.Code, 5890, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"panel-collapse collapse\">\r\n                                                                    <ul class=\"list-group\">\r\n\r\n");
#nullable restore
#line 102 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetAllAllowedCategoryTreeMessage.cshtml"
                                                                         foreach (var pi3 in pi2.ChildrenCategoryList)
                                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                                            <li class=""list-group-item"">
                                                                                <div class=""panel panel-default"">
                                                                                    <div class=""panel-heading"">
                                                                                        <table class=""table"">
                                                                                            <tbody>
                                                                                                <tr>
                                                                                                    <td><a data-toggle=""collapse""");
            BeginWriteAttribute("href", " href=\"", 7002, "\"", 7019, 2);
            WriteAttributeValue("", 7009, "#", 7009, 1, true);
#nullable restore
#line 110 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetAllAllowedCategoryTreeMessage.cshtml"
WriteAttributeValue("", 7010, pi3.Code, 7010, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 7020, "\"", 7055, 3);
            WriteAttributeValue("", 7030, "location.href=#", 7030, 15, true);
#nullable restore
#line 110 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetAllAllowedCategoryTreeMessage.cshtml"
WriteAttributeValue("", 7045, pi3.Code, 7045, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7054, ";", 7054, 1, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 110 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetAllAllowedCategoryTreeMessage.cshtml"
                                                                                                                                                                                   Write(pi3.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                                                                                                    <td>");
#nullable restore
#line 111 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetAllAllowedCategoryTreeMessage.cshtml"
                                                                                                   Write(pi3.Code);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                                                                    <td>");
#nullable restore
#line 112 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetAllAllowedCategoryTreeMessage.cshtml"
                                                                                                   Write(pi3.AllowOfferIntegration);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                                                                    <td>");
#nullable restore
#line 113 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetAllAllowedCategoryTreeMessage.cshtml"
                                                                                                   Write(pi3.AllowProductIntegration);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                                                                                </tr>
                                                                                            </tbody>
                                                                                        </table>
                                                                                    </div>
                                                                                    <div");
            BeginWriteAttribute("id", " id=\"", 7956, "\"", 7970, 1);
#nullable restore
#line 118 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetAllAllowedCategoryTreeMessage.cshtml"
WriteAttributeValue("", 7961, pi3.Code, 7961, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"panel-collapse collapse\">\r\n\r\n");
#nullable restore
#line 120 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetAllAllowedCategoryTreeMessage.cshtml"
                                                                                         foreach (var pi4 in pi3.ChildrenCategoryList)
                                                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                                                            <table class=""table"">
                                                                                                <tbody>
                                                                                                    <tr>
                                                                                                        <td>");
#nullable restore
#line 125 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetAllAllowedCategoryTreeMessage.cshtml"
                                                                                                       Write(pi4.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                                                                        <td>");
#nullable restore
#line 126 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetAllAllowedCategoryTreeMessage.cshtml"
                                                                                                       Write(pi4.Code);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                                                                        <td>");
#nullable restore
#line 127 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetAllAllowedCategoryTreeMessage.cshtml"
                                                                                                       Write(pi4.AllowOfferIntegration);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                                                                        <td>");
#nullable restore
#line 128 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetAllAllowedCategoryTreeMessage.cshtml"
                                                                                                       Write(pi4.AllowProductIntegration);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                                                                                    </tr>
                                                                                                </tbody>
                                                                                            </table>
");
#nullable restore
#line 132 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetAllAllowedCategoryTreeMessage.cshtml"
                                                                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                                                    </div>
                                                                                </div>
                                                                            </li>
");
#nullable restore
#line 137 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetAllAllowedCategoryTreeMessage.cshtml"
                                                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                                    </ul>
                                                                </div>
                                                            </div>



                                                        </li>
");
#nullable restore
#line 146 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetAllAllowedCategoryTreeMessage.cshtml"


                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </ul>\r\n                                            </div>\r\n                                        </div>\r\n                                    </li>\r\n");
#nullable restore
#line 154 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetAllAllowedCategoryTreeMessage.cshtml"


                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </ul>\r\n                            <div class=\"panel-footer\"></div>\r\n                        </div>\r\n                    </div>\r\n\r\n\r\n                </div>\r\n\r\n            </div>\r\n");
#nullable restore
#line 167 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetAllAllowedCategoryTreeMessage.cshtml"
        }
        else if (Model._ErrorMessage != "")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"alert alert-danger\">\r\n                <strong>Failed!</strong> : error message : ");
#nullable restore
#line 171 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetAllAllowedCategoryTreeMessage.cshtml"
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
#line 182 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetAllAllowedCategoryTreeMessage.cshtml"
                                                            Write(Html.DisplayFor(model => model._RequestXML));

#line default
#line hidden
#nullable disable
            WriteLiteral("</pre></div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"panel panel-default\">\r\n                    ");
#nullable restore
#line 186 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetAllAllowedCategoryTreeMessage.cshtml"
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
#line 193 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetAllAllowedCategoryTreeMessage.cshtml"
                                                            Write(Html.DisplayFor(model => model._MessageXML));

#line default
#line hidden
#nullable disable
            WriteLiteral("</pre></div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 197 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetAllAllowedCategoryTreeMessage.cshtml"

        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"alert alert-warning\">\r\n                <strong>Warning!</strong> error message : ");
#nullable restore
#line 202 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetAllAllowedCategoryTreeMessage.cshtml"
                                                     Write(Model._ErrorMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral(".\r\n            </div>\r\n");
#nullable restore
#line 204 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\GetAllAllowedCategoryTreeMessage.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <script>\r\n\r\n    var editor = CodeMirror(document.getElementById(\"MessageXML2\"), {\r\n        mode: \"xml\",\r\n        height : \"auto\"\r\n    });\r\n        </script>\r\n    </div>\r\n         ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<cdscntmkpapinetcore2webapp.Models.ProductManager.GetAllAllowedCategoryTreeMessage> Html { get; private set; }
    }
}
#pragma warning restore 1591