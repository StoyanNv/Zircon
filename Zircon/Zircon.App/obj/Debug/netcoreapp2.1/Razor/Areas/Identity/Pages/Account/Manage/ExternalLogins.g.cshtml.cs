#pragma checksum "C:\Zircon\Zircon\Zircon.App\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c4956ca26d0169105c489b0dd2b33a33d4831217"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Zircon.App.Areas.Identity.Pages.Account.Manage.Areas_Identity_Pages_Account_Manage_ExternalLogins), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/Manage/ExternalLogins.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Areas/Identity/Pages/Account/Manage/ExternalLogins.cshtml", typeof(Zircon.App.Areas.Identity.Pages.Account.Manage.Areas_Identity_Pages_Account_Manage_ExternalLogins), null)]
namespace Zircon.App.Areas.Identity.Pages.Account.Manage
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
#line 1 "C:\Zircon\Zircon\Zircon.App\Areas\Identity\Pages\Account\Manage\_ViewImports.cshtml"
using Zircon.App.Areas.Identity.Pages.Account.Manage;

#line default
#line hidden
#line 2 "C:\Zircon\Zircon\Zircon.App\Areas\Identity\Pages\Account\Manage\_ViewImports.cshtml"
using Zircon.Models;

#line default
#line hidden
#line 3 "C:\Zircon\Zircon\Zircon.App\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4956ca26d0169105c489b0dd2b33a33d4831217", @"/Areas/Identity/Pages/Account/Manage/ExternalLogins.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6e954bb5c71ecb9fcdcea31e9aa64658643e959", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1339bd83a431a97f03b3961876901b433f17f988", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9dba838c70bffc7a8efd2a359fb6776472ce98ec", @"/Areas/Identity/Pages/Account/Manage/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_Manage_ExternalLogins : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "LoginProvider", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "ProviderKey", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("remove-login"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "RemoveLogin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("link-login-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "LinkLogin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(81, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(118, 51, false);
#line 6 "C:\Zircon\Zircon\Zircon.App\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
Write(Html.Partial("_StatusMessage", Model.StatusMessage));

