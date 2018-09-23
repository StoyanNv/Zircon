namespace Zircon.App.Pages.Categories
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using Services.UserServices.Interfaces;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Zircon.Common.User.ViewModels;

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