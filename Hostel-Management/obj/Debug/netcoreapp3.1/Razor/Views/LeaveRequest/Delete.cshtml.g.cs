#pragma checksum "C:\Users\91968\source\repos\Hostel-Management\Hostel-Management\Views\LeaveRequest\Delete.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "f0a7622a21f7416c09d55d2306211cbfa57c163cba91677bca7e71eaabcc007f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LeaveRequest_Delete), @"mvc.1.0.view", @"/Views/LeaveRequest/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"f0a7622a21f7416c09d55d2306211cbfa57c163cba91677bca7e71eaabcc007f", @"/Views/LeaveRequest/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"3d84ada461010a5469a3215ed99c38fa090d628e64bef56d2e4873ccb03de438", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_LeaveRequest_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Hostel_Management.Models.LeaveRequest>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\91968\source\repos\Hostel-Management\Hostel-Management\Views\LeaveRequest\Delete.cshtml"
  
    ViewData["Title"] = "Delete Leave Request";

#line default
#line hidden
#nullable disable

            WriteLiteral(@"
<div class=""container mt-5"">
    <h1 class=""text-center"">Delete Leave Request</h1>

    <h3 class=""text-center"">Are you sure you want to delete this?</h3>
    <div>
        <h4 class=""text-center"">Leave Request Details</h4>
        <hr />
        <dl class=""row"">
            <dt class=""col-sm-2"">
                ");
            Write(
#nullable restore
#line 16 "C:\Users\91968\source\repos\Hostel-Management\Hostel-Management\Views\LeaveRequest\Delete.cshtml"
                 Html.DisplayNameFor(model => model.StartDate)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
            Write(
#nullable restore
#line 19 "C:\Users\91968\source\repos\Hostel-Management\Hostel-Management\Views\LeaveRequest\Delete.cshtml"
                 Html.DisplayFor(model => model.StartDate)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
            Write(
#nullable restore
#line 22 "C:\Users\91968\source\repos\Hostel-Management\Hostel-Management\Views\LeaveRequest\Delete.cshtml"
                 Html.DisplayNameFor(model => model.EndDate)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
            Write(
#nullable restore
#line 25 "C:\Users\91968\source\repos\Hostel-Management\Hostel-Management\Views\LeaveRequest\Delete.cshtml"
                 Html.DisplayFor(model => model.EndDate)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
            Write(
#nullable restore
#line 28 "C:\Users\91968\source\repos\Hostel-Management\Hostel-Management\Views\LeaveRequest\Delete.cshtml"
                 Html.DisplayNameFor(model => model.ApprovedByAdmin)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
            Write(
#nullable restore
#line 31 "C:\Users\91968\source\repos\Hostel-Management\Hostel-Management\Views\LeaveRequest\Delete.cshtml"
                 Html.DisplayFor(model => model.ApprovedByAdmin)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
            Write(
#nullable restore
#line 34 "C:\Users\91968\source\repos\Hostel-Management\Hostel-Management\Views\LeaveRequest\Delete.cshtml"
                 Html.DisplayNameFor(model => model.reason)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
            Write(
#nullable restore
#line 37 "C:\Users\91968\source\repos\Hostel-Management\Hostel-Management\Views\LeaveRequest\Delete.cshtml"
                 Html.DisplayFor(model => model.reason)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
            Write(
#nullable restore
#line 40 "C:\Users\91968\source\repos\Hostel-Management\Hostel-Management\Views\LeaveRequest\Delete.cshtml"
                 Html.DisplayNameFor(model => model.Student)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
            Write(
#nullable restore
#line 43 "C:\Users\91968\source\repos\Hostel-Management\Hostel-Management\Views\LeaveRequest\Delete.cshtml"
                 Html.DisplayFor(model => model.Student.StudentID)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n\r\n        <div class=\"text-center\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f0a7622a21f7416c09d55d2306211cbfa57c163cba91677bca7e71eaabcc007f9508", async() => {
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f0a7622a21f7416c09d55d2306211cbfa57c163cba91677bca7e71eaabcc007f9806", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.
#nullable restore
#line 49 "C:\Users\91968\source\repos\Hostel-Management\Hostel-Management\Views\LeaveRequest\Delete.cshtml"
                                              LeaveRequestID

#line default
#line hidden
#nullable disable
                );
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" />\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f0a7622a21f7416c09d55d2306211cbfa57c163cba91677bca7e71eaabcc007f11741", async() => {
                    WriteLiteral("Back to List");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Hostel_Management.Models.LeaveRequest> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