#line default
#line hidden
            EndContext();
            BeginContext(169, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "C:\Zircon\Zircon\Zircon.App\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
 if (Model.CurrentLogins?.Count > 0)
{

#line default
#line hidden
            BeginContext(212, 8, true);
            WriteLiteral("    <h4>");
            EndContext();
            BeginContext(221, 30, false);
#line 9 "C:\Zircon\Zircon\Zircon.App\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
   Write(Localizer["Registered Logins"]);

#line default
#line hidden
            EndContext();
            BeginContext(251, 52, true);
            WriteLiteral(" </h4>\r\n    <table class=\"table\">\r\n        <tbody>\r\n");
            EndContext();
#line 12 "C:\Zircon\Zircon\Zircon.App\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
             foreach (var login in Model.CurrentLogins)
            {

#line default
#line hidden
            BeginContext(375, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(422, 19, false);
#line 15 "C:\Zircon\Zircon\Zircon.App\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
                   Write(login.LoginProvider);

#line default
#line hidden
            EndContext();
            BeginContext(441, 33, true);
            WriteLiteral("</td>\r\n                    <td>\r\n");
            EndContext();
#line 17 "C:\Zircon\Zircon\Zircon.App\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
                         if (Model.ShowRemoveButton)
                        {

#line default
#line hidden
            BeginContext(555, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(583, 585, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "86945b9d45a640aea65619dbeac851b4", async() => {
                BeginContext(652, 77, true);
                WriteLiteral("\r\n                                <div>\r\n                                    ");
                EndContext();
                BeginContext(729, 75, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "67fd8640d86a42ec9ada56578de7860d", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 21 "C:\Zircon\Zircon\Zircon.App\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => login.LoginProvider);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(804, 38, true);
                WriteLiteral("\r\n                                    ");
                EndContext();
                BeginContext(842, 71, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1325abc5b49d43cba3ecae279387cec0", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 22 "C:\Zircon\Zircon\Zircon.App\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => login.ProviderKey);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(913, 83, true);
                WriteLiteral("\r\n                                    <button type=\"submit\" class=\"btn btn-default\"");
                EndContext();
                BeginWriteAttribute("title", " title=\"", 996, "\"", 1060, 7);
                WriteAttributeValue("", 1004, "Remove", 1004, 6, true);
                WriteAttributeValue(" ", 1010, "this", 1011, 5, true);
#line 23 "C:\Zircon\Zircon\Zircon.App\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
WriteAttributeValue(" ", 1015, login.LoginProvider, 1016, 20, false);

#line default
#line hidden
                WriteAttributeValue(" ", 1036, "login", 1037, 6, true);
                WriteAttributeValue(" ", 1042, "from", 1043, 5, true);
                WriteAttributeValue(" ", 1047, "your", 1048, 5, true);
                WriteAttributeValue(" ", 1052, "account", 1053, 8, true);
                EndWriteAttribute();
                BeginContext(1061, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(1063, 19, false);
#line 23 "C:\Zircon\Zircon\Zircon.App\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
                                                                                                                                              Write(Localizer["Remove"]);

#line default
#line hidden
                EndContext();
                BeginContext(1082, 79, true);
                WriteLiteral("</button>\r\n                                </div>\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1168, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 26 "C:\Zircon\Zircon\Zircon.App\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(1254, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(1284, 9, true);
            WriteLiteral(" &nbsp;\r\n");
            EndContext();
#line 30 "C:\Zircon\Zircon\Zircon.App\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
                        }

#line default
#line hidden
            BeginContext(1320, 50, true);
            WriteLiteral("                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 33 "C:\Zircon\Zircon\Zircon.App\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
            }

#line default
#line hidden
            BeginContext(1385, 32, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
            EndContext();
#line 36 "C:\Zircon\Zircon\Zircon.App\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
}

#line default
#line hidden
#line 37 "C:\Zircon\Zircon\Zircon.App\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
 if (Model.OtherLogins?.Count > 0)
{

#line default
#line hidden
            BeginContext(1459, 18, true);
            WriteLiteral("    <h4>\r\n        ");
            EndContext();
            BeginContext(1478, 43, false);
#line 40 "C:\Zircon\Zircon\Zircon.App\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
   Write(Localizer["Add another service to log in."]);

#line default
#line hidden
            EndContext();
            BeginContext(1521, 29, true);
            WriteLiteral("\r\n    </h4>\r\n    <hr />\r\n    ");
            EndContext();
            BeginContext(1550, 510, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0fe1eb045b5454eb8e77c2de3df484e", async() => {
                BeginContext(1644, 55, true);
                WriteLiteral("\r\n        <div id=\"socialLoginList\">\r\n            <p>\r\n");
                EndContext();
#line 46 "C:\Zircon\Zircon\Zircon.App\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
                 foreach (var provider in Model.OtherLogins)
                {

#line default
#line hidden
                BeginContext(1780, 104, true);
                WriteLiteral("                    <button id=\"link-login-button\" type=\"submit\" class=\"btn btn-default\" name=\"provider\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1884, "\"", 1906, 1);
#line 48 "C:\Zircon\Zircon\Zircon.App\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
WriteAttributeValue("", 1892, provider.Name, 1892, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("title", " title=\"", 1907, "\"", 1962, 6);
                WriteAttributeValue("", 1915, "Log", 1915, 3, true);
                WriteAttributeValue(" ", 1918, "in", 1919, 3, true);
                WriteAttributeValue(" ", 1921, "using", 1922, 6, true);
                WriteAttributeValue(" ", 1927, "your", 1928, 5, true);
#line 48 "C:\Zircon\Zircon\Zircon.App\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
WriteAttributeValue(" ", 1932, provider.DisplayName, 1933, 21, false);

#line default
#line hidden
                WriteAttributeValue(" ", 1954, "account", 1955, 8, true);
                EndWriteAttribute();
                BeginContext(1963, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(1965, 20, false);
#line 48 "C:\Zircon\Zircon\Zircon.App\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
                                                                                                                                                                                   Write(provider.DisplayName);

#line default
#line hidden
                EndContext();
                BeginContext(1985, 11, true);
                WriteLiteral("</button>\r\n");
                EndContext();
#line 49 "C:\Zircon\Zircon\Zircon.App\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
                }

#line default
#line hidden
                BeginContext(2015, 38, true);
                WriteLiteral("            </p>\r\n        </div>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2060, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 53 "C:\Zircon\Zircon\Zircon.App\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ExternalLoginsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ExternalLoginsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ExternalLoginsModel>)PageContext?.ViewData;
        public ExternalLoginsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
