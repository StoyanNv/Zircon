namespace Zircon.App.Areas.Identity.Pages.Account.Manage
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using System.Threading.Tasks;
    using Zircon.Common;
    using Zircon.Common.User.BindingModels;
    using Zircon.Models;
    using Zircon.Services.UserServices.Interfaces;

    [Authorize]
    public class AddAddress : PageModel
    {
        private readonly UserManager<User> userManager;
        private IUserAddressService userAddressService;
        public AddAddress(UserManager<User> userManager, IUserAddressService userAddressService)
        {
            this.userAddressService = userAddressService;
            this.userManager = userManager;
        }
        [TempData]
        public string StatusMessage { get; set; }
        [BindProperty]
        public AddAddressBindingModel Model { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            var user = await userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound(string.Format(Constants.ErrorMessages.UserNotFound, userManager.GetUserId(User)));
            }

            Model = await this.userAddressService.BindAddress(user.Id);

            return Page();
        }
        public async Task<IActionResult> OnPost()
        {
            var user = await userManager.GetUserAsync(User);

            if (user == null)
            {
                return NotFound(string.Format(Constants.ErrorMessages.UserNotFound, userManager.GetUserId(User)));
            }

            this.StatusMessage = await this.userAddressService.AddOrUpdateAddress(user.Id, Model);

            return RedirectToPage();
        }
    }
}
