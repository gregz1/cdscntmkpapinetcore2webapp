#pragma checksum "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OrderManager\GetOrderListMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "353ad71ada969722f22bad3fc2b0c4c0dece5a87"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OrderManager_GetOrderListMessage), @"mvc.1.0.view", @"/Views/OrderManager/GetOrderListMessage.cshtml")]
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
#line 1 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OrderManager\GetOrderListMessage.cshtml"
using cdscntmkpapinetcore2webapp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OrderManager\GetOrderListMessage.cshtml"
using www.cdiscount.com;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"353ad71ada969722f22bad3fc2b0c4c0dece5a87", @"/Views/OrderManager/GetOrderListMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd17dbff09abcace87501202759f4739f3a1335f", @"/Views/_ViewImports.cshtml")]
    public class Views_OrderManager_GetOrderListMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<cdscntmkpapinetcore2webapp.Models.OrderManager.GetOrderListMessage>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 6 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OrderManager\GetOrderListMessage.cshtml"
  
    ViewData["Title"] = "GetOrderListMessage";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    <br />\r\n    <br />\r\n    <br />\r\n    <br />\r\n    <br />\r\n    <br />\r\n\r\n    <h4>GetOrderList</h4>\r\n");
#nullable restore
#line 19 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OrderManager\GetOrderListMessage.cshtml"
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
#line 33 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OrderManager\GetOrderListMessage.cshtml"
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
                <div class=""panel-body""><textarea id=""textbox"" class=""form-control"" rows=""50"" >");
#nullable restore
#line 43 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OrderManager\GetOrderListMessage.cshtml"
                                                                                          Write(Html.DisplayFor(model => model._MessageXML));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</textarea> 
                  <button id=""create"">Create file</button> <a download=""OrderExtract.xml"" id=""downloadlink"" style=""display: none"">Download</a></div>
            </div>    
        </div>        
    
    </div>
        <br /><div class=""form-group"">
        <div class=""panel panel-default"">
            <div class=""panel panel-info"">
                <div class=""panel-heading"">
                    <h3 class=""panel-title"">Order List</h3>
                </div>
                <div class=""panel-body"">
                    <br />
                    <div class=""table-responsive"">
                        <table class=""table-striped"">
                            <thead>
                                <tr>
                                    <th>OrderNumber</th>
                                    <th>OrderState</th>
                                    <th>OrderLineList</th>
                                </tr>
                            </thead>
                            <tbod");
            WriteLiteral("y>\r\n");
#nullable restore
#line 67 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OrderManager\GetOrderListMessage.cshtml"
                             if (Model._OrderListMessage != null)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OrderManager\GetOrderListMessage.cshtml"
                                 foreach (Order MyOrder in Model._OrderListMessage.OrderList)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>");
