#pragma checksum "C:\Zircon\Zircon\Zircon.App\Areas\Admin\Views\Shared\DisplayTemplates\IndexProductsCardViewModel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00ba5ed1293d3ccf6d333eabaab386b641b18a58"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Zircon.App.Areas.Admin.Views.Shared.DisplayTemplates.Areas_Admin_Views_Shared_DisplayTemplates_IndexProductsCardViewModel), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/DisplayTemplates/IndexProductsCardViewModel.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Shared/DisplayTemplates/IndexProductsCardViewModel.cshtml", typeof(Zircon.App.Areas.Admin.Views.Shared.DisplayTemplates.Areas_Admin_Views_Shared_DisplayTemplates_IndexProductsCardViewModel))]
namespace Zircon.App.Areas.Admin.Views.Shared.DisplayTemplates
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
#line 2 "C:\Zircon\Zircon\Zircon.App\Areas\Admin\Views\Shared\DisplayTemplates\IndexProductsCardViewModel.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00ba5ed1293d3ccf6d333eabaab386b641b18a58", @"/Areas/Admin/Views/Shared/DisplayTemplates/IndexProductsCardViewModel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fca4c0aef5496b4fc3a874f200d7dcb8643f7d0", @"/Areas/Admin/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared_DisplayTemplates_IndexProductsCardViewModel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IndexProductsCardViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/products/details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(81, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(117, 132, true);
            WriteLiteral("<div class=\"col-sm-4\" style=\"padding-bottom: 20px\">\r\n    <div class=\"card\" style=\"width: 18rem;\">\r\n        <img class=\"card-img-top\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 249, "\"", 272, 1);
#line 7 "C:\Zircon\Zircon\Zircon.App\Areas\Admin\Views\Shared\DisplayTemplates\IndexProductsCardViewModel.cshtml"
WriteAttributeValue("", 255, Model.PictureUrl, 255, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 273, "\"", 290, 1);
#line 7 "C:\Zircon\Zircon\Zircon.App\Areas\Admin\Views\Shared\DisplayTemplates\IndexProductsCardViewModel.cshtml"
WriteAttributeValue("", 279, Model.Name, 279, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(291, 71, true);
            WriteLiteral(">\r\n        <div class=\"card-body\">\r\n            <h5 class=\"card-title\">");
            EndContext();
            BeginContext(363, 10, false);
#line 9 "C:\Zircon\Zircon\Zircon.App\Areas\Admin\Views\Shared\DisplayTemplates\IndexProductsCardViewModel.cshtml"
                              Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(373, 40, true);
            WriteLiteral("</h5>\r\n            <p class=\"card-text\">");
            EndContext();
            BeginContext(414, 11, false);
#line 10 "C:\Zircon\Zircon\Zircon.App\Areas\Admin\Views\Shared\DisplayTemplates\IndexProductsCardViewModel.cshtml"
                            Write(Model.Price);

#line default
#line hidden
            EndContext();
            BeginContext(425, 43, true);
            WriteLiteral(" Lv.</p>\r\n            <p class=\"card-text\">");
            EndContext();
            BeginContext(469, 14, false);
#line 11 "C:\Zircon\Zircon\Zircon.App\Areas\Admin\Views\Shared\DisplayTemplates\IndexProductsCardViewModel.cshtml"
                            Write(Model.Category);

#line default
#line hidden
            EndContext();
            BeginContext(483, 18, true);
            WriteLiteral("</p>\r\n            ");
            EndContext();
            BeginContext(501, 106, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d234cb40841943eb9a734fd44360940f", async() => {
                BeginContext(583, 20, false);
#line 12 "C:\Zircon\Zircon\Zircon.App\Areas\Admin\Views\Shared\DisplayTemplates\IndexProductsCardViewModel.cshtml"
                                                                                        Write(Localizer["Details"]);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 12 "C:\Zircon\Zircon\Zircon.App\Areas\Admin\Views\Shared\DisplayTemplates\IndexProductsCardViewModel.cshtml"
                                              WriteLiteral(Model.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(607, 36, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexProductsCardViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
