using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Zircon.Common.User.ViewModels;
using Zircon.Services.UserServices.Interfaces;

namespace Zircon.App.Pages.Categories
{
    public class AllModel : PageModel
    {
        private ICategoriesService categoriesService;

        public AllModel(ICategoriesService categoriesService)
        {
            this.categoriesService = categoriesService;
        }
        [BindProperty]
        public IEnumerable<AllCategoriesViewModel> AllCategories { get; set; }

        public async Task<IActionResult> OnGet()
        {
            AllCategories = await categoriesService.GetCategoriesAsync();
            return Page();
        }
    }
}