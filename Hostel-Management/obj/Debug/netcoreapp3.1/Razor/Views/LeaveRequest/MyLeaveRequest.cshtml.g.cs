#pragma checksum "C:\Users\91968\source\repos\Hostel-Management\Hostel-Management\Views\LeaveRequest\MyLeaveRequest.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "fbc3a66c8f3c17ea41cbac5731c066586a38ca893074cdd8500dcf77407183a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LeaveRequest_MyLeaveRequest), @"mvc.1.0.view", @"/Views/LeaveRequest/MyLeaveRequest.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"fbc3a66c8f3c17ea41cbac5731c066586a38ca893074cdd8500dcf77407183a5", @"/Views/LeaveRequest/MyLeaveRequest.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"3d84ada461010a5469a3215ed99c38fa090d628e64bef56d2e4873ccb03de438", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_LeaveRequest_MyLeaveRequest : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Hostel_Management.Models.LeaveRequest>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Student", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary mt-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\91968\source\repos\Hostel-Management\Hostel-Management\Views\LeaveRequest\MyLeaveRequest.cshtml"
  
    ViewData["Title"] = "My Leave Requests";

#line default
#line hidden
#nullable disable

            WriteLiteral(@"
<div class=""container mt-5"">
    <div class=""row justify-content-center"">
        <div class=""col-md-8"">
            <div class=""card shadow-lg"">
                <div class=""card-header bg-primary text-white text-center"">
                    <h3>My Leave Requests</h3>
                </div>
                <div class=""card-body"">
");
#nullable restore
#line 15 "C:\Users\91968\source\repos\Hostel-Management\Hostel-Management\Views\LeaveRequest\MyLeaveRequest.cshtml"
                     if (Model != null && Model.Any())
                    {

#line default
#line hidden
#nullable disable

            WriteLiteral("                        <ul class=\"list-group\">\r\n");
#nullable restore
#line 18 "C:\Users\91968\source\repos\Hostel-Management\Hostel-Management\Views\LeaveRequest\MyLeaveRequest.cshtml"
                             foreach (var leaveRequest in Model)
                            {

#line default
#line hidden
#nullable disable

            WriteLiteral("                                <li class=\"list-group-item\">\r\n                                    <strong>Start Date:</strong> ");
            Write(
#nullable restore
#line 21 "C:\Users\91968\source\repos\Hostel-Management\Hostel-Management\Views\LeaveRequest\MyLeaveRequest.cshtml"
                                                                  leaveRequest.StartDate.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(",\r\n                                    <strong>End Date:</strong> ");
            Write(
#nullable restore
#line 22 "C:\Users\91968\source\repos\Hostel-Management\Hostel-Management\Views\LeaveRequest\MyLeaveRequest.cshtml"
                                                                leaveRequest.EndDate.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(",\r\n                                    <strong>Status:</strong> ");
            Write(
#nullable restore
#line 23 "C:\Users\91968\source\repos\Hostel-Management\Hostel-Management\Views\LeaveRequest\MyLeaveRequest.cshtml"
                                                               leaveRequest.ApprovedByAdmin ? "Approved" : "Pending"

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                                </li>\r\n");
#nullable restore
#line 25 "C:\Users\91968\source\repos\Hostel-Management\Hostel-Management\Views\LeaveRequest\MyLeaveRequest.cshtml"
                            }

#line default
#line hidden
#nullable disable

            WriteLiteral("                        </ul>\r\n");
#nullable restore
#line 27 "C:\Users\91968\source\repos\Hostel-Management\Hostel-Management\Views\LeaveRequest\MyLeaveRequest.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable

            WriteLiteral("                        <p>No leave requests found.</p>\r\n");
#nullable restore
#line 31 "C:\Users\91968\source\repos\Hostel-Management\Hostel-Management\Views\LeaveRequest\MyLeaveRequest.cshtml"
                    }

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n                    <div class=\"d-grid gap-2 d-md-flex justify-content-md-end mt-3\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbc3a66c8f3c17ea41cbac5731c066586a38ca893074cdd8500dcf77407183a58051", async() => {
                WriteLiteral("Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
            WriteLiteral(
#nullable restore
#line 34 "C:\Users\91968\source\repos\Hostel-Management\Hostel-Management\Views\LeaveRequest\MyLeaveRequest.cshtml"
                                                                                        ViewBag.StudentID

#line default
#line hidden
#nullable disable
            );
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Hostel_Management.Models.LeaveRequest>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
