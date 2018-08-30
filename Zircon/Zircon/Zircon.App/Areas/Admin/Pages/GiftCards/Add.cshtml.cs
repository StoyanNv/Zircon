using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Zircon.Common.Admin.BindingModels;
using Zircon.Services.Admin;
using Zircon.Services.Admin.Interfaces;

namespace Zircon.App.Areas.Admin.Pages.GiftCards
{
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
                return Page();
            }

            await this.adminProductsService.AddGiftCardAsync(this.AddGiftCardModel);

            return RedirectToAction("Index", "Home");
        }
    }
}