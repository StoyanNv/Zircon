using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Zircon.Common.User.ViewModels;
using Zircon.Services.UserServices.Interfaces;

namespace Zircon.App.Pages.Products
{
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