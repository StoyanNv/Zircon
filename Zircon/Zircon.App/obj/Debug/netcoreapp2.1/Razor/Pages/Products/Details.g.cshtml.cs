#pragma checksum "D:\Zircon\Zircon\Zircon.App\Pages\Products\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c612a5c8283fdbc532d6e3a69d637588f893aff8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Products_Details), @"mvc.1.0.razor-page", @"/Pages/Products/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Products/Details.cshtml", typeof(AspNetCore.Pages_Products_Details), @"{id}")]
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
#line 1 "D:\Zircon\Zircon\Zircon.App\Pages\_ViewImports.cshtml"
using Zircon.Common.User.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c612a5c8283fdbc532d6e3a69d637588f893aff8", @"/Pages/Products/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4298ca1e92130d907df993ab5de90ed4ab9c0cdc", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Products_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-lg btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\Zircon\Zircon\Zircon.App\Pages\Products\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(104, 18, true);
            WriteLiteral("\r\n<h2>Details for ");
            EndContext();
            BeginContext(123, 16, false);
#line 7 "D:\Zircon\Zircon\Zircon.App\Pages\Products\Details.cshtml"
           Write(Model.Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(139, 90, true);
            WriteLiteral("</h2>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-3\">\r\n        <img style=\"max-width: 200px\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 229, "\"", 284, 1);
#line 11 "D:\Zircon\Zircon\Zircon.App\Pages\Products\Details.cshtml"
WriteAttributeValue("", 235, Html.DisplayFor(model => model.Model.PictureUrl), 235, 49, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 285, "\"", 350, 4);
            WriteAttributeValue("", 291, "Cover", 291, 5, true);
            WriteAttributeValue(" ", 296, "image", 297, 6, true);
            WriteAttributeValue(" ", 302, "for", 303, 4, true);
#line 11 "D:\Zircon\Zircon\Zircon.App\Pages\Products\Details.cshtml"
WriteAttributeValue(" ", 306, Html.DisplayFor(model => model.Model.Name), 307, 43, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(351, 60, true);
            WriteLiteral(" />\r\n    </div>\r\n    <div class=\"col-9\">\r\n        <h2>Name: ");
            EndContext();
            BeginContext(412, 42, false);
#line 14 "D:\Zircon\Zircon\Zircon.App\Pages\Products\Details.cshtml"
             Write(Html.DisplayFor(model => model.Model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(454, 29, true);
            WriteLiteral("</h2>\r\n        <h5>Category: ");
            EndContext();
            BeginContext(484, 46, false);
#line 15 "D:\Zircon\Zircon\Zircon.App\Pages\Products\Details.cshtml"
                 Write(Html.DisplayFor(model => model.Model.Category));

#line default
#line hidden
            EndContext();
            BeginContext(530, 26, true);
            WriteLiteral("</h5>\r\n        <h5>Price: ");
            EndContext();
            BeginContext(557, 43, false);
#line 16 "D:\Zircon\Zircon\Zircon.App\Pages\Products\Details.cshtml"
              Write(Html.DisplayFor(model => model.Model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(600, 19, true);
            WriteLiteral(" lv.</h5>\r\n        ");
            EndContext();
            BeginContext(619, 132, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b86e6cc50bfb4bcf8a366edd4d2b939a", async() => {
                BeginContext(736, 11, true);
                WriteLiteral("Add to card");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-productId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 17 "D:\Zircon\Zircon\Zircon.App\Pages\Products\Details.cshtml"
                                                                                                WriteLiteral(Model.Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-productId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(751, 20, true);
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Zircon.App.Pages.Products.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Zircon.App.Pages.Products.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Zircon.App.Pages.Products.DetailsModel>)PageContext?.ViewData;
        public Zircon.App.Pages.Products.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591