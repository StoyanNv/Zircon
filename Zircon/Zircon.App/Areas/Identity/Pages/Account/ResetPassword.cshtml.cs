namespace Zircon.App.Areas.Identity.Pages.Account
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using Microsoft.Extensions.Localization;
    using System.ComponentModel.DataAnnotations;
    using System.Threading.Tasks;
    using Zircon.Common.Constrants;
    using Zircon.Models;

    [AllowAnonymous]
    public class ResetPasswordModel : PageModel
    {
        private readonly UserManager<User> _userManager;
        private readonly IStringLocalizer<ResetPasswordModel> localizer;

        public ResetPasswordModel(UserManager<User> userManager,
            IStringLocalizer<ResetPasswordModel> localizer)
        {
            _userManager = userManager;
            this.localizer = localizer;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Display(Name = AttributeConstraintsConstants.EmailDisplay)]
            [Required(ErrorMessage = ErrorConstants.RequiredField)]
            [EmailAddress(ErrorMessage = ErrorConstants.InvalidEmail)]
            public string Email { get; set; }

            [Display(Name = AttributeConstraintsConstants.PasswordDisplay)]
            [Required(ErrorMessage = ErrorConstants.RequiredField)]
            [StringLength(AttributeConstraintsConstants.PasswordMaxLenght,
                ErrorMessage = ErrorConstants.PasswordLength,
                MinimumLength = AttributeConstraintsConstants.PasswordMinLenght)]
            [DataType(DataType.Password)]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = AttributeConstraintsConstants.ConfirmPasswordDisplay)]
            [Compare(AttributeConstraintsConstants.PasswordCompareValue, ErrorMessage = ErrorConstants.PasswordsDoNotMatch)]
            public string ConfirmPassword { get; set; }

            public string Code { get; set; }
        }

        public IActionResult OnGet(string code = null)
        {
            if (code == null)
            {
                return BadRequest(ErrorConstants.ResetPasswordCodeMustBeSupplied);
            }
            else
            {
                Input = new InputModel
                {
                    Code = code
                };
                return Page();
            }
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var user = await _userManager.FindByEmailAsync(Input.Email);
            if (user == null)
            {
                // Don't reveal that the user does not exist
                return RedirectToPage("./ResetPasswordConfirmation");
            }

            var result = await _userManager.ResetPasswordAsync(user, Input.Code, Input.Password);
            if (result.Succeeded)
            {
                return RedirectToPage("./ResetPasswordConfirmation");
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, this.localizer[error.Description]);
            }
            return Page();
        }
    }
}
