#pragma checksum "C:\Zircon\Zircon\Zircon.App\Areas\Identity\Pages\Account\AccessDenied.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe47db71b46cf135594cd999847b96e9cf996b57"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Zircon.App.Areas.Identity.Pages.Account.Areas_Identity_Pages_Account_AccessDenied), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/AccessDenied.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Areas/Identity/Pages/Account/AccessDenied.cshtml", typeof(Zircon.App.Areas.Identity.Pages.Account.Areas_Identity_Pages_Account_AccessDenied), null)]
namespace Zircon.App.Areas.Identity.Pages.Account
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Zircon\Zircon\Zircon.App\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Zircon\Zircon\Zircon.App\Areas\Identity\Pages\_ViewImports.cshtml"
using Zircon.App.Areas.Identity;

#line default
#line hidden
#line 1 "C:\Zircon\Zircon\Zircon.App\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using Zircon.App.Areas.Identity.Pages.Account;

#line default
#line hidden
#line 6 "C:\Zircon\Zircon\Zircon.App\Areas\Identity\Pages\Account\AccessDenied.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe47db71b46cf135594cd999847b96e9cf996b57", @"/Areas/Identity/Pages/Account/AccessDenied.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6e954bb5c71ecb9fcdcea31e9aa64658643e959", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1339bd83a431a97f03b3961876901b433f17f988", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_AccessDenied : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Zircon\Zircon\Zircon.App\Areas\Identity\Pages\Account\AccessDenied.cshtml"
  
    ViewData["Title"] = Localizer["Access denied"];

#line default
#line hidden
            BeginContext(139, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(175, 38, true);
            WriteLiteral("<header>\r\n    <h1 class=\"text-danger\">");
            EndContext();
            BeginContext(214, 17, false);
#line 10 "C:\Zircon\Zircon\Zircon.App\Areas\Identity\Pages\Account\AccessDenied.cshtml"
                       Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(231, 34, true);
            WriteLiteral("</h1>\r\n    <p class=\"text-danger\">");
            EndContext();
            BeginContext(266, 53, false);
#line 11 "C:\Zircon\Zircon\Zircon.App\Areas\Identity\Pages\Account\AccessDenied.cshtml"
                      Write(Localizer["You do not have access to this resource."]);

#line default
#line hidden
            EndContext();
            BeginContext(319, 17, true);
            WriteLiteral("</p>\r\n</header>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AccessDeniedModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AccessDeniedModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AccessDeniedModel>)PageContext?.ViewData;
        public AccessDeniedModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
