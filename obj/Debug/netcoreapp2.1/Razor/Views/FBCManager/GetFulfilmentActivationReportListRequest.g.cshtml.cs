#pragma checksum "C:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\GetFulfilmentActivationReportListRequest.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "725b9ed616802e200ed0bc8064c72927ada6dd9a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FBCManager_GetFulfilmentActivationReportListRequest), @"mvc.1.0.view", @"/Views/FBCManager/GetFulfilmentActivationReportListRequest.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/FBCManager/GetFulfilmentActivationReportListRequest.cshtml", typeof(AspNetCore.Views_FBCManager_GetFulfilmentActivationReportListRequest))]
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
#line 1 "C:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\_ViewImports.cshtml"
using cdscntmkpapinetcore2webapp;

#line default
#line hidden
#line 1 "C:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\GetFulfilmentActivationReportListRequest.cshtml"
using cdscntmkpapinetcore2webapp.Models;

#line default
#line hidden
#line 2 "C:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\GetFulfilmentActivationReportListRequest.cshtml"
using www.cdiscount.com;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"725b9ed616802e200ed0bc8064c72927ada6dd9a", @"/Views/FBCManager/GetFulfilmentActivationReportListRequest.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd17dbff09abcace87501202759f4739f3a1335f", @"/Views/_ViewImports.cshtml")]
    public class Views_FBCManager_GetFulfilmentActivationReportListRequest : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<cdscntmkpapinetcore2webapp.Models.FBCManager.GetFulfilmentActivationReportListRequest>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(162, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 6 "C:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\GetFulfilmentActivationReportListRequest.cshtml"
  
    ViewData["Title"] = "GetFulfilmentActivationReportList";

#line default
#line hidden
            BeginContext(235, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 11 "C:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\GetFulfilmentActivationReportListRequest.cshtml"
 using (Html.BeginForm("GetFulfilmentActivationReportListMessage", "FBCManager", FormMethod.Post, new { enctype = "multipart/form-data" }))
{


#line default
#line hidden
            BeginContext(385, 644, true);
            WriteLiteral(@"    <br />
    <br />
    <h2>GetFulfilmentActivationReportList</h2>
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
            EndContext();
            BeginContext(1030, 110, false);
#line 28 "C:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\GetFulfilmentActivationReportListRequest.cshtml"
                       Write(Html.TextBoxFor(model => model._Login, new { @id = "login", @class = "form-control", @placeholder = "Login" }));

#line default
#line hidden
            EndContext();
            BeginContext(1140, 226, true);
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            <label for=\"psw\"><span class=\"glyphicon glyphicon-eye-open\"></span> Password</label>\r\n                            ");
            EndContext();
            BeginContext(1367, 139, false);
#line 32 "C:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\GetFulfilmentActivationReportListRequest.cshtml"
                       Write(Html.TextBoxFor(model => model._Password, new { @id = "password", @class = "form-control", @placeholder = "Password", @type = "password" }));

#line default
#line hidden
            EndContext();
            BeginContext(1506, 223, true);
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            <label for=\"token\"><span class=\"glyphicon glyphicon-qrcode\"></span> Token</label>\r\n                            ");
            EndContext();
            BeginContext(1730, 110, false);
#line 36 "C:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\GetFulfilmentActivationReportListRequest.cshtml"
                       Write(Html.TextBoxFor(model => model._Token, new { @id = "token", @class = "form-control", @placeholder = "Token" }));

#line default
#line hidden
            EndContext();
            BeginContext(1840, 337, true);
            WriteLiteral(@"
                        </div>
                        <div class=""form-group"">
                            <label for=""token""><span class=""glyphicon glyphicon-qrcode""></span> Environment</label>
                            <br />
                            <p class=""nav navbar-nav navbar-left"">
                                ");
            EndContext();
            BeginContext(2178, 149, false);
#line 42 "C:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\GetFulfilmentActivationReportListRequest.cshtml"
                           Write(Html.DropDownListFor(m => m._EnvironmentSelected, new SelectList(Enum.GetValues(typeof(EnvironmentEnum))),
                    "Select Environment"));

#line default
#line hidden
            EndContext();
            BeginContext(2327, 591, true);
            WriteLiteral(@"
                            </p>
                            <br />
                        </div>
                    </div>
                </div>
            </div>

        </div>
    </div>
    <div class=""col-xs-5"">
        <div class=""panel panel-info"">
            <div class=""panel-heading"">
                <h3 class=""panel-title"">Parameters</h3>
            </div>
            <div class=""panel-body"">
                <div class=""tab-content"">
                    <br /><label for=""Select Filter Criterion"">Select a Deposit Id</label><br />
                    ");
            EndContext();
            BeginContext(2919, 193, false);
#line 61 "C:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\GetFulfilmentActivationReportListRequest.cshtml"
               Write(Html.TextBoxFor(m => m._FulfilmentActivationReportRequest.DepositIdList, new { @id = "DepositIdList", @class = "form-control form_datetime", placeholder = "DepositId;DepositId;DepositId;..." }));

#line default
#line hidden
            EndContext();
            BeginContext(3112, 154, true);
            WriteLiteral("<br />\r\n                    <br /><label for=\"Set BeginDate\"><span class=\"glyphicon glyphicon-calendar\"></span>Set BeginDate</label>\r\n                    ");
            EndContext();
            BeginContext(3267, 171, false);
#line 63 "C:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\GetFulfilmentActivationReportListRequest.cshtml"
               Write(Html.TextBoxFor(m => m._FulfilmentActivationReportRequest.BeginDate, new { @id = "BeginDate", @class = "form-control form_datetime", placeholder = "yyyy-mm-ddThh:mm:ss" }));

#line default
#line hidden
            EndContext();
            BeginContext(3438, 149, true);
            WriteLiteral("<br />\r\n                   <br /><label for=\"Set EndDate\"><span class=\"glyphicon glyphicon-calendar\"></span>Set EndDate</label>\r\n                    ");
            EndContext();
            BeginContext(3588, 167, false);
#line 65 "C:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\GetFulfilmentActivationReportListRequest.cshtml"
               Write(Html.TextBoxFor(m => m._FulfilmentActivationReportRequest.EndDate, new { @id = "EndDate", @class = "form-control form_datetime", placeholder = "yyyy-mm-ddThh:mm:ss" }));

#line default
#line hidden
            EndContext();
            BeginContext(3755, 281, true);
            WriteLiteral(@"<br />                    
                </div>
            </div>
        </div>
    </div>  
    <div class=""form-group"">
        <input type=""submit"" value=""Send"" class=""btn btn-info"" />
        <input type=""reset"" value=""Reset"" class=""btn btn-default"" />
    </div>
");
            EndContext();
#line 74 "C:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\GetFulfilmentActivationReportListRequest.cshtml"
}

#line default
#line hidden
            DefineSection("scripts", async() => {
                BeginContext(4057, 3797, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
        $(document).ready(function () {
            var next = 1;
            $('#sandbox-container .endCreationDate').datepicker({
                todayBtn: true,
                calendarWeeks: true,
                todayHighlight: true,
                beforeShowMonth: function (date) {
                    if (date.getMonth() == 8) {
                        return false;
                    }
                }
            });
        })
        $(document).ready(function () {

            $('#orderStatesEnum').multiselect({
                includeSelectAllOption: true,
                nonSelectedText: 'Selectionnez un filtre minimum',
                //enableFiltering: true,
                showCheckboxes: true,
                showSelectedItems: true
            });

            $('#beginCreationDate,#beginModificationDate,#endCreationDate,#endModificationDate').datetimepicker({
                autoclose: true,
                //format: ""yyyy/");
                WriteLiteral(@"mm/dd"",
                format: 'yyyy-mm-dd hh:ii',
                language: ""fr"",
                todayHighlight: true,
                //orientation: ""top right""
                minView: 1,
            });

            $('#beginCreationDate').on(""change"", function () {
                var dateToCopy = $(this).val();
                if ($('#beginModificationDate').val() == """")
                    $('#beginModificationDate').val(dateToCopy);
            })

            $('#endCreationDate').on(""change"", function () {
                var dateToCopy = $(this).val();
                if ($('#endModificationDate').val() == """")
                    $('#endModificationDate').val(dateToCopy);
            })

            $(function () {
                $(""input:file"").change(function () {
                    if ($(this).val() != """")
                        $(""input:submit"").val(""Mass Update with file"");
                    else
                        $(""input:submit"").val(""GetOrderList"");
  ");
                WriteLiteral(@"              });
            });

            $('#loginTab').click(function (e) {
                e.preventDefault()
                $(this).tab('show')
                $(""#token"").val("""");
            });

            $('#tokenTab').click(function (e) {
                e.preventDefault()
                $(this).tab('show')
                $(""#login"").val("""");
                $(""#password"").val("""");
            });

            $('form').bind(""keypress"", function (e) {
                if (e.keyCode == 13) {
                    e.preventDefault();
                    return false;
                }
            });

            $(""#sellerId"").on('input', function (e) {
                e.preventDefault();
                if (e.keyCode == 13) {
                    return false;
                }
                $(""#okBtn"").hide();
                $(""#nokBtn"").hide();

                var $this = $(this)
                var delay = 2000;
                clearTimeout($this.data('ti");
                WriteLiteral(@"mer'));
                $this.data('timer', setTimeout(function () {
                    $this.removeData('timer');
                    getToken();
                }, delay));
            });

            $('#go').click(function () {
                $(""#okBtn"").hide();
                $(""#nokBtn"").hide();
                getToken();
                return false;
            });

            $(""#token_error"").hide();
            $(""#loadingBtn"").hide();
            $(""#okBtn"").hide();

            function getToken() {
                var sellerId = $(""#sellerId"").val();
                $(""#loadingBtn"").show();
                $.ajax({
                    type: ""GET"",
                    url: '");
                EndContext();
                BeginContext(7855, 42, false);
#line 184 "C:\Users\gregory.tall\Documents\GitHub\cdscntmkpapinetcore2webapp\Views\FBCManager\GetFulfilmentActivationReportListRequest.cshtml"
                     Write(Url.Action("GetUserToken", "OrderManager"));

#line default
#line hidden
                EndContext();
                BeginContext(7897, 1507, true);
                WriteLiteral(@"',
                    contentType: ""application/json; charset=utf-8"",
                    data: {
                        ""sellerId"": sellerId
                    },
                    dataType: ""json"",
                    success: function (result) {
                        $(""#loadingBtn"").hide();
                        if (result.length != 32) {
                            errorToken(result);
                        } else {
                            $(""#okBtn"").show();
                            $(""#nokBtn"").hide();
                            $(""#login"").val("""");
                            $(""#password"").val("""");
                            $(""#token"").val(result);
                            $(""#token_error"").text("""").hide();
                            $(""#tokenTab"").addClass('active');
                            $(""#loginTab"").removeClass(""active"")
                            $(""#tokenO"").addClass('active');
                            $(""#loginO"").removeClass(""active"")
  ");
                WriteLiteral(@"                      }
                    },
                    error: function (result) {
                        errorToken(result);
                    }
                });

                function errorToken(result) {
                    $(""#okBtn"").hide();
                    $(""#nokBtn"").show();
                    $(""#token_error"").text(result).show();
                    $(""#token"").val("""");
                }
            };
        });
    </script>
");
                EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<cdscntmkpapinetcore2webapp.Models.FBCManager.GetFulfilmentActivationReportListRequest> Html { get; private set; }
    }
}
#pragma warning restore 1591
