#pragma checksum "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\Shared\_weekly.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d315da5875b0d9aeedee1ce4bc574c24ee0048b9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__weekly), @"mvc.1.0.view", @"/Views/Shared/_weekly.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d315da5875b0d9aeedee1ce4bc574c24ee0048b9", @"/Views/Shared/_weekly.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01b5ba12a758c9b296967c3e37c10850ee8bb281", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__weekly : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VehicleWeekVM>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Weekly", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("weekSwitch"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "weekly", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color: red"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AssignmentDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("detailAnchor"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"
<table border=1 cellspacing=0 cellpadding=0 bgcolor=#ffffff align=center width=""80%"">
  <tr>
    <td style=""background-color: #555555"">&nbsp;</td>
	<td style=""background-color: #555555"" align=""center"" colspan=""7"">
	<table width=100% border=0 cellspacing=0 cellpadding=2>
	  <tr>
");
#nullable restore
#line 9 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\Shared\_weekly.cshtml"
          
            string GetWeekTitle(DateTime uDate)
            {
                var weekDay = uDate.DayOfWeek;
                var returnVal = "Week of " + uDate.AddDays(1-(int)weekDay).ToLongDateString();
                return returnVal;
            }

            var begining = DateTime.Now.Year - 11;
            var ending = DateTime.Now.Year + 2;
                        if (begining == Model.UsageDate.Year)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td align=\"right\"><font color =#555555>next week &lt;&lt; last week</font></td>\r\n                            <td align=\"center\" colspan=\"2\"><font color=#ffffff><b>");
