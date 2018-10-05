namespace Zircon.App.Areas.Identity.Pages.Account.Manage
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.UI.Services;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Threading.Tasks;
    using Zircon.Common;
    using Zircon.Models;
    using Zircon.Services.UserServices.Interfaces;

    public partial class IndexModel : PageModel
    {
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;
        private readonly IEmailSender emailSender;
        private readonly IChangeUserInfoService changeUserInfoService;
        public IndexModel(
            UserManager<User> userManager,
            SignInManager<User> signInManager,
            IEmailSender emailSender,
            IChangeUserInfoService changeUserInfoService)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.emailSender = emailSender;
            this.changeUserInfoService = changeUserInfoService;
        }

        public string Username { get; set; }

        public bool IsEmailConfirmed { get; set; }

        [TempData]
        public string StatusMessage { get; set; }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Phone]
            [Display(Name = "Phone number")]
            public string PhoneNumber { get; set; }

            public string Name { get; set; }

            public string Surname { get; set; }
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var user = await userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound(string.Format(Constants.ErrorMessages.UserNotFound, userManager.GetUserId(User)));
            }

            var userName = await userManager.GetUserNameAsync(user);
            var phoneNumber = await userManager.GetPhoneNumberAsync(user);
            var name = user.Name;
            var surname = user.Surname;
            Username = userName;

            Input = new InputModel
            {
                PhoneNumber = phoneNumber,
                Name = name,
                Surname = surname,
            };

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var user = await userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound(string.Format(Constants.ErrorMessages.UserNotFound, userManager.GetUserId(User)));
            }

            var phoneNumber = await userManager.GetPhoneNumberAsync(user);
            if (Input.PhoneNumber != phoneNumber)
            {
                var setPhoneResult = await userManager.SetPhoneNumberAsync(user, Input.PhoneNumber);
                if (!setPhoneResult.Succeeded)
                {
                    var userId = await userManager.GetUserIdAsync(user);

                    throw new InvalidOperationException(string.Format(Constants.ErrorMessages.SettingPhoneNumber, userId));
                }
            }
            var name = user.Name;
            if (Input.Name != name)
            {
                user.Name = name;
                await this.changeUserInfoService.ChangeNameAsync(Input.Name, user.Email);
            }
            var surname = user.Surname;

            if (Input.Surname != surname)
            {
                user.Surname = surname;
                await this.changeUserInfoService.ChangeSurnameAsync(Input.Surname, user.Email);
            }

            await signInManager.RefreshSignInAsync(user);
            StatusMessage = Constants.SuccessMessages.UpdateProfile;
            return RedirectToPage();
        }
    }
}
