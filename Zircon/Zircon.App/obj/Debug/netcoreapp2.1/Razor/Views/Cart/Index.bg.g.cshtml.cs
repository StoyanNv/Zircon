#pragma checksum "C:\Zircon\Zircon\Zircon.App\Views\Cart\Index.bg.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3474e878951cbc5e2278b59c90b7fdd143c2762e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index_bg), @"mvc.1.0.view", @"/Views/Cart/Index.bg.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cart/Index.bg.cshtml", typeof(AspNetCore.Views_Cart_Index_bg))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Zircon\Zircon\Zircon.App\Views\_ViewImports.cshtml"
using Zircon.App;

#line default
#line hidden
#line 2 "C:\Zircon\Zircon\Zircon.App\Views\_ViewImports.cshtml"
using Zircon.App.Models;

#line default
#line hidden
#line 3 "C:\Zircon\Zircon\Zircon.App\Views\_ViewImports.cshtml"
using Zircon.Models;

#line default
#line hidden
#line 4 "C:\Zircon\Zircon\Zircon.App\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 5 "C:\Zircon\Zircon\Zircon.App\Views\_ViewImports.cshtml"
using Zircon.Common.User.ViewModels;

#line default
#line hidden
#line 6 "C:\Zircon\Zircon\Zircon.App\Views\_ViewImports.cshtml"
using Zircon.App.Helpers.Messages;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3474e878951cbc5e2278b59c90b7fdd143c2762e", @"/Views/Cart/Index.bg.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a450d18698ec2f1a7cc056bdb4d8be95b7fff6a", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Index_bg : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ShopingCartViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "FinishOrder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Zircon\Zircon\Zircon.App\Views\Cart\Index.bg.cshtml"
  
    ViewData["Title"] = "Кошница";

#line default
#line hidden
            BeginContext(85, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(92, 17, false);
#line 6 "C:\Zircon\Zircon\Zircon.App\Views\Cart\Index.bg.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(109, 183, true);
            WriteLiteral("</h2>\r\n\r\n<table class=\"table table-striped\">\r\n    <thead>\r\n    <tr>\r\n        <td>Име</td>\r\n        <td>Цена</td>\r\n        <td>Премахни</td>\r\n    </tr>\r\n    </thead>\r\n    <tbody>\r\n    ");
            EndContext();
            BeginContext(293, 22, false);
#line 17 "C:\Zircon\Zircon\Zircon.App\Views\Cart\Index.bg.cshtml"
Write(Html.DisplayForModel());

#line default
#line hidden
            EndContext();
            BeginContext(315, 41, true);
            WriteLiteral("\r\n    </tbody>\r\n</table>\r\n<p>\r\n    Общо: ");
            EndContext();
            BeginContext(357, 22, false);
#line 21 "C:\Zircon\Zircon\Zircon.App\Views\Cart\Index.bg.cshtml"
     Write(ViewData["TotalPrice"]);

#line default
#line hidden
            EndContext();
            BeginContext(379, 14, true);
            WriteLiteral(" Лв.\r\n</p>\r\n\r\n");
            EndContext();
            BeginContext(393, 392, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ee4115fe37c49a5876c2f523629d3b3", async() => {
                BeginContext(460, 318, true);
                WriteLiteral(@"
    <div class=""form-inline"">
        <label for=""giftCard"">Код за намаление:</label>
        &nbsp;
        <input class=""form-control"" id=""giftCard"" name=""giftCard"" type=""Text"" />
    </div>
    <div class=""text-right"">
        <input type=""submit"" value=""Поръчай"" class=""btn-lg btn-success"" />
    </div>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(785, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ShopingCartViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591