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
    public class CategoryProductsModel : PageModel
    {
        private ICategoriesService categoriesService;

        public CategoryProductsModel(ICategoriesService categoriesService)
        {
            this.categoriesService = categoriesService;
        }


        public IEnumerable<IndexProductsCardViewModel> AllProducts { get; set; }

        public async Task<IActionResult> OnGet(int id)
        {
            AllProducts = await categoriesService.GetProductsAsync(id);

            return Page();
        }
    }
}