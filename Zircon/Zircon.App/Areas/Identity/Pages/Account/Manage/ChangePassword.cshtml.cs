namespace Zircon.App.Areas.Identity.Pages.Account.Manage
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using Microsoft.Extensions.Localization;
    using Microsoft.Extensions.Logging;
    using System.ComponentModel.DataAnnotations;
    using System.Threading.Tasks;
    using Zircon.Common.Constrants;
    using Zircon.Models;

    public class ChangePasswordModel : PageModel
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly ILogger<ChangePasswordModel> _logger;
        private readonly IStringLocalizer<ChangePasswordModel> localizer;


        public ChangePasswordModel(
            UserManager<User> userManager,
            SignInManager<User> signInManager,
            ILogger<ChangePasswordModel> logger,
            IStringLocalizer<ChangePasswordModel> localizer)
        {
            this._userManager = userManager;
            this._signInManager = signInManager;
            this._logger = logger;
            this.localizer = localizer;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        [TempData]
        public string StatusMessage { get; set; }

        public class InputModel
        {
            [Required(ErrorMessage = ErrorConstants.RequiredField)]
            [DataType(DataType.Password)]
            [Display(Name = AttributeConstraintsConstants.CurrentPasswordDisplay)]
            public string OldPassword { get; set; }

            [Required(ErrorMessage = ErrorConstants.RequiredField)]
            [StringLength(100, ErrorMessage = ErrorConstants.PasswordLength, MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = AttributeConstraintsConstants.NewPasswordDisplay)]
            public string NewPassword { get; set; }

            [Required(ErrorMessage = ErrorConstants.RequiredField)]
            [DataType(DataType.Password)]
            [Display(Name = AttributeConstraintsConstants.ConfirmNewPasswordDisplay)]
            [Compare(AttributeConstraintsConstants.ChangePasswordCompareValue, ErrorMessage = ErrorConstants.PasswordsDoNotMatch)]
            public string ConfirmPassword { get; set; }
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound(string.Format(this.localizer[ErrorConstants.UserNotFound], _userManager.GetUserId(User)));
            }

            var hasPassword = await _userManager.HasPasswordAsync(user);
            if (!hasPassword)
            {
                return RedirectToPage("./SetPassword");
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound(string.Format(this.localizer[ErrorConstants.UserNotFound], _userManager.GetUserId(User)));
            }

            var changePasswordResult = await _userManager.ChangePasswordAsync(user, Input.OldPassword, Input.NewPassword);
            if (!changePasswordResult.Succeeded)
            {
                foreach (var error in changePasswordResult.Errors)
                {
                    ModelState.AddModelError(string.Empty, this.localizer[error.Description]);
                }
                return Page();
            }

            await _signInManager.RefreshSignInAsync(user);
            _logger.LogInformation(SuccessConstants.ChangePasswordLog);
            StatusMessage = this.localizer[SuccessConstants.ChangePassword].ToString();

            return RedirectToPage();
        }
    }
}