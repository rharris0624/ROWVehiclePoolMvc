#pragma checksum "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\ViewMyRequisitions.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88b30c6bd79850e4d39f02dc43106d6fb686ecd7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_VehicleRequisitions_ViewMyRequisitions), @"mvc.1.0.view", @"/Views/VehicleRequisitions/ViewMyRequisitions.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88b30c6bd79850e4d39f02dc43106d6fb686ecd7", @"/Views/VehicleRequisitions/ViewMyRequisitions.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01b5ba12a758c9b296967c3e37c10850ee8bb281", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_VehicleRequisitions_ViewMyRequisitions : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RowVehiclePoolMVC.Models.VehicleRequisition>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\ViewMyRequisitions.cshtml"
  
    ViewData["Title"] = "My Requests";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88b30c6bd79850e4d39f02dc43106d6fb686ecd75554", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table table-bordered table-striped\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\ViewMyRequisitions.cshtml"
           Write(Html.DisplayNameFor(model => model.VehReqDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\ViewMyRequisitions.cshtml"
           Write(Html.DisplayNameFor(model => model.Requestor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\ViewMyRequisitions.cshtml"
           Write(Html.DisplayNameFor(model => model.VehType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\ViewMyRequisitions.cshtml"
           Write(Html.DisplayNameFor(model => model.Destination));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\ViewMyRequisitions.cshtml"
           Write(Html.DisplayNameFor(model => model.Duties));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\ViewMyRequisitions.cshtml"
           Write(Html.DisplayNameFor(model => model.NoInParty));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 35 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\ViewMyRequisitions.cshtml"
           Write(Html.DisplayNameFor(model => model.ReqDivision));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 38 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\ViewMyRequisitions.cshtml"
           Write(Html.DisplayNameFor(model => model.ReqSectionId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 41 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\ViewMyRequisitions.cshtml"
           Write(Html.DisplayNameFor(model => model.ReqBudget));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 44 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\ViewMyRequisitions.cshtml"
           Write(Html.DisplayNameFor(model => model.ReqFunction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 47 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\ViewMyRequisitions.cshtml"
           Write(Html.DisplayNameFor(model => model.ReqJobNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 50 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\ViewMyRequisitions.cshtml"
           Write(Html.DisplayNameFor(model => model.ReqFap));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 53 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\ViewMyRequisitions.cshtml"
           Write(Html.DisplayNameFor(model => model.ReqComments));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 56 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\ViewMyRequisitions.cshtml"
           Write(Html.DisplayNameFor(model => model.ReqDepartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 59 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\ViewMyRequisitions.cshtml"
           Write(Html.DisplayNameFor(model => model.ReqReturnDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 62 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\ViewMyRequisitions.cshtml"
           Write(Html.DisplayNameFor(model => model.Userid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 65 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\ViewMyRequisitions.cshtml"
           Write(Html.DisplayNameFor(model => model.VehReqStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 68 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\ViewMyRequisitions.cshtml"
           Write(Html.DisplayNameFor(model => model.NotificationDivHead));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 71 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\ViewMyRequisitions.cshtml"
           Write(Html.DisplayNameFor(model => model.NotificationMan));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 74 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\ViewMyRequisitions.cshtml"
           Write(Html.DisplayNameFor(model => model.EmailAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 77 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\ViewMyRequisitions.cshtml"
           Write(Html.DisplayNameFor(model => model.LastChangeUserid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 83 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\ViewMyRequisitions.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td class=\"text-center\">\r\n                    ");
#nullable restore
#line 87 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\ViewMyRequisitions.cshtml"
               Write(Html.DisplayFor(modelItem => item.VehReqDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td class=\"text-left\">\r\n                    ");
#nullable restore
#line 90 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\ViewMyRequisitions.cshtml"
               Write(Html.DisplayFor(modelItem => item.Requestor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 93 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\ViewMyRequisitions.cshtml"
               Write(Html.DisplayFor(modelItem => item.VehType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 96 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\ViewMyRequisitions.cshtml"
               Write(Html.DisplayFor(modelItem => item.Destination));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 99 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\ViewMyRequisitions.cshtml"
               Write(Html.DisplayFor(modelItem => item.Duties));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 102 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\ViewMyRequisitions.cshtml"
               Write(Html.DisplayFor(modelItem => item.NoInParty));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 105 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\ViewMyRequisitions.cshtml"
               Write(Html.DisplayFor(modelItem => item.ReqDivision));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 108 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\ViewMyRequisitions.cshtml"
               Write(Html.DisplayFor(modelItem => item.ReqSectionId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 111 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\ViewMyRequisitions.cshtml"
               Write(Html.DisplayFor(modelItem => item.ReqBudget));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 114 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\ViewMyRequisitions.cshtml"
               Write(Html.DisplayFor(modelItem => item.ReqFunction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 117 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\ViewMyRequisitions.cshtml"
               Write(Html.DisplayFor(modelItem => item.ReqJobNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 120 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\ViewMyRequisitions.cshtml"
               Write(Html.DisplayFor(modelItem => item.ReqFap));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 123 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\ViewMyRequisitions.cshtml"
               Write(Html.DisplayFor(modelItem => item.ReqComments));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 126 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\ViewMyRequisitions.cshtml"
               Write(Html.DisplayFor(modelItem => item.ReqDepartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 129 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\ViewMyRequisitions.cshtml"
               Write(Html.DisplayFor(modelItem => item.ReqReturnDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 132 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\ViewMyRequisitions.cshtml"
               Write(Html.DisplayFor(modelItem => item.Userid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 135 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\ViewMyRequisitions.cshtml"
               Write(Html.DisplayFor(modelItem => item.VehReqStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 138 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\ViewMyRequisitions.cshtml"
               Write(Html.DisplayFor(modelItem => item.NotificationDivHead));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 141 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\ViewMyRequisitions.cshtml"
               Write(Html.DisplayFor(modelItem => item.NotificationMan));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 144 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\ViewMyRequisitions.cshtml"
               Write(Html.DisplayFor(modelItem => item.EmailAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 147 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\ViewMyRequisitions.cshtml"
               Write(Html.DisplayFor(modelItem => item.LastChangeUserid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88b30c6bd79850e4d39f02dc43106d6fb686ecd721891", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 150 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\ViewMyRequisitions.cshtml"
                                           WriteLiteral(item.VehReqNo);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88b30c6bd79850e4d39f02dc43106d6fb686ecd724092", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 151 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\ViewMyRequisitions.cshtml"
                                              WriteLiteral(item.VehReqNo);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88b30c6bd79850e4d39f02dc43106d6fb686ecd726299", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 152 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\ViewMyRequisitions.cshtml"
                                             WriteLiteral(item.VehReqNo);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 155 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\VehicleRequisitions\ViewMyRequisitions.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
        }
        #pragma warning restore 1998
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RowVehiclePoolMVC.Models.VehicleRequisition>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
