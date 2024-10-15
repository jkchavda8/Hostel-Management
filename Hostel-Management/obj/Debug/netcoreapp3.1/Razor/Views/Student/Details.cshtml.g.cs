#pragma checksum "C:\Users\91968\source\repos\Hostel-Management\Hostel-Management\Views\Student\Details.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1e5bd4925ec9816bbfedb823f9c13fce6451a99e29f25c42cbb0ace7e22cc70e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Details), @"mvc.1.0.view", @"/Views/Student/Details.cshtml")]
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

#nullable disable
    ;
#nullable restore
#line 1 "C:\Users\91968\source\repos\Hostel-Management\Hostel-Management\Views\Student\Details.cshtml"
 using Microsoft.AspNetCore.Http

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"1e5bd4925ec9816bbfedb823f9c13fce6451a99e29f25c42cbb0ace7e22cc70e", @"/Views/Student/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"3d84ada461010a5469a3215ed99c38fa090d628e64bef56d2e4873ccb03de438", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Student_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Hostel_Management.Models.Student>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "LeaveRequest", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RequestLeave", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MyLeaveRequest", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\91968\source\repos\Hostel-Management\Hostel-Management\Views\Student\Details.cshtml"
  
    ViewData["Title"] = "Details";
    var isAdminLoggedIn = Context.Session.GetString("AdminEmail") != null; // Check if admin is logged in
    var studentIdString = Context.Session.GetString("StudentID"); // Get the student ID from session

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Student</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            Write(
#nullable restore
#line 17 "C:\Users\91968\source\repos\Hostel-Management\Hostel-Management\Views\Student\Details.cshtml"
             Html.DisplayNameFor(model => model.Name)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            Write(
#nullable restore
#line 20 "C:\Users\91968\source\repos\Hostel-Management\Hostel-Management\Views\Student\Details.cshtml"
             Html.DisplayFor(model => model.Name)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            Write(
#nullable restore
#line 23 "C:\Users\91968\source\repos\Hostel-Management\Hostel-Management\Views\Student\Details.cshtml"
             Html.DisplayNameFor(model => model.DOB)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            Write(
#nullable restore
#line 26 "C:\Users\91968\source\repos\Hostel-Management\Hostel-Management\Views\Student\Details.cshtml"
             Html.DisplayFor(model => model.DOB)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            Write(
#nullable restore
#line 29 "C:\Users\91968\source\repos\Hostel-Management\Hostel-Management\Views\Student\Details.cshtml"
             Html.DisplayNameFor(model => model.EntryDate)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            Write(
#nullable restore
#line 32 "C:\Users\91968\source\repos\Hostel-Management\Hostel-Management\Views\Student\Details.cshtml"
             Html.DisplayFor(model => model.EntryDate)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            Write(
#nullable restore
#line 35 "C:\Users\91968\source\repos\Hostel-Management\Hostel-Management\Views\Student\Details.cshtml"
             Html.DisplayNameFor(model => model.IsAdmitted)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            Write(
#nullable restore
#line 38 "C:\Users\91968\source\repos\Hostel-Management\Hostel-Management\Views\Student\Details.cshtml"
              Model.IsAdmitted ? "True" : "False"

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            Write(
#nullable restore
#line 41 "C:\Users\91968\source\repos\Hostel-Management\Hostel-Management\Views\Student\Details.cshtml"
             Html.DisplayName("Room Number")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            Write(
#nullable restore
#line 44 "C:\Users\91968\source\repos\Hostel-Management\Hostel-Management\Views\Student\Details.cshtml"
             Html.DisplayFor(model => model.Room.RoomID)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n\r\n");
#nullable restore
#line 48 "C:\Users\91968\source\repos\Hostel-Management\Hostel-Management\Views\Student\Details.cshtml"
     if (!isAdminLoggedIn) // Check if admin is not logged in
    {

#line default
#line hidden
#nullable disable

            WriteLiteral("        <div>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e5bd4925ec9816bbfedb823f9c13fce6451a99e29f25c42cbb0ace7e22cc70e9652", async() => {
                WriteLiteral("Request Leave");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
            WriteLiteral(
#nullable restore
#line 51 "C:\Users\91968\source\repos\Hostel-Management\Hostel-Management\Views\Student\Details.cshtml"
                                                                                      Model.StudentID

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
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e5bd4925ec9816bbfedb823f9c13fce6451a99e29f25c42cbb0ace7e22cc70e12229", async() => {
                WriteLiteral("View My Leave Requests");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" <!-- New button -->\r\n\r\n        </div>\r\n");
#nullable restore
#line 55 "C:\Users\91968\source\repos\Hostel-Management\Hostel-Management\Views\Student\Details.cshtml"

       
    }

#line default
#line hidden
#nullable disable

            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Hostel_Management.Models.Student> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591