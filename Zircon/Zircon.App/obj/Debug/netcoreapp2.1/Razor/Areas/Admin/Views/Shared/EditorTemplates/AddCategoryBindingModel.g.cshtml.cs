#pragma checksum "C:\Zircon\Zircon\Zircon.App\Areas\Admin\Views\Shared\EditorTemplates\AddCategoryBindingModel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a3ac0a3ec455062ddb9a810792d7721ce05486b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Zircon.App.Areas.Admin.Views.Shared.EditorTemplates.Areas_Admin_Views_Shared_EditorTemplates_AddCategoryBindingModel), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/EditorTemplates/AddCategoryBindingModel.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Shared/EditorTemplates/AddCategoryBindingModel.cshtml", typeof(Zircon.App.Areas.Admin.Views.Shared.EditorTemplates.Areas_Admin_Views_Shared_EditorTemplates_AddCategoryBindingModel))]
namespace Zircon.App.Areas.Admin.Views.Shared.EditorTemplates
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Zircon\Zircon\Zircon.App\Areas\Admin\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Zircon\Zircon\Zircon.App\Areas\Admin\_ViewImports.cshtml"
using Zircon.Models;

#line default
#line hidden
#line 3 "C:\Zircon\Zircon\Zircon.App\Areas\Admin\_ViewImports.cshtml"
using Zircon.Common.Admin.ViewModels;

#line default
#line hidden
#line 4 "C:\Zircon\Zircon\Zircon.App\Areas\Admin\_ViewImports.cshtml"
using Zircon.Common.Admin.BindingModels;

#line default
#line hidden
#line 5 "C:\Zircon\Zircon\Zircon.App\Areas\Admin\_ViewImports.cshtml"
using Zircon.Common.User.ViewModels;

#line default
#line hidden
#line 6 "C:\Zircon\Zircon\Zircon.App\Areas\Admin\_ViewImports.cshtml"
using Zircon.App.Helpers;

#line default
#line hidden
#line 7 "C:\Zircon\Zircon\Zircon.App\Areas\Admin\_ViewImports.cshtml"
using Zircon.App.Helpers.Messages;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a3ac0a3ec455062ddb9a810792d7721ce05486b", @"/Areas/Admin/Views/Shared/EditorTemplates/AddCategoryBindingModel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fca4c0aef5496b4fc3a874f200d7dcb8643f7d0", @"/Areas/Admin/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared_EditorTemplates_AddCategoryBindingModel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AddCategoryBindingModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Zircon\Zircon\Zircon.App\Areas\Admin\Views\Shared\EditorTemplates\AddCategoryBindingModel.cshtml"
  
    ViewData["Title"] = "AddCategoryBindingModel";

#line default
#line hidden
            BeginContext(94, 38, false);
#line 6 "C:\Zircon\Zircon\Zircon.App\Areas\Admin\Views\Shared\EditorTemplates\AddCategoryBindingModel.cshtml"
Write(Html.FormGroupFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(132, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AddCategoryBindingModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
