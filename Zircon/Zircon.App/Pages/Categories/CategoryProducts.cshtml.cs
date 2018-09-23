namespace Zircon.App.Pages.Categories
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using Services.UserServices.Interfaces;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Zircon.Common.User.ViewModels;
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