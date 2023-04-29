#pragma checksum "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\Shared\_SelectFromAvailableVehicles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "626249f7ecb8bd7bdfc73aae940416e520860986"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__SelectFromAvailableVehicles), @"mvc.1.0.view", @"/Views/Shared/_SelectFromAvailableVehicles.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"626249f7ecb8bd7bdfc73aae940416e520860986", @"/Views/Shared/_SelectFromAvailableVehicles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e0c6b9ae6eaf1630e95ae41f50213962174ce39", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__SelectFromAvailableVehicles : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VehicleSelectionVM>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\Shared\_SelectFromAvailableVehicles.cshtml"
      
        if (Model.Vehicles == null || Model.Vehicles.Count == 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <span> No Vehicles of Type ");
#nullable restore
#line 5 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\Shared\_SelectFromAvailableVehicles.cshtml"
                                  Write(Model.VehicleType);

#line default
#line hidden
#nullable disable
            WriteLiteral(" found </span>\r\n");
#nullable restore
#line 6 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\Shared\_SelectFromAvailableVehicles.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <table align=""center"" border=1 cellspacing=0 cellpadding=0>
            <tr>
                <th>Tag Number</th><th>Year</th><th>Make</th><th>Model</th><th>Color</th><th>Type</th><th>Owner Budget</th><th>Beginning Service Date</th><th>Ending Service Date</th>
            </tr>
");
#nullable restore
#line 13 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\Shared\_SelectFromAvailableVehicles.cshtml"
             foreach (var vehicle in Model.Vehicles)
            {
                var statClass = vehicle.Status == "i" ? "unAvailableVehicle" : "";

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr");
            BeginWriteAttribute("class", " class=\"", 687, "\"", 705, 1);
#nullable restore
#line 16 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\Shared\_SelectFromAvailableVehicles.cshtml"
WriteAttributeValue("", 695, statClass, 695, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <td>\r\n                        <a");
            BeginWriteAttribute("href", " href=", 761, "", 826, 2);
#nullable restore
#line 18 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\Shared\_SelectFromAvailableVehicles.cshtml"
WriteAttributeValue("", 767, Url.Action("AssignVehicle","VehicleAssignments"), 767, 49, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 816, "?tagNumber", 816, 10, true);
            EndWriteAttribute();
            WriteLiteral("=");
#nullable restore
#line 18 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\Shared\_SelectFromAvailableVehicles.cshtml"
                                                                                       Write(vehicle.TagNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("&vehReqNo=");
#nullable restore
#line 18 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\Shared\_SelectFromAvailableVehicles.cshtml"
                                                                                                                   Write(Model.VehReqNo);

#line default
#line hidden
#nullable disable
            WriteLiteral(">");
#nullable restore
#line 18 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\Shared\_SelectFromAvailableVehicles.cshtml"
                                                                                                                                   Write(vehicle.TagNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                    </td>\r\n                    <td>");
#nullable restore
#line 20 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\Shared\_SelectFromAvailableVehicles.cshtml"
                   Write(vehicle.VehYear);

#line default
#line hidden
#nullable disable
            WriteLiteral(" &nbsp;</td>\r\n                    <td>");
#nullable restore
#line 21 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\Shared\_SelectFromAvailableVehicles.cshtml"
                   Write(vehicle.Make);

#line default
#line hidden
#nullable disable
            WriteLiteral(" &nbsp;</td>\r\n                    <td>");
#nullable restore
#line 22 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\Shared\_SelectFromAvailableVehicles.cshtml"
                   Write(vehicle.Model);

#line default
#line hidden
#nullable disable
            WriteLiteral(" &nbsp;</td>\r\n                    <Td>");
#nullable restore
#line 23 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\Shared\_SelectFromAvailableVehicles.cshtml"
                   Write(vehicle.Color);

#line default
#line hidden
#nullable disable
            WriteLiteral(" &nbsp;</td>\r\n                    <td>");
#nullable restore
#line 24 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\Shared\_SelectFromAvailableVehicles.cshtml"
                   Write(vehicle.VehicleType);

#line default
#line hidden
#nullable disable
            WriteLiteral(" &nbsp;</td>    \r\n                    <td>");
#nullable restore
#line 25 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\Shared\_SelectFromAvailableVehicles.cshtml"
                   Write(vehicle.OwnerBudget);

#line default
#line hidden
#nullable disable
            WriteLiteral(" &nbsp;</td>\r\n                    <td>");
#nullable restore
#line 26 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\Shared\_SelectFromAvailableVehicles.cshtml"
                   Write(vehicle.OutOfServiceBegin);

#line default
#line hidden
#nullable disable
            WriteLiteral(" &nbsp;</td>\r\n                    <td>");
#nullable restore
#line 27 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\Shared\_SelectFromAvailableVehicles.cshtml"
                   Write(vehicle.OutOfServiceEnd);

#line default
#line hidden
#nullable disable
            WriteLiteral(" &nbsp;</td>\r\n                </tr>\r\n");
#nullable restore
#line 29 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\Shared\_SelectFromAvailableVehicles.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </table>\r\n");
#nullable restore
#line 31 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\Shared\_SelectFromAvailableVehicles.cshtml"

        }

   

#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\r\n   .unAvailableVehicle  {\r\n       background-color: #dddddd\r\n   }\r\n</style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VehicleSelectionVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
