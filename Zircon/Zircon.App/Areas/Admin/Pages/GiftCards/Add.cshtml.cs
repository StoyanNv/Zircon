namespace Zircon.App.Areas.Admin.Pages.GiftCards
{
    using Helpers.Messages;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using System.Threading.Tasks;
    using Zircon.Common.Constrants;
    using Zircon.Common.Admin.BindingModels;
    using Zircon.Services.Admin.Interfaces;
    using Microsoft.Extensions.Localization;

    [Area(AttributeConstraintsConstants.AdminArea)]
    [Authorize(Roles = AttributeConstraintsConstants.AdminRole)]
    public class AddModel : PageModel
    {
        private readonly IAdminProductsService adminProductsService;
        private readonly IStringLocalizer<AddModel> localizer;


        public AddModel(IAdminProductsService adminProductsService,
            IStringLocalizer<AddModel> localizer)
        {
            this.adminProductsService = adminProductsService;
            this.localizer = localizer;

        }

        [BindProperty]
        public AddGiftCardBindingModel AddGiftCardModel { get; set; }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
            {
                this.TempData["__MessageType"] = MessageType.Warning;
                this.TempData["__MessageText"] = this.localizer[ErrorConstants.InvalidFormData];
                return Page();
            }

            await this.adminProductsService.AddGiftCardAsync(this.AddGiftCardModel);
            this.TempData["__MessageType"] = MessageType.Success;
            this.TempData["__MessageText"] = string.Format(this.localizer[SuccessConstants.GiftCardAdded], this.AddGiftCardModel.Code);
            return RedirectToAction("Index", "Home");
        }
    }
}