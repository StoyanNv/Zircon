namespace Zircon.App.Areas.Admin.Pages.GiftCards
{
    using Helpers.Messages;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using System.Threading.Tasks;
    using Zircon.Common;
    using Zircon.Common.Admin.BindingModels;
    using Zircon.Services.Admin.Interfaces;

    [Area(Constants.AttributeConstraint.AdminArea)]
    [Authorize(Roles = Constants.AttributeConstraint.AdminRole)]
    public class AddModel : PageModel
    {
        private readonly IAdminProductsService adminProductsService;

        public AddModel(IAdminProductsService adminProductsService)
        {
            this.adminProductsService = adminProductsService;
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
                this.TempData["__MessageText"] = Constants.ErrorMessages.InvalidFormData;
                return Page();
            }

            await this.adminProductsService.AddGiftCardAsync(this.AddGiftCardModel);
            this.TempData["__MessageType"] = MessageType.Success;
            this.TempData["__MessageText"] = string.Format(Constants.SuccessMessages.GiftCardAdded, this.AddGiftCardModel.Code);
            return RedirectToAction("Index", "Home");
        }
    }
}