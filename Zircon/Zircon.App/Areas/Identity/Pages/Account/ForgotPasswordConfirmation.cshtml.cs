namespace Zircon.App.Areas.Identity.Pages.Account
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using Zircon.Models;

    [AllowAnonymous]
    public class ForgotPasswordConfirmation : PageModel
    {
        private readonly SignInManager<User> signInManager;

        public ForgotPasswordConfirmation(SignInManager<User> signInManager)
        {
            this.signInManager = signInManager;
        }
        public void OnGet()
        {
            if (this.signInManager.IsSignedIn(User))
            {
                RedirectToAction("Index", "Home", new { area = "" });
            }
        }
    }
}
