using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Zircon.App.Models;
using Zircon.Services.UserServices.Interfaces;

namespace Zircon.App.Controllers
{
    public class HomeController : Controller
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

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
