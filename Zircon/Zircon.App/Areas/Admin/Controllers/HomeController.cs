namespace Zircon.App.Areas.Admin.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Services.UserServices.Interfaces;
    using System.Threading.Tasks;

    public class HomeController : AdminController
    {
        private IUserProductDetailsService userProductDetails;

        public HomeController(IUserProductDetailsService userProductDetails)
        {
            this.userProductDetails = userProductDetails;
        }

        public async Task<IActionResult> Index()
        {
            var model = await userProductDetails.GetProductsAsync();

            return View(model);
        }
    }
}