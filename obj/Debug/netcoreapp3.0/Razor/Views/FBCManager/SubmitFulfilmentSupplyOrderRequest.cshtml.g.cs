#pragma checksum "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\SubmitFulfilmentSupplyOrderRequest.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a93cc65def9fd8c777da18ded4f1484950bfc6e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FBCManager_SubmitFulfilmentSupplyOrderRequest), @"mvc.1.0.view", @"/Views/FBCManager/SubmitFulfilmentSupplyOrderRequest.cshtml")]
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
#line 2 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\SubmitFulfilmentSupplyOrderRequest.cshtml"
using cdscntmkpapinetcore2webapp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\SubmitFulfilmentSupplyOrderRequest.cshtml"
using www.cdiscount.com;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a93cc65def9fd8c777da18ded4f1484950bfc6e", @"/Views/FBCManager/SubmitFulfilmentSupplyOrderRequest.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd17dbff09abcace87501202759f4739f3a1335f", @"/Views/_ViewImports.cshtml")]
    public class Views_FBCManager_SubmitFulfilmentSupplyOrderRequest : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<cdscntmkpapinetcore2webapp.Models.FBCManager.SubmitFulfilmentSupplyOrderRequest>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "CEM", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "ANZ", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "SMD", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<fieldset>\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 6 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\SubmitFulfilmentSupplyOrderRequest.cshtml"
      
        ViewData["Title"] = "SubmitFulfilmentSupplyOrder";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 11 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\SubmitFulfilmentSupplyOrderRequest.cshtml"
     using (Html.BeginForm("SubmitFulfilmentSupplyOrderMessage", "FBCManager", FormMethod.Post, new { enctype = "multipart/form-data" }))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <br />
        <br />
        <h2>SubmitFulfilmentSupplyOrder</h2>
        <div class=""col-xs-3"">
            <div class=""panel panel-info"">
                <div class=""panel-heading"">
                    <h3 class=""panel-title"">Identification</h3>
                </div>
                <div class=""panel-body"">
                    <div class=""tab-content"">
                        <br />
                        <div role=""tabpanel"" class=""tab-pane active"" id=""loginTab"">
                            <div class=""form-group"">
                                <label for=""usrname""><span class=""glyphicon glyphicon-user""></span> Username</label>
                                ");
