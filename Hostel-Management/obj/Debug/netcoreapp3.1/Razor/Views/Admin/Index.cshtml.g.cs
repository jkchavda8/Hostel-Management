#pragma checksum "C:\Users\91968\source\repos\Hostel-Management\Hostel-Management\Views\Admin\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "b9297e17012cf32dd7766c1f6a265a12d2120ff499712550e4ab15750592ad2b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"b9297e17012cf32dd7766c1f6a265a12d2120ff499712550e4ab15750592ad2b", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"3d84ada461010a5469a3215ed99c38fa090d628e64bef56d2e4873ccb03de438", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\91968\source\repos\Hostel-Management\Hostel-Management\Views\Admin\Index.cshtml"
  
    ViewData["Title"] = "Admin Dashboard";

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n<h2>Admin Dashboard</h2>\r\n\r\n<div class=\"admin-dashboard\">\r\n    <div class=\"row\">\r\n        <!-- Button for Room Management -->\r\n        <div class=\"col-md-4\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 226, "\"", 261, 1);
            WriteAttributeValue("", 233, 
#nullable restore
#line 11 "C:\Users\91968\source\repos\Hostel-Management\Hostel-Management\Views\Admin\Index.cshtml"
                      Url.Action("Index", "Room")

#line default
#line hidden
#nullable disable
            , 233, 28, false);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary btn-lg btn-block\">\r\n                Manage Rooms\r\n            </a>\r\n        </div>\r\n\r\n        <!-- Button for Student Management -->\r\n        <div class=\"col-md-4\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 466, "\"", 504, 1);
            WriteAttributeValue("", 473, 
#nullable restore
#line 18 "C:\Users\91968\source\repos\Hostel-Management\Hostel-Management\Views\Admin\Index.cshtml"
                      Url.Action("Index", "Student")

#line default
#line hidden
#nullable disable
            , 473, 31, false);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success btn-lg btn-block\">\r\n                Manage Students\r\n            </a>\r\n        </div>\r\n\r\n        <!-- Button for Leave Management -->\r\n        <div class=\"col-md-4\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 710, "\"", 753, 1);
            WriteAttributeValue("", 717, 
#nullable restore
#line 25 "C:\Users\91968\source\repos\Hostel-Management\Hostel-Management\Views\Admin\Index.cshtml"
                      Url.Action("Index", "LeaveRequest")

#line default
#line hidden
#nullable disable
            , 717, 36, false);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-info btn-lg btn-block"">
                Manage Leave Details
            </a>
        </div>
    </div>
</div>

<!-- Optional styling -->
<style>
    .admin-dashboard {
        margin-top: 30px;
    }

        .admin-dashboard .btn {
            margin-bottom: 20px;
            padding: 20px;
            font-size: 18px;
        }
</style>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
