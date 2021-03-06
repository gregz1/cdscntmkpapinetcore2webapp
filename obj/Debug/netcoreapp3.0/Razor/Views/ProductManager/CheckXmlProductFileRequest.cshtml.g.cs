#pragma checksum "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\CheckXmlProductFileRequest.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37e54f744b7aee58454a0822b09c1d89805ab931"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProductManager_CheckXmlProductFileRequest), @"mvc.1.0.view", @"/Views/ProductManager/CheckXmlProductFileRequest.cshtml")]
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
#line 2 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\CheckXmlProductFileRequest.cshtml"
using cdscntmkpapinetcore2webapp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\CheckXmlProductFileRequest.cshtml"
using www.cdiscount.com;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37e54f744b7aee58454a0822b09c1d89805ab931", @"/Views/ProductManager/CheckXmlProductFileRequest.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd17dbff09abcace87501202759f4739f3a1335f", @"/Views/_ViewImports.cshtml")]
    public class Views_ProductManager_CheckXmlProductFileRequest : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<cdscntmkpapinetcore2webapp.Models.ProductManager.CheckXmlFileRequest>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<fieldset>\r\n");
            WriteLiteral("    \r\n\r\n");
#nullable restore
#line 7 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\CheckXmlProductFileRequest.cshtml"
      
        ViewData["Title"] = "CheckXmlProductFile";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 11 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\CheckXmlProductFileRequest.cshtml"
     using (Html.BeginForm("CheckXmlOfferFileMessage", "OfferManager", FormMethod.Post, new { enctype = "multipart/form-data" }))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <br />
        <br />
        <h2>CheckXmlProductFile</h2>
        <div class=""col-xs-5"">
            <div class=""panel panel-info"">
                <div class=""panel-heading"">
                    <h3 class=""panel-title"">Parameters</h3>
                </div>
                <div class=""panel-body"">
                    <div class=""tab-content"">

                        <br /><label for=""Select Filter Criterion"">Select a xml Product file to validate</label><br />
                        <div class=""file-loading"">
                            <input id=""input-b7"" name=""input-b7[]"" multiple type=""file"" class=""file"" data-allowed-file-extensions='[""xml""]'>
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
#line 36 "c:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\ProductManager\CheckXmlProductFileRequest.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<cdscntmkpapinetcore2webapp.Models.ProductManager.CheckXmlFileRequest> Html { get; private set; }
    }
}
#pragma warning restore 1591