#nullable restore
#line 27 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\SubmitFulfilmentSupplyOrderRequest.cshtml"
                           Write(Html.TextBoxFor(model => model._Login, new { @id = "login", @class = "form-control", @placeholder = "Login" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"form-group\">\r\n                                <label for=\"psw\"><span class=\"glyphicon glyphicon-eye-open\"></span> Password</label>\r\n                                ");
#nullable restore
#line 31 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\SubmitFulfilmentSupplyOrderRequest.cshtml"
                           Write(Html.TextBoxFor(model => model._Password, new { @id = "password", @class = "form-control", @placeholder = "Password", @type = "password" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"form-group\">\r\n                                <label for=\"token\"><span class=\"glyphicon glyphicon-qrcode\"></span> Token</label>\r\n                                ");
#nullable restore
#line 35 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\SubmitFulfilmentSupplyOrderRequest.cshtml"
                           Write(Html.TextBoxFor(model => model._Token, new { @id = "token", @class = "form-control", @placeholder = "Token" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>
                            <div class=""form-group"">
                                <label for=""Environment""><span class=""glyphicon glyphicon-qrcode""></span> Environment</label>
                                <br />
                                <p class=""nav navbar-nav navbar-left"">
                                    ");
#nullable restore
#line 41 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\SubmitFulfilmentSupplyOrderRequest.cshtml"
                               Write(Html.DropDownListFor(m => m._EnvironmentSelected, new SelectList(Enum.GetValues(typeof(EnvironmentEnum))),"Select Environment"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </p>
                                <br />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>        
        <div class=""col-xs-12"">
            <div class=""panel panel-info"">
                <div class=""panel-heading"">
                    <h3 class=""panel-title"">Parameters : ProductList/FulfilmentProductDescription</h3>
                </div>
                <div class=""panel panel-default"">
                    <div class=""container"">    
                        <div id=""table"" class=""table-editable"">
                            
                            <table class=""table-condensed"">
                            <tr>
                                <th>ExternalSupplyOrderId</th>
                                <th>ProductEan</th>
                                <th>Quantity</th>
                                <th>SellerProductReference</th>
       ");
            WriteLiteral(@"                         <th>Warehouse</th>
                                <th>WarehouseReceptionMinDate</th>
                                <th></th>
                                <th><span class=""table-add glyphicon glyphicon-plus""></span></th>
                            </tr>
                            <tr>
                                <td contenteditable=""true"">
                                    <input type=""text"" class=""form-control"" id=""ExternalSupplyOrderId"" name=""ExternalSupplyOrderId[]"" value=""ExternalSupplyOrderId"" placeholder=""ExternalSupplyOrderId"">
                                </td>  
                                <td contenteditable=""true"">
                                    <input type=""text"" class=""form-control"" id=""ProductEan"" name=""ProductEan[]"" value=""ProductEan"" placeholder=""ProductEan"">
                                </td>
                                <td contenteditable=""true"">
                                    <input type=""text"" class=""form-control"" i");
            WriteLiteral(@"d=""Quantity"" name=""Quantity[]"" value=""Quantity"" placeholder=""Quantity"">
                                </td>                                   
                                <td contenteditable=""true"">
                                    <input type=""text"" class=""form-control"" id=""SellerProductReference"" name=""SellerProductReference[]"" value=""SellerProductReference"" placeholder=""SellerProductReference"">
                                </td>
                                <td contenteditable=""true"">
                                    <select class=""form-control"" id=""Warehouse"" value=""Warehouse"" name=""Warehouse[]"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a93cc65def9fd8c777da18ded4f1484950bfc6e11331", async() => {
                WriteLiteral("CEM");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a93cc65def9fd8c777da18ded4f1484950bfc6e12528", async() => {
                WriteLiteral("ANZ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a93cc65def9fd8c777da18ded4f1484950bfc6e13725", async() => {
                WriteLiteral("SMD");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    </select>
                                </td> 
                                <td contenteditable=""true"">
                                    <input type=""date"" class=""form-control"" id=""WarehouseReceptionMinDate"" name=""WarehouseReceptionMinDate[]"" value=""WarehouseReceptionMinDate"" placeholder=""WarehouseReceptionMinDate"">
                                </td> 
                                <td>
                                <span class=""table-remove glyphicon glyphicon-remove""></span>
                                </td>
                                <td>
                                <span class=""table-up glyphicon glyphicon-arrow-up""></span>
                                <span class=""table-down glyphicon glyphicon-arrow-down""></span>
                                </td>
                            </tr>
                            <!-- This is our clonable table line -->
                            <tr class=""hide"">
                         ");
            WriteLiteral(@"        <td contenteditable=""true"">
                                    <input type=""text"" class=""form-control"" id=""ExternalSupplyOrderId"" name=""ExternalSupplyOrderId[]"" value=""ExternalSupplyOrderId"" placeholder=""ExternalSupplyOrderId"">
                                </td>  
                                <td contenteditable=""true"">
                                    <input type=""text"" class=""form-control"" id=""ProductEan"" name=""ProductEan[]"" value=""ProductEan"" placeholder=""ProductEan"">
                                </td>
                                <td contenteditable=""true"">
                                    <input type=""text"" class=""form-control"" id=""Quantity"" name=""Quantity[]"" value=""Quantity"" placeholder=""Quantity"">
                                </td>                                   
                                <td contenteditable=""true"">
                                    <input type=""text"" class=""form-control"" id=""SellerProductReference"" name=""SellerProductReference[]"" valu");
            WriteLiteral(@"e=""SellerProductReference"" placeholder=""SellerProductReference"">
                                </td>
                                <td contenteditable=""true"">
                                    <input type=""text"" class=""form-control"" id=""Warehouse"" name=""Warehouse[]"" value=""Warehouse"" placeholder=""Warehouse"">
                                </td> 
                                <td contenteditable=""true"">
                                    <input type=""text"" class=""form-control"" id=""WarehouseReceptionMinDate"" name=""WarehouseReceptionMinDate[]"" value=""WarehouseReceptionMinDate"" placeholder=""WarehouseReceptionMinDate"">
                                </td> 
                                <td>
                                <span class=""table-remove glyphicon glyphicon-remove""></span>
                                </td>
                                <td>
                                <span class=""table-up glyphicon glyphicon-arrow-up""></span>
                                <span clas");
            WriteLiteral(@"s=""table-down glyphicon glyphicon-arrow-down""></span>
                                </td>
                            </tr>
                            </table>
                        </div>
                    </div>

                </div>
            </div>
        </div>
        <div class=""form-group"">
            <input type=""submit"" value=""Send"" class=""btn btn-info"" />
            <input type=""reset"" value=""Reset"" class=""btn btn-default"" />
        </div>
");
#nullable restore
#line 140 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\SubmitFulfilmentSupplyOrderRequest.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</fieldset>\r\n\r\n\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
        <script type=""text/javascript"">
            $(document).ready(function () {
                var next = 1;
                $("".add-more"").click(function (e) {
                    e.preventDefault();
                    var addto = ""#field"" + next;
                    var addRemove = ""#field"" + (next);
                    next = next + 1;
                    var newIn = '<input autocomplete=""off"" class=""input form-control"" id=""field' + next + '"" name=""field' + next + '"" type=""text"">';
                    var newInput = $(newIn);
                    var removeBtn = '<button id=""remove' + (next - 1) + '"" class=""btn btn-danger remove-me"" >-</button></div><div id=""field"">';
                    var removeButton = $(removeBtn);
                    $(addto).after(newInput);
                    $(addRemove).after(removeButton);
                    $(""#field"" + next).attr('data-source', $(addto).attr('data-source'));
                    $(""#count"").val(next);

                    $('.remove-me");
                WriteLiteral(@"').click(function (e) {
                        e.preventDefault();
                        var fieldNum = this.id.charAt(this.id.length - 1);
                        var fieldID = ""#field"" + fieldNum;
                        $(this).remove();
                        $(fieldID).remove();
                    });
                });



            });

            var room = 1;
            function orderline_fields() {

                room++;
                var objTo = document.getElementById('orderline_fields')
                var divtest = document.createElement(""div"");
                divtest.setAttribute(""class"", ""form-group removeorderline"" + room);
                var rdiv = 'removeorderline' + room;
                divtest.innerHTML = '<tr><td><div class=""col-sm-3 nopadding""><div class=""form-group""><input type=""text"" class=""form-control"" id=""SellerProductId"" name=""SellerProductId[]"" value="""" placeholder=""SellerProductId""></div></div></td><td><div class=""col-sm-3 nopadding""><div cla");
                WriteLiteral(@"ss=""form-group""><div class=""input-group""><select class=""form-control"" id=""ProductCondition"" name=""ProductCondition[]""><option value=""6"">New</option><option value=""1"">LikeNew</option><option value=""2"">VeryGoodState</option><option value=""3"">GoodState</option><option value=""4"">AverageState</option><option value=""5"">Refurbished</option></select></div></div></div></td><td><div class=""col-sm-3 nopadding""><div class=""form-group""><div class=""input-group""><select class=""form-control"" id=""AcceptationState"" name=""AcceptationState[]""><option value=""1"">AcceptedBySeller</option><option value=""2"">RefusedBySeller</option><option value=""3"">ShippedBySeller</option><option value=""5"">ShipmentRefusedBySeller</option></select><div class=""input-group-btn""><button class=""btn btn-danger"" type=""button"" onclick=""remove_orderline_fields(' + room + ');""><span class=""glyphicon glyphicon-minus"" aria-hidden=""true""></span></button></div></div></div></div></td><td><div class=""clear""></div></td></tr>';
                objTo.appendChild(divte");
                WriteLiteral(@"st)
            }
            function remove_orderline_fields(rid) {
                $('.removeorderline' + rid).remove();
            }
        </script>

        <script type=""text/javascript"">
        var $TABLE = $('#table');
        var $BTN = $('#export-btn');
        var $EXPORT = $('#export');

        $('.table-add').click(function () {
        var $clone = $TABLE.find('tr.hide').clone(true).removeClass('hide table-line');
        $TABLE.find('table').append($clone);
        });

        $('.table-remove').click(function () {
        $(this).parents('tr').detach();
        });

        $('.table-up').click(function () {
        var $row = $(this).parents('tr');
        if ($row.index() === 1) return; // Don't go above the header
        $row.prev().before($row.get(0));
        });

        $('.table-down').click(function () {
        var $row = $(this).parents('tr');
        $row.next().after($row.get(0));
        });

        // A few jQuery helpers for exporting onl");
                WriteLiteral(@"y
        jQuery.fn.pop = [].pop;
        jQuery.fn.shift = [].shift;

        $BTN.click(function () {
        var $rows = $TABLE.find('tr:not(:hidden)');
        var headers = [];
        var data = [];
        
        // Get the headers (add special header logic here)
        $($rows.shift()).find('th:not(:empty)').each(function () {
            headers.push($(this).text().toLowerCase());
        });
        
        // Turn all existing rows into a loopable array
        $rows.each(function () {
            var $td = $(this).find('td');
            var h = {};
            
            // Use the headers from earlier to name our hash keys
            headers.forEach(function (header, i) {
            h[header] = $td.eq(i).text();   
            });
            
            data.push(h);
        });
        
        // Output the result
        $EXPORT.text(JSON.stringify(data));
        });
</script>

    ");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<cdscntmkpapinetcore2webapp.Models.FBCManager.SubmitFulfilmentSupplyOrderRequest> Html { get; private set; }
    }
}
#pragma warning restore 1591
