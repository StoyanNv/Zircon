﻿namespace Zircon.App.Areas.Identity.Pages.Account
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.UI.Services;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using Microsoft.Extensions.Localization;
    using Microsoft.Extensions.Logging;
    using System.ComponentModel.DataAnnotations;
    using System.Security.Claims;
    using System.Text.Encodings.Web;
    using System.Threading.Tasks;
    using Zircon.Common.Constrants;
    using Zircon.Models;

    [AllowAnonymous]
    public class ExternalLoginModel : PageModel
    {
        private readonly SignInManager<User> signInManager;
        private readonly UserManager<User> userManager;
        private readonly ILogger<ExternalLoginModel> logger;
        private readonly IEmailSender emailSender;
        private readonly IStringLocalizer<ExternalLoginModel> localizer;

        public ExternalLoginModel(
            SignInManager<User> signInManager,
            UserManager<User> userManager,
            ILogger<ExternalLoginModel> logger,
            IEmailSender emailSender,
            IStringLocalizer<ExternalLoginModel> localizer)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
            this.logger = logger;
            this.emailSender = emailSender;
            this.localizer = localizer;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string LoginProvider { get; set; }

        public string ReturnUrl { get; set; }

        [TempData]
        public string ErrorMessage { get; set; }

        public string StatusMessage { get; set; }

        public class InputModel
        {
            [Display(Name = AttributeConstraintsConstants.NameDisplay)]
            [Required(ErrorMessage = ErrorConstants.RequiredField)]
            [MinLength(AttributeConstraintsConstants.NameMinLenght, ErrorMessage = ErrorConstants.FieldMinimumLength)]
            public string Name { get; set; }

            [Display(Name = AttributeConstraintsConstants.SurnameDisplay)]
            [Required(ErrorMessage = ErrorConstants.RequiredField)]
            [MinLength(AttributeConstraintsConstants.SurnameMinLenght, ErrorMessage = ErrorConstants.FieldMinimumLength)]
            public string Surname { get; set; }

            [Display(Name = AttributeConstraintsConstants.PhoneDisplay)]
            [RegularExpression(Constants.PhoneRegx, ErrorMessage = ErrorConstants.InvalidPhone)]
            [Required(ErrorMessage = ErrorConstants.RequiredField)]
            [MinLength(AttributeConstraintsConstants.PhoneMinLenght, ErrorMessage = ErrorConstants.FieldMinimumLength)]
            public string Phone { get; set; }

            [Display(Name = AttributeConstraintsConstants.EmailDisplay)]
            [Required(ErrorMessage = ErrorConstants.RequiredField)]
            [EmailAddress(ErrorMessage = ErrorConstants.InvalidEmail)]
            public string Email { get; set; }
        }

        public IActionResult OnGetAsync()
        {
            if (this.signInManager.IsSignedIn(User))
            {
                return RedirectToAction("Index", "Home", new { area = "" });
            }
            return RedirectToPage("./Login");
        }

        public IActionResult OnPost(string provider, string returnUrl = null)
        {
            if (this.signInManager.IsSignedIn(User))
            {
                return RedirectToAction("Index", "Home", new { area = "" });
            }
            // Request a redirect to the external login provider.
            var redirectUrl = Url.Page("./ExternalLogin", pageHandler: "Callback", values: new { returnUrl });
            var properties = signInManager.ConfigureExternalAuthenticationProperties(provider, redirectUrl);
            return new ChallengeResult(provider, properties);
        }

        public async Task<IActionResult> OnGetCallbackAsync(string returnUrl = null, string remoteError = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");
            if (remoteError != null)
            {
                ErrorMessage = string.Format(this.localizer[ErrorConstants.ExternalProvider], remoteError);
                return RedirectToPage("./Login", new { ReturnUrl = returnUrl });
            }
            var info = await signInManager.GetExternalLoginInfoAsync();
            if (info == null)
            {
                ErrorMessage = this.localizer[ErrorConstants.ExternalLoginInformation];
                return RedirectToPage("./Login", new { ReturnUrl = returnUrl });
            }

            // Sign in the user with this external login provider if the user already has a login.
            var result = await signInManager.ExternalLoginSignInAsync(info.LoginProvider, info.ProviderKey, isPersistent: false, bypassTwoFactor: true);
            if (result.Succeeded)
            {
                logger.LogInformation("{Name} logged in with {LoginProvider} provider.", info.Principal.Identity.Name, info.LoginProvider);
                return LocalRedirect(returnUrl);
            }
            if (result.IsLockedOut)
            {
                return RedirectToPage("./Lockout");
            }
            else
            {
                // If the user does not have an account, then ask the user to create an account.
                ReturnUrl = returnUrl;
                LoginProvider = info.LoginProvider;
                if (info.Principal.HasClaim(c => c.Type == ClaimTypes.Email))
                {
                    Input = new InputModel
                    {
                        Email = info.Principal.FindFirstValue(ClaimTypes.Email),
                    };
                }
                return Page();
            }
        }

        public async Task<IActionResult> OnPostConfirmationAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");
            // Get the information about the user from the external login provider
            var info = await signInManager.GetExternalLoginInfoAsync();
            if (info == null)
            {
                ErrorMessage = this.localizer[ErrorConstants.ExternalLoginInformationDuringConfirmation];
                return RedirectToPage("./Login", new { ReturnUrl = returnUrl });
            }

            if (ModelState.IsValid)
            {
                var user = new User
                {
                    UserName = Input.Email,
                    Email = Input.Email,
                    PhoneNumber = Input.Phone,
                    Name = Input.Name,
                    Surname = Input.Surname
                };
                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    result = await userManager.AddLoginAsync(user, info);
                    if (result.Succeeded)
                    {
                        var code = await userManager.GenerateEmailConfirmationTokenAsync(user);
                        var callbackUrl = Url.Page(
                            "/Account/ConfirmEmail",
                            pageHandler: null,
                            values: new { userId = user.Id, code = code },
                            protocol: Request.Scheme);

                        await emailSender.SendEmailAsync(Input.Email, "Confirm your email",
                            $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                        StatusMessage = this.localizer[SuccessConstants.VerificationEmailSent];
                    }
                }
                foreach (var error in result.Errors)
                {
                    if (error.Code == "DuplicateUserName")
                    {
                        ModelState.AddModelError(string.Empty, string.Format(this.localizer[ErrorConstants.UserAlreadyExists], Input.Email));
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }

            LoginProvider = info.LoginProvider;
            ReturnUrl = returnUrl;
            return Page();
        }
    }
}
