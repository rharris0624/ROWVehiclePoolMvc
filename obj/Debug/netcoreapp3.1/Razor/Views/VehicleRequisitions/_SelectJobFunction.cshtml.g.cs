#pragma checksum "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\_SelectJobFunction.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0d9fbe1da61a39145bc2ea20ea7bb9330332de8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_VehicleRequisitions__SelectJobFunction), @"mvc.1.0.view", @"/Views/VehicleRequisitions/_SelectJobFunction.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\_ViewImports.cshtml"
using RowVehiclePoolMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\_ViewImports.cshtml"
using RowVehiclePoolMVC.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\_ViewImports.cshtml"
using RowVehiclePoolMVC.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.TagHelpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\_ViewImports.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\_ViewImports.cshtml"
using GridMvc.TagHelpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0d9fbe1da61a39145bc2ea20ea7bb9330332de8", @"/Views/VehicleRequisitions/_SelectJobFunction.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e0c6b9ae6eaf1630e95ae41f50213962174ce39", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_VehicleRequisitions__SelectJobFunction : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FunctionSearch>>
    #nullable disable
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!--Modal Body Start-->
<div class=""modal-content"">
    <!--Modal Header Start-->
    <div class=""modal-header"">
        <!--Modal Header Start-->
        <h4 class=""modal-title"">Select Job\Function</h4>
        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
            <span aria-hidden=""true"">x</span>
        </button>
        <button type=""button"" class=""btn btn-primary save-button"" data-save=""modal"">Post</button>
    </div>
    <!--Modal Header End-->

    ");
