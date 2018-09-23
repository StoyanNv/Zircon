namespace Zircon.App.Pages.Products
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using Services.UserServices.Interfaces;
    using System.Threading.Tasks;
    using Zircon.Common.User.ViewModels;

    public class DetailsModel : PageModel
    {
        private IUserProductDetailsService productDetails;

        public DetailsModel(IUserProductDetailsService productDetails)
        {
            this.productDetails = productDetails;
        }
        [BindProperty]
        public ProductDetailsVIewModel Model { get; set; }
        public async Task<IActionResult> OnGet(int id)
        {
            this.Model = await productDetails.GetProductAsync(id);
            if (Model == null)
            {
                return NotFound();
            }

            return Page();
        }
    }
}