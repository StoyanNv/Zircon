using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Zircon.Models;
using Zircon.Services.UserServices.Interfaces;

namespace Zircon.App.Areas.Admin.Controllers
{
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