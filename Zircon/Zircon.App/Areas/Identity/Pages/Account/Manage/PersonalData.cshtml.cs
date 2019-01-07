namespace Zircon.App.Areas.Identity.Pages.Account.Manage
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using Microsoft.Extensions.Localization;
    using Microsoft.Extensions.Logging;
    using System.Threading.Tasks;
    using Zircon.Common.Constrants;
    using Zircon.Models;

    public class PersonalDataModel : PageModel
    {
        private readonly UserManager<User> _userManager;
        private readonly ILogger<PersonalDataModel> _logger;
        private readonly IStringLocalizer<PersonalDataModel> localizer;


        public PersonalDataModel(
            UserManager<User> userManager,
            ILogger<PersonalDataModel> logger,
            IStringLocalizer<PersonalDataModel> localizer)
        {
            _userManager = userManager;
            _logger = logger;
            this.localizer = localizer;

        }

        public async Task<IActionResult> OnGet()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound(string.Format(this.localizer[ErrorConstants.UserNotFound], _userManager.GetUserId(User)));
            }

            return Page();
        }
    }
}