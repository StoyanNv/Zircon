namespace Zircon.App.Areas.Identity.Pages.Account
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using Microsoft.Extensions.Localization;
    using System;
    using System.Threading.Tasks;
    using Zircon.Common.Constrants;
    using Zircon.Models;

    [AllowAnonymous]
    public class ConfirmEmailModel : PageModel
    {
        private readonly UserManager<User> _userManager;
        private readonly IStringLocalizer<ConfirmEmailModel> localizer;

        public ConfirmEmailModel(UserManager<User> userManager,
            IStringLocalizer<ConfirmEmailModel> localizer)
        {
            _userManager = userManager;
            this.localizer = localizer;
        }

        public async Task<IActionResult> OnGetAsync(string userId, string code)
        {
            if (userId == null || code == null)
            {
                return RedirectToPage("Login");
            }

            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return NotFound(string.Format(this.localizer[ErrorConstants.UserNotFound], _userManager.GetUserId(User)));
            }

            var result = await _userManager.ConfirmEmailAsync(user, code);
            if (!result.Succeeded)
            {
                throw new InvalidOperationException(string.Format(this.localizer[ErrorConstants.ConfirmEmail], userId));
            }

            return Page();
        }
    }
}
