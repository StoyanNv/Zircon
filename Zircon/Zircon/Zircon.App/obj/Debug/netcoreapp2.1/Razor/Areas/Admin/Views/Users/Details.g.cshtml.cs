#pragma checksum "D:\Zircon\Zircon\Zircon.App\Areas\Admin\Views\Users\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00e5ed6c116293620382dc414bfc4073ea1fb443"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Zircon.App.Areas.Admin.Views.Users.Areas_Admin_Views_Users_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Users/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Users/Details.cshtml", typeof(Zircon.App.Areas.Admin.Views.Users.Areas_Admin_Views_Users_Details))]
namespace Zircon.App.Areas.Admin.Views.Users
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\Zircon\Zircon\Zircon.App\Areas\Admin\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "D:\Zircon\Zircon\Zircon.App\Areas\Admin\_ViewImports.cshtml"
using Zircon.Models;

#line default
#line hidden
#line 3 "D:\Zircon\Zircon\Zircon.App\Areas\Admin\_ViewImports.cshtml"
using Zircon.Common.Admin.ViewModels;

#line default
#line hidden
#line 4 "D:\Zircon\Zircon\Zircon.App\Areas\Admin\_ViewImports.cshtml"
using Zircon.Common.Admin.BindingModels;

#line default
#line hidden
#line 5 "D:\Zircon\Zircon\Zircon.App\Areas\Admin\_ViewImports.cshtml"
using Zircon.Common.User.ViewModels;

#line default
#line hidden
#line 6 "D:\Zircon\Zircon\Zircon.App\Areas\Admin\_ViewImports.cshtml"
using Zircon.App.Helpers;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00e5ed6c116293620382dc414bfc4073ea1fb443", @"/Areas/Admin/Views/Users/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68914136741d875bff7ecde6b9198009a4b13da9", @"/Areas/Admin/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Users_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserDetailsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Zircon\Zircon\Zircon.App\Areas\Admin\Views\Users\Details.cshtml"
  
    ViewData["Title"] = "Details for " + Model.Username;

#line default
#line hidden
            BeginContext(94, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(101, 17, false);
#line 6 "D:\Zircon\Zircon\Zircon.App\Areas\Admin\Views\Users\Details.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(118, 9, true);
            WriteLiteral("</h2>\r\n\r\n");
            EndContext();
            BeginContext(128, 22, false);
#line 8 "D:\Zircon\Zircon\Zircon.App\Areas\Admin\Views\Users\Details.cshtml"
Write(Html.DisplayForModel());

#line default
#line hidden
            EndContext();
            BeginContext(150, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
