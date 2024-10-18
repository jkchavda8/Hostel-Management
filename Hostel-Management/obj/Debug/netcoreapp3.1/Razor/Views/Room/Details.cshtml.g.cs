#pragma checksum "C:\Users\91968\source\repos\Hostel-Management\Hostel-Management\Views\Room\Details.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "05f2d7de23d6aa1a63a26807c22c1b6f4bc9feb0cac53732ba475608153ec0b2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Room_Details), @"mvc.1.0.view", @"/Views/Room/Details.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\91968\source\repos\Hostel-Management\Hostel-Management\Views\_ViewImports.cshtml"
using Hostel_Management

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\91968\source\repos\Hostel-Management\Hostel-Management\Views\_ViewImports.cshtml"
using Hostel_Management.Models

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"05f2d7de23d6aa1a63a26807c22c1b6f4bc9feb0cac53732ba475608153ec0b2", @"/Views/Room/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"3d84ada461010a5469a3215ed99c38fa090d628e64bef56d2e4873ccb03de438", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Room_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Hostel_Management.Models.Room>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\91968\source\repos\Hostel-Management\Hostel-Management\Views\Room\Details.cshtml"
  
    ViewData["Title"] = "Room Details";

#line default
#line hidden
#nullable disable

            WriteLiteral(@"
<div class=""container mt-5"">
    <h1 class=""text-center"">Room Details</h1>

    <div class=""card shadow-lg"">
        <div class=""card-header bg-primary text-white text-center"">
            <h4>Room Information</h4>
        </div>
        <div class=""card-body"">
            <h4 class=""card-title"">Room</h4>
            <hr />
            <dl class=""row"">
                <dt class=""col-sm-2"">
                    ");
            Write(
#nullable restore
#line 19 "C:\Users\91968\source\repos\Hostel-Management\Hostel-Management\Views\Room\Details.cshtml"
                     Html.DisplayNameFor(model => model.RoomNumber)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
            Write(
#nullable restore
#line 22 "C:\Users\91968\source\repos\Hostel-Management\Hostel-Management\Views\Room\Details.cshtml"
                     Html.DisplayFor(model => model.RoomNumber)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
            Write(
#nullable restore
#line 25 "C:\Users\91968\source\repos\Hostel-Management\Hostel-Management\Views\Room\Details.cshtml"
                     Html.DisplayNameFor(model => model.Capacity)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
            Write(
#nullable restore
#line 28 "C:\Users\91968\source\repos\Hostel-Management\Hostel-Management\Views\Room\Details.cshtml"
                     Html.DisplayFor(model => model.Capacity)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
            Write(
#nullable restore
#line 31 "C:\Users\91968\source\repos\Hostel-Management\Hostel-Management\Views\Room\Details.cshtml"
                     Html.DisplayNameFor(model => model.NumberOfBeds)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
            Write(
#nullable restore
#line 34 "C:\Users\91968\source\repos\Hostel-Management\Hostel-Management\Views\Room\Details.cshtml"
                     Html.DisplayFor(model => model.NumberOfBeds)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
            Write(
#nullable restore
#line 37 "C:\Users\91968\source\repos\Hostel-Management\Hostel-Management\Views\Room\Details.cshtml"
                     Html.DisplayNameFor(model => model.NumberOfFans)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
            Write(
#nullable restore
#line 40 "C:\Users\91968\source\repos\Hostel-Management\Hostel-Management\Views\Room\Details.cshtml"
                     Html.DisplayFor(model => model.NumberOfFans)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
            Write(
#nullable restore
#line 43 "C:\Users\91968\source\repos\Hostel-Management\Hostel-Management\Views\Room\Details.cshtml"
                     Html.DisplayNameFor(model => model.NumberOfTables)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
            Write(
#nullable restore
#line 46 "C:\Users\91968\source\repos\Hostel-Management\Hostel-Management\Views\Room\Details.cshtml"
                     Html.DisplayFor(model => model.NumberOfTables)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
            Write(
#nullable restore
#line 49 "C:\Users\91968\source\repos\Hostel-Management\Hostel-Management\Views\Room\Details.cshtml"
                     Html.DisplayNameFor(model => model.NumberOfChairs)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
            Write(
#nullable restore
#line 52 "C:\Users\91968\source\repos\Hostel-Management\Hostel-Management\Views\Room\Details.cshtml"
                     Html.DisplayFor(model => model.NumberOfChairs)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
            Write(
#nullable restore
#line 55 "C:\Users\91968\source\repos\Hostel-Management\Hostel-Management\Views\Room\Details.cshtml"
                     Html.DisplayNameFor(model => model.IsOccupied)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
            Write(
#nullable restore
#line 58 "C:\Users\91968\source\repos\Hostel-Management\Hostel-Management\Views\Room\Details.cshtml"
                     Html.DisplayFor(model => model.IsOccupied)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                </dd>\r\n            </dl>\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"d-grid gap-2 d-md-flex justify-content-md-end mt-3\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05f2d7de23d6aa1a63a26807c22c1b6f4bc9feb0cac53732ba475608153ec0b210963", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
            WriteLiteral(
#nullable restore
#line 65 "C:\Users\91968\source\repos\Hostel-Management\Hostel-Management\Views\Room\Details.cshtml"
                                            Model.RoomID

#line default
#line hidden
#nullable disable
            );
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        &nbsp;\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05f2d7de23d6aa1a63a26807c22c1b6f4bc9feb0cac53732ba475608153ec0b213292", async() => {
                WriteLiteral("Back to Room List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Hostel_Management.Models.Room> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