#nullable restore
#line 15 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\_SelectJobFunction.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"model-body\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0d9fbe1da61a39145bc2ea20ea7bb9330332de85148", async() => {
                WriteLiteral(@"
            <div class=""tab table"">
                <div class=""row"">
                    <div class=""col col-4 form-group"">
                        <label for=""Job"">Job:</label>
                        <input class=""form-control"" type=""text"" for=""Job"" id=""Job"" />
                    </div>
                    <div class=""form-group col col-3"">
                        <button class=""form-control"" type=""button"" value=""Search"" id=""searchButton"">Search</button>
                    </div>

                </div>
                <div class=""row"">
                    <div class=""col col-3"">
                        <label for=""JobSelected"">Job: </label>
                        <input type=""text"" readonly=""readonly"" id=""JobSelected"">
                    </div>
                    <div class=""col col-3"">
                        <label for=""FunctionSelected"">Function: </label>
                        <input type=""text"" readonly=""readonly"" id=""FunctionSelected"">
                    </div>
         ");
                WriteLiteral(@"           <div class=""col col-3"">
                        <label for=""FAPSelected"">FAP:</label>
                        <input type=""text"" readonly=""readonly"" id=""FAPSelected"">
                    </div>
                </div>
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        <div>
            <div id=""listTable""class=""tab tab-content tab-striped"" cellpadding=""5"">
                <div class=""row"">
                    <div class=""col""></div>
                    <div class=""col"">Job Number</></div>
                    <div class=""col"">Function</div>
                    <div class=""col"">F.A.P. Number</div>
                </div>
");
#nullable restore
#line 53 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\_SelectJobFunction.cshtml"
                  
                    var x = 0;
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\_SelectJobFunction.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"row rowBody\"");
            BeginWriteAttribute("id", " id=\"", 2473, "\"", 2493, 2);
            WriteAttributeValue("", 2478, "allotDetails_", 2478, 13, true);
#nullable restore
#line 58 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\_SelectJobFunction.cshtml"
WriteAttributeValue("", 2491, x, 2491, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-index=");
#nullable restore
#line 58 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\_SelectJobFunction.cshtml"
                                                                            Write(x);

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n                            <div class=\"col\"><input");
            BeginWriteAttribute("id", " id=\"", 2562, "\"", 2582, 2);
            WriteAttributeValue("", 2567, "selectButton_", 2567, 13, true);
#nullable restore
#line 59 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\_SelectJobFunction.cshtml"
WriteAttributeValue("", 2580, x, 2580, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"selectButton\" type=\"button\" class=\"btn btn-job form-control\"");
            BeginWriteAttribute("index", " index=", 2650, "", 2659, 1);
#nullable restore
#line 59 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\_SelectJobFunction.cshtml"
WriteAttributeValue("", 2657, x, 2657, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" value=\"Select\"></div>\r\n                            <div class=\"col\"><span");
            BeginWriteAttribute("id", " id=\"", 2733, "\"", 2744, 2);
            WriteAttributeValue("", 2738, "Job_", 2738, 4, true);
#nullable restore
#line 60 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\_SelectJobFunction.cshtml"
WriteAttributeValue("", 2742, x, 2742, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 60 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\_SelectJobFunction.cshtml"
                                                          Write(item.Job.Trim());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\r\n                            <div class=\"col\"><span");
            BeginWriteAttribute("id", " id=\"", 2827, "\"", 2839, 2);
            WriteAttributeValue("", 2832, "Func_", 2832, 5, true);
#nullable restore
#line 61 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\_SelectJobFunction.cshtml"
WriteAttributeValue("", 2837, x, 2837, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 61 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\_SelectJobFunction.cshtml"
                                                           Write(item.Function.Trim());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\r\n                            <div class=\"col\"><span");
            BeginWriteAttribute("id", " id=\"", 2927, "\"", 2938, 2);
            WriteAttributeValue("", 2932, "FAP_", 2932, 4, true);
#nullable restore
#line 62 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\_SelectJobFunction.cshtml"
WriteAttributeValue("", 2936, x, 2936, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 62 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\_SelectJobFunction.cshtml"
                                                          Write(item.FAP.Trim());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\r\n                        </div>\r\n");
#nullable restore
#line 64 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\_SelectJobFunction.cshtml"
                        x = x + 1;
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </div>
    <div class=""modal-footer"">
        <button type=""button"" class=""btn btn-primary"" data-dismiss=""modal"">Close</button>
        <button type=""button"" id=""btnPost"" class=""btn btn-primary save-button"" data-save=""modal"">Post</button>
    </div>
</div>

<script type=""text/javascript"">

$(document).ready(function () {
     $("".save-button"").click(function (event) {
        $(""#ReqJobNo"").val($(""#JobSelected"").val());
        $(""#ReqFunction"").val($(""#FunctionSelected"").val());
        $(""#ReqFap"").val($(""#FAPSelected"").val());
        $('#modal-select-job-function').modal(""hide"");
    });

    $("".btn-job"").click(function (event) {
        event.stopPropagation();
        var index = $(event.target).attr(""index"");
        $(""#JobSelected"").val($(""#Job_"" + index).text());
        $(""#FunctionSelected"").val($(""#Func_"" + index).text());
        $(""#FAPSelected"").val($(""#FAP_"" + index).text());
        var functionSearch = { job: job, function: fun");
            WriteLiteral("c, fap: fap };\r\n    });\r\n\r\n    $(\"#searchButton\").click(function () {\r\n        var jobNum = $(\'#Job\').val();\r\n        $.ajax({\r\n            url: \'");
#nullable restore
#line 97 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\_SelectJobFunction.cshtml"
             Write(Url.Action("SearchAllotmentsByJob","Allotment"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"?jobNo=' + jobNum,
            cache: false,
            async: true,
            type: ""GET"",
            success: function (data) {
                $("".rowBody"").remove();
                for (var x = 0; x < data.length; x++) {
                    $(""#listTable"").append('<div class=""row rowBody"" id=""allotDetails_' + x + '"">');
                    $(""#allotDetails_""+x).append('<div class=""col""><input id=""selectButton_'+x+'"" name=""selectButton"" type=""button"" class=""btn btn-job"" index='+x+' value=""Select""></div>');
                    $(""#allotDetails_""+x).append('<div class=""col""><span id=""Job_'+x+'"">' + data[x].job.trim()      + '</span></div>');
                    $(""#allotDetails_""+x).append('<div class=""col""><span id=""Func_'+x+'"" >' + data[x].function.trim() + '</span></div>');
                    $(""#allotDetails_"" + x).append('<div class=""col""><span id=""FAP_' + x + '"" >' + data[x].fap.trim() + '</span></div>');
                    $(""#jobListBody"").append('</div>');
                };

 ");
            WriteLiteral(@"               $("".btn-job"").click(function (event) {
                    event.stopPropagation();
                    // alert(""id = "" + event.target.id);
                    var index = $(event.target).attr(""index"");
                    $(""#JobSelected"").val($(""#Job_"" + index).text());
                    $(""#FunctionSelected"").val($(""#Func_"" + index).text());
                    $(""#FAPSelected"").val($(""#FAP_"" + index).text());
                    var functionSearch = { job: job, function: func, fap: fap };
                });
           },
            error: function (response) {
                alert('error : ' + response);
            }
        });
    });
});

</script>
");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IAuthorizationService AuthorizationService { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FunctionSearch>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