#nullable restore
#line 72 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OrderManager\GetOrderListMessage.cshtml"
                                       Write(MyOrder.OrderNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 73 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OrderManager\GetOrderListMessage.cshtml"
                                       Write(MyOrder.OrderState);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>\r\n");
#nullable restore
#line 75 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OrderManager\GetOrderListMessage.cshtml"
                                             foreach (OrderLine MyOrderLine in MyOrder.OrderLineList)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <ul>\r\n                                                    <li>ProductId : ");
#nullable restore
#line 78 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OrderManager\GetOrderListMessage.cshtml"
                                                               Write(MyOrderLine.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                                    <li>SellerProductId : ");
#nullable restore
#line 79 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OrderManager\GetOrderListMessage.cshtml"
                                                                     Write(MyOrderLine.SellerProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                                    <li>Ean : ");
#nullable restore
#line 80 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OrderManager\GetOrderListMessage.cshtml"
                                                         Write(MyOrderLine.ProductEan);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                                    <li>AcceptationState : ");
#nullable restore
#line 81 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OrderManager\GetOrderListMessage.cshtml"
                                                                      Write(MyOrderLine.AcceptationState);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                                    <li>ProductCondition : ");
#nullable restore
#line 82 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OrderManager\GetOrderListMessage.cshtml"
                                                                      Write(MyOrderLine.ProductCondition);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                                </ul>\r\n");
#nullable restore
#line 84 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OrderManager\GetOrderListMessage.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 87 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OrderManager\GetOrderListMessage.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 87 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OrderManager\GetOrderListMessage.cshtml"
                                 
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tbody>\r\n\r\n\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 99 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OrderManager\GetOrderListMessage.cshtml"
    }
    else if (Model._ErrorMessage != "")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-danger\">\r\n            <strong>Failed!</strong> : error message : ");
#nullable restore
#line 103 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OrderManager\GetOrderListMessage.cshtml"
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
#line 114 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OrderManager\GetOrderListMessage.cshtml"
                                                        Write(Html.DisplayFor(model => model._RequestXML));

#line default
#line hidden
#nullable disable
            WriteLiteral("</pre></div>\r\n                </div>\r\n            </div>\r\n            <div class=\"panel panel-default\">");
#nullable restore
#line 117 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OrderManager\GetOrderListMessage.cshtml"
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
#line 124 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OrderManager\GetOrderListMessage.cshtml"
                                                        Write(Html.DisplayFor(model => model._MessageXML));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</pre></div>
                </div>           
                <textarea id=""textbox"">Type something here</textarea> <button id=""create"">Create file</button> <a download=""info.txt"" id=""downloadlink"" style=""display: none"">Download</a>
            </div>
        </div>
        <div class=""form-group"">
            <div class=""panel panel-default"">
                <div class=""panel panel-info"">
                    <div class=""panel-heading"">
                        <h3 class=""panel-title"">Order List</h3>
                    </div>
                    <div class=""panel-body"">
                        <br />
                        <div class=""table-responsive"">
                            <table class=""table-striped"">
                                <thead>
                                    <tr>
                                        <th>OrderNumber</th>
                                        <th>OrderState</th>
                                        <th>OrderLineList</th>
                 ");
            WriteLiteral("                   </tr>\r\n                                </thead>\r\n                                <tbody>\r\n");
#nullable restore
#line 147 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OrderManager\GetOrderListMessage.cshtml"
                                     if (Model._OrderListMessage != null)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 149 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OrderManager\GetOrderListMessage.cshtml"
                                         foreach (Order MyOrder in Model._OrderListMessage.OrderList)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <tr>\r\n                                                <td>");
#nullable restore
#line 152 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OrderManager\GetOrderListMessage.cshtml"
                                               Write(MyOrder.OrderNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 153 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OrderManager\GetOrderListMessage.cshtml"
                                               Write(MyOrder.OrderState);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>\r\n");
#nullable restore
#line 155 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OrderManager\GetOrderListMessage.cshtml"
                                                     foreach (OrderLine MyOrderLine in MyOrder.OrderLineList)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <ul>\r\n                                                            <li>ProductId : ");
#nullable restore
#line 158 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OrderManager\GetOrderListMessage.cshtml"
                                                                       Write(MyOrderLine.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                                            <li>SellerProductId : ");
#nullable restore
#line 159 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OrderManager\GetOrderListMessage.cshtml"
                                                                             Write(MyOrderLine.SellerProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                                            <li>Ean : ");
#nullable restore
#line 160 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OrderManager\GetOrderListMessage.cshtml"
                                                                 Write(MyOrderLine.ProductEan);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                                            <li>AcceptationState : ");
#nullable restore
#line 161 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OrderManager\GetOrderListMessage.cshtml"
                                                                              Write(MyOrderLine.AcceptationState);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                                            <li>ProductCondition : ");
#nullable restore
#line 162 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OrderManager\GetOrderListMessage.cshtml"
                                                                              Write(MyOrderLine.ProductCondition);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                                        </ul>\r\n");
#nullable restore
#line 164 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OrderManager\GetOrderListMessage.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                </td>\r\n                                            </tr>\r\n");
#nullable restore
#line 167 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OrderManager\GetOrderListMessage.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 167 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OrderManager\GetOrderListMessage.cshtml"
                                         
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </tbody>\r\n\r\n\r\n                            </table>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 179 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OrderManager\GetOrderListMessage.cshtml"

    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-warning\">\r\n            <strong>Warning!</strong> error message : ");
#nullable restore
#line 184 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OrderManager\GetOrderListMessage.cshtml"
                                                 Write(Model._ErrorMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral(@".
        </div>
        <div class=""form-group"">
            <div class=""panel panel-default"">
                <div class=""panel panel-info"">
                    <div class=""panel-heading"">
                        <h3 class=""panel-title"">Order List</h3>
                    </div>
                    <div class=""panel-body"">
                        <br />
                        <div class=""table-responsive"">
                            <table class=""table-striped"">
                                <thead>
                                    <tr>
                                        <th>OrderNumber</th>
                                        <th>OrderState</th>
                                        <th>OrderLineList</th>
                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 204 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OrderManager\GetOrderListMessage.cshtml"
                                     if (Model._OrderListMessage != null)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 206 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OrderManager\GetOrderListMessage.cshtml"
                                         foreach (Order MyOrder in Model._OrderListMessage.OrderList)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <tr>\r\n                                                <td>");
#nullable restore
#line 209 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OrderManager\GetOrderListMessage.cshtml"
                                               Write(MyOrder.OrderNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 210 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OrderManager\GetOrderListMessage.cshtml"
                                               Write(MyOrder.OrderState);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>\r\n");
#nullable restore
#line 212 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OrderManager\GetOrderListMessage.cshtml"
                                                     foreach (OrderLine MyOrderLine in MyOrder.OrderLineList)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <ul>\r\n                                                            <li>ProductId : ");
#nullable restore
#line 215 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OrderManager\GetOrderListMessage.cshtml"
                                                                       Write(MyOrderLine.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                                            <li>SellerProductId : ");
#nullable restore
#line 216 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OrderManager\GetOrderListMessage.cshtml"
                                                                             Write(MyOrderLine.SellerProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                                            <li>Ean : ");
#nullable restore
#line 217 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OrderManager\GetOrderListMessage.cshtml"
                                                                 Write(MyOrderLine.ProductEan);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                                            <li>AcceptationState : ");
#nullable restore
#line 218 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OrderManager\GetOrderListMessage.cshtml"
                                                                              Write(MyOrderLine.AcceptationState);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                                            <li>ProductCondition : ");
#nullable restore
#line 219 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OrderManager\GetOrderListMessage.cshtml"
                                                                              Write(MyOrderLine.ProductCondition);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                                        </ul>\r\n");
#nullable restore
#line 221 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OrderManager\GetOrderListMessage.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                </td>\r\n                                            </tr>\r\n");
#nullable restore
#line 224 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OrderManager\GetOrderListMessage.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 224 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OrderManager\GetOrderListMessage.cshtml"
                                         
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </tbody>\r\n\r\n\r\n                            </table>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 236 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OrderManager\GetOrderListMessage.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!--<h4><a href=""~/OrderManager/Download/?SellerLogin=Model._OrderListMessage.SellerLogin"">Export your order list</a></h4>
-->
<script>

/*    var editor = CodeMirror(document.getElementById(""RequestXML""), {
        mode: ""xml"",
        height: ""auto"",
        value: """);
#nullable restore
#line 244 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\OrderManager\GetOrderListMessage.cshtml"
           Write(Model._RequestXML.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
        smartIndent: ""true"",
        xml: ""true"",
        htmlMode: ""true""

    }); 

    function showCode() {
        var text = editor.getValue();
        alert(text);
    }*/
    (function () {
var textFile = null,
  makeTextFile = function (text) {
    var data = new Blob([text], {type: 'text/plain'});

    // If we are replacing a previously generated file we need to
    // manually revoke the object URL to avoid memory leaks.
    if (textFile !== null) {
      window.URL.revokeObjectURL(textFile);
    }

    textFile = window.URL.createObjectURL(data);

    return textFile;
  };


  var create = document.getElementById('create'),
    textbox = document.getElementById('textbox');

  create.addEventListener('click', function () {
    var link = document.getElementById('downloadlink');
    link.href = makeTextFile(textbox.value);
    link.style.display = 'block';
  }, false);
})();
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<cdscntmkpapinetcore2webapp.Models.OrderManager.GetOrderListMessage> Html { get; private set; }
    }
}
#pragma warning restore 1591
