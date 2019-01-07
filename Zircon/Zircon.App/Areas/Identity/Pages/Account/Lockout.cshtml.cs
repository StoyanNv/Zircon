namespace Zircon.App.Areas.Identity.Pages.Account
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using Zircon.Models;

    [AllowAnonymous]
    public class LockoutModel : PageModel
    {
        private readonly SignInManager<User> signInManager;

        public LockoutModel(SignInManager<User> signInManager)
        {
            this.signInManager = signInManager;
        }

        public IActionResult OnGet()
        {
            if (this.signInManager.IsSignedIn(User))
            {
                return RedirectToAction("Index", "Home", new { area = "" });
            }

            return Page();
        }
    }
}
