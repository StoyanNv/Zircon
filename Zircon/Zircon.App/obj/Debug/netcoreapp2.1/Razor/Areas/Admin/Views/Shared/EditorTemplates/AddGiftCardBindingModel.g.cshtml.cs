#pragma checksum "C:\Zircon\Zircon\Zircon.App\Areas\Admin\Views\Shared\EditorTemplates\AddGiftCardBindingModel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e28fe517bbfd8cc48a7e08876ea3ede622babc65"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Zircon.App.Areas.Admin.Views.Shared.EditorTemplates.Areas_Admin_Views_Shared_EditorTemplates_AddGiftCardBindingModel), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/EditorTemplates/AddGiftCardBindingModel.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Shared/EditorTemplates/AddGiftCardBindingModel.cshtml", typeof(Zircon.App.Areas.Admin.Views.Shared.EditorTemplates.Areas_Admin_Views_Shared_EditorTemplates_AddGiftCardBindingModel))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e28fe517bbfd8cc48a7e08876ea3ede622babc65", @"/Areas/Admin/Views/Shared/EditorTemplates/AddGiftCardBindingModel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fca4c0aef5496b4fc3a874f200d7dcb8643f7d0", @"/Areas/Admin/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared_EditorTemplates_AddGiftCardBindingModel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AddGiftCardBindingModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn bg-warning btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Zircon\Zircon\Zircon.App\Areas\Admin\Views\Shared\EditorTemplates\AddGiftCardBindingModel.cshtml"
  
    ViewData["Title"] = "AddGiftCardBindingModel";

#line default
#line hidden
            BeginContext(91, 423, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "578c757129664333b7f630fe2c745e1d", async() => {
                BeginContext(111, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(118, 38, false);
#line 6 "C:\Zircon\Zircon\Zircon.App\Areas\Admin\Views\Shared\EditorTemplates\AddGiftCardBindingModel.cshtml"
Write(Html.FormGroupFor(model => model.Code));

#line default
#line hidden
                EndContext();
                BeginContext(156, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(163, 42, false);
#line 7 "C:\Zircon\Zircon\Zircon.App\Areas\Admin\Views\Shared\EditorTemplates\AddGiftCardBindingModel.cshtml"
Write(Html.FormGroupFor(model => model.Discount));

#line default
#line hidden
                EndContext();
                BeginContext(205, 166, true);
                WriteLiteral("\r\n    <div class=\"form-group\">\r\n        <div class=\"col-sm-10 col-sm-push-2\">\r\n            <input type=\"submit\" value=\"Create\" class=\"btn btn-success\"/>\r\n            ");
                EndContext();
                BeginContext(371, 106, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f037c5a101cf4dd292ffa5711e76933f", async() => {
                    BeginContext(467, 6, true);
                    WriteLiteral("Cancel");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
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
                EndContext();
                BeginContext(477, 30, true);
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AddGiftCardBindingModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