#nullable restore
#line 22 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\Shared\_weekly.cshtml"
                                                                             Write(GetWeekTitle(Model.UsageDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></font></td>\r\n                            <td align=\"left\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d315da5875b0d9aeedee1ce4bc574c24ee0048b97304", async() => {
                WriteLiteral("<b>next week &gt;&gt</b>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sDate", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 23 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\Shared\_weekly.cshtml"
                                                                        WriteLiteral(Model.UsageDate.AddDays(7).Date);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sDate"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sDate", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sDate"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n");
#nullable restore
#line 24 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\Shared\_weekly.cshtml"
            }
            else if(ending == Model.UsageDate.Year)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td align=\"right\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d315da5875b0d9aeedee1ce4bc574c24ee0048b99943", async() => {
                WriteLiteral("<b>next week &gt;&gt</b>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sDate", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 27 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\Shared\_weekly.cshtml"
                                                                         WriteLiteral(Model.UsageDate.AddDays(7).Date);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sDate"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sDate", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sDate"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                            <td align=\"center\"><font color=\"#ffffff\"><b>");
#nullable restore
#line 28 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\Shared\_weekly.cshtml"
                                                                   Write(GetWeekTitle(Model.UsageDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></font></td>\r\n                <td align=left><font color =\"#555555\">next week &gt;&gt;</font></td>\r\n");
#nullable restore
#line 30 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\Shared\_weekly.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td align=\"right\"><font color=\"#555555\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d315da5875b0d9aeedee1ce4bc574c24ee0048b913052", async() => {
                WriteLiteral("<b>&lt;&lt; last week</b>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sDate", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 33 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\Shared\_weekly.cshtml"
                                                                                               WriteLiteral(Model.UsageDate.AddDays(-7));

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sDate"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sDate", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sDate"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</font></td>\r\n                            <td align=\"center\"><font color=\"#ffffff\"><b>");
#nullable restore
#line 34 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\Shared\_weekly.cshtml"
                                                                   Write(GetWeekTitle(Model.UsageDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></font></td>\r\n                            <td align=\"left\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d315da5875b0d9aeedee1ce4bc574c24ee0048b915837", async() => {
                WriteLiteral("<b>next week &gt;&gt;</b>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sDate", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 35 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\Shared\_weekly.cshtml"
                                                                        WriteLiteral(Model.UsageDate.AddDays(7).Date);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sDate"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sDate", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sDate"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n");
#nullable restore
#line 36 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\Shared\_weekly.cshtml"
            }
      

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tr>\r\n            </table>\r\n            <tr>\r\n");
#nullable restore
#line 41 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\Shared\_weekly.cshtml"
                  
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td style=\"background-color: #c0c0c0\"></td>\r\n");
#nullable restore
#line 44 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\Shared\_weekly.cshtml"
                    }
                    var k = (int)Model.UsageDate.DayOfWeek;
                for(int i = 1; i < 8; i++)
                {
                    if (i == k)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td style=\"background-color: #a0a0a0\" align=\"center\"><font color=\"#000099\">");
#nullable restore
#line 50 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\Shared\_weekly.cshtml"
                                                                                          Write(Model.UsageDate.AddDays(i - k).ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</font><br><b>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d315da5875b0d9aeedee1ce4bc574c24ee0048b919579", async() => {
#nullable restore
#line 50 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\Shared\_weekly.cshtml"
                                                                                                                                                                                                                                       Write(Model.UsageDate.AddDays(i - k).DayOfWeek.ToString());

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sDate", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 50 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\Shared\_weekly.cshtml"
                                                                                                                                                                                           WriteLiteral(Model.UsageDate.AddDays(i - k).Date);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sDate"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sDate", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sDate"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</b></td>\r\n");
#nullable restore
#line 51 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\Shared\_weekly.cshtml"
                            ;
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td style=\"background-color: #c0c0c0\" align=\"center\">");
#nullable restore
#line 55 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\Shared\_weekly.cshtml"
                                                                    Write(Model.UsageDate.AddDays(i - k).ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("<br><b>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d315da5875b0d9aeedee1ce4bc574c24ee0048b923021", async() => {
#nullable restore
#line 55 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\Shared\_weekly.cshtml"
                                                                                                                                                                                                          Write(Model.UsageDate.AddDays(i - k).DayOfWeek.ToString());

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sDate", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 55 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\Shared\_weekly.cshtml"
                                                                                                                                                              WriteLiteral(Model.UsageDate.AddDays(i - k).Date);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sDate"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sDate", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sDate"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</b></td>\r\n");
#nullable restore
#line 56 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\Shared\_weekly.cshtml"
                            ;
                    }
                }
          

#line default
#line hidden
#nullable disable
            WriteLiteral("      </tr>\r\n");
#nullable restore
#line 61 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\Shared\_weekly.cshtml"
              
                var dayOfWeek = Model.UsageDate.DayOfWeek;
                var firstDayOfWeek = Model.UsageDate.AddDays(-(int)dayOfWeek + 1);
                var lastDayOfWeek = firstDayOfWeek.AddDays(6);
                IEnumerable<DateTime> daysOfTheWeek = Enumerable.Range(0, 1 + lastDayOfWeek.Subtract(firstDayOfWeek).Days).Select(offset => firstDayOfWeek.AddDays(offset)).ToArray();
                string[] vehicleTypes = { "Commission", "Car", "Pickup" };
                foreach (var vehicleType in vehicleTypes)
                {
                    var vCnt = Model.Vehicles.Where(c => c.VehicleType.Equals(vehicleType)).Count();
                    if(vCnt > 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr><td colspan=100 style=\"background-color: LightGrey\" valign=\"baseline\"><h4>");
#nullable restore
#line 72 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\Shared\_weekly.cshtml"
                                                                                                 Write(vehicleType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4></td></tr>\r\n");
#nullable restore
#line 73 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\Shared\_weekly.cshtml"
                    }
                    foreach (var vehicle in Model.Vehicles.Where(c => c.VehicleType == vehicleType))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr style=\"background-color: #d3d3d3\">\r\n                    <td>\r\n                                ");
#nullable restore
#line 78 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\Shared\_weekly.cshtml"
                           Write(vehicle.TagNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n                                ");
#nullable restore
#line 79 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\Shared\_weekly.cshtml"
                           Write(vehicle.Make);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                                ");
#nullable restore
#line 80 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\Shared\_weekly.cshtml"
                           Write(vehicle.Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                                ");
#nullable restore
#line 81 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\Shared\_weekly.cshtml"
                           Write(vehicle.Color);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    </td>\r\n");
#nullable restore
#line 83 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\Shared\_weekly.cshtml"
                              
                                int dayCtr = 0;
                                foreach (var day in daysOfTheWeek)
                                {
                                    var dayUsageInstances = Model.UsageInstances.Where(c => c.TagNumber.Equals(vehicle.TagNumber) && c.UsageDepartDate.Date <= day.Date && c.UsageReturnDate.Date >= day.Date).ToList();
                                    string backgroundColor = ++dayCtr > 5 ? "lightgreen" : dayUsageInstances.Count > 0 ? "#c0c0c0" : "lightblue";
                                    string colorValue = dayCtr > 5 ? "black" : "white";

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td");
            BeginWriteAttribute("style", " style=\"", 5328, "\"", 5370, 2);
            WriteAttributeValue("", 5336, "background-color:", 5336, 17, true);
#nullable restore
#line 90 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\Shared\_weekly.cshtml"
WriteAttributeValue(" ", 5353, backgroundColor, 5354, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <font");
            BeginWriteAttribute("color", " color=", 5411, "", 5429, 1);
#nullable restore
#line 91 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\Shared\_weekly.cshtml"
WriteAttributeValue("", 5418, colorValue, 5418, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 92 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\Shared\_weekly.cshtml"
                                             foreach (var dayUsage in dayUsageInstances)
                                            {
                                                var requestor = dayUsage.Requestor;
                                                if (requestor.ToLower().Contains("out of service"))
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d315da5875b0d9aeedee1ce4bc574c24ee0048b931232", async() => {
#nullable restore
#line 97 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\Shared\_weekly.cshtml"
                                                                                                                                   Write(requestor);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-assignNo", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 97 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\Shared\_weekly.cshtml"
                                                                                                        WriteLiteral(dayUsage.AssignNo);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["assignNo"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-assignNo", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["assignNo"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 98 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\Shared\_weekly.cshtml"
                                                }
                                                else
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d315da5875b0d9aeedee1ce4bc574c24ee0048b934214", async() => {
#nullable restore
#line 101 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\Shared\_weekly.cshtml"
                                                                                                                                                                Write(requestor);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "style", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6168, "color:", 6168, 6, true);
#nullable restore
#line 101 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\Shared\_weekly.cshtml"
AddHtmlAttributeValue(" ", 6174, colorValue, 6175, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-assignNo", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 101 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\Shared\_weekly.cshtml"
                                                                                                                WriteLiteral(dayUsage.AssignNo);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["assignNo"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-assignNo", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["assignNo"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 102 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\Shared\_weekly.cshtml"
                                                }
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </font>\r\n                            </td>\r\n");
#nullable restore
#line 106 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\Shared\_weekly.cshtml"
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tr>\r\n");
#nullable restore
#line 109 "C:\Users\rh41200\source\repos\RowVehiclePoolMVC\Views\Shared\_weekly.cshtml"
                    }
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VehicleWeekVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
