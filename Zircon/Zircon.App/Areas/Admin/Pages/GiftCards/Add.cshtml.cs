namespace Zircon.App.Areas.Admin.Pages.GiftCards
{
    using Helpers.Messages;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using System.Threading.Tasks;
    using Zircon.Common.Admin.BindingModels;
    using Zircon.Services.Admin.Interfaces;

    [Area("Admin")]
    [Authorize(Roles = "Administrator")]
    public class AddModel : PageModel
    {
        private IAdminProductsService adminProductsService;

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
                this.TempData["__MessageText"] = $"You have entered invalid data.";
                return Page();
            }

            await this.adminProductsService.AddGiftCardAsync(this.AddGiftCardModel);
            this.TempData["__MessageType"] = MessageType.Success;
            this.TempData["__MessageText"] = $"Gift Card {this.AddGiftCardModel.Code} added successfully.";
            return RedirectToAction("Index", "Home");
        }
    }
}