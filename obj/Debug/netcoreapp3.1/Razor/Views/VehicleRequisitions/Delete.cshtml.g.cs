#pragma checksum "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "07a4f94ff77a113fc8435981cbff85c8a06c99dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_VehicleRequisitions_Delete), @"mvc.1.0.view", @"/Views/VehicleRequisitions/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07a4f94ff77a113fc8435981cbff85c8a06c99dd", @"/Views/VehicleRequisitions/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e0c6b9ae6eaf1630e95ae41f50213962174ce39", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_VehicleRequisitions_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RowVehiclePoolMVC.ViewModels.VehicleRequestVM>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewAllRequisitions", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>VehicleRequisition</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 16 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.VehReqDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 19 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\Delete.cshtml"
       Write(Html.DisplayFor(model => model.VehReqDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 22 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.VehRequestor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 25 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\Delete.cshtml"
       Write(Html.DisplayFor(model => model.VehRequestor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 28 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.VehType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 31 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\Delete.cshtml"
       Write(Html.DisplayFor(model => model.VehType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 34 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Destination));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 37 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Destination));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 40 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Duties));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 43 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Duties));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 46 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.NoInParty));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 49 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\Delete.cshtml"
       Write(Html.DisplayFor(model => model.NoInParty));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 52 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ReqDivision));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 55 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ReqDivision));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 58 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ReqSectionId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 61 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ReqSectionId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 64 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ReqBudget));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 67 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ReqBudget));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 70 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ReqFunction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 73 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ReqFunction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 76 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ReqJobNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 79 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ReqJobNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 82 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ReqFap));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 85 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ReqFap));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 88 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ReqComments));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 91 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ReqComments));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 94 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ReqDepartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 97 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ReqDepartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 100 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ReqReturnDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 103 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ReqReturnDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 106 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.UserId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 109 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\Delete.cshtml"
       Write(Html.DisplayFor(model => model.UserId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 112 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.VehReqStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 115 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\Delete.cshtml"
       Write(Html.DisplayFor(model => model.VehReqStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 118 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.NotificationDivHead));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 121 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\Delete.cshtml"
       Write(Html.DisplayFor(model => model.NotificationDivHead));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 124 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.NotificationMan));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 127 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\Delete.cshtml"
       Write(Html.DisplayFor(model => model.NotificationMan));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 130 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.EmailAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 133 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\Delete.cshtml"
       Write(Html.DisplayFor(model => model.EmailAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 136 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.LastChangeUserid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 139 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\Delete.cshtml"
       Write(Html.DisplayFor(model => model.LastChangeUserid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07a4f94ff77a113fc8435981cbff85c8a06c99dd19906", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "07a4f94ff77a113fc8435981cbff85c8a06c99dd20173", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 144 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.VehReqNo);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07a4f94ff77a113fc8435981cbff85c8a06c99dd21975", async() => {
                    WriteLiteral("Back to List");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RowVehiclePoolMVC.ViewModels.VehicleRequestVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
