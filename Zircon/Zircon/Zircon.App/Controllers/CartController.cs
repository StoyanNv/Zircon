using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Zircon.App.Helpers;
using Zircon.Models;
using Zircon.Services.UserServices.Interfaces;

namespace Zircon.App.Controllers
{
    public class CartController : Controller
    {
        private ICartProductService cartProductService;
        private UserManager<User> userManager;

        public CartController(
            ICartProductService cartProductService,
            UserManager<User> userManager)
        {
            this.cartProductService = cartProductService;
            this.userManager = userManager;
        }

        public decimal TotalPrice { get; set; }
        public IActionResult Index()
        {
            var products = this.HttpContext.Session.Get<List<Product>>("cart");
            if (products == null)
            {
                products = new List<Product>();
            }

            this.TotalPrice = products.Select(x => x.Price).Sum();
            this.ViewData["TotalPrice"] = this.TotalPrice;
            return View(cartProductService.ConvertForShoppingCart(products));
        }

        public async Task<IActionResult> AddToCart(int productId)
        {
            var product = await cartProductService.GetProductsAsync(productId);
            var products = this.HttpContext.Session.Get<List<Product>>("cart");
            if (products == null)
            {
                products = new List<Product>();
            }

            if (!products.Contains(products.FirstOrDefault(p => p.Id == productId)))
            {
                products.Add(product);
            }
            else
            {
                //todo: product already addet
            }
            this.HttpContext.Session.Put("cart", products);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> RemoveFromCart(int productId)
        {
            var product = await cartProductService.GetProductsAsync(productId);
            var products = this.HttpContext.Session.Get<List<Product>>("cart");
            if (products == null)
            {
                products = new List<Product>();
            }

            products.Remove(products.FirstOrDefault(p => p.Id == productId));
            this.HttpContext.Session.Put("cart", products);
            return RedirectToAction("Index");
        }
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> FinishOrder(string giftCardCode)
        {
            var giftCard = Request.Form["giftCard"];
            var products = this.HttpContext.Session.Get<List<Product>>("cart");
            if (products != null)
            {
                var id = userManager.GetUserId(User);
                var orderId = await this.cartProductService.AddOrderCardAsync(products, id, giftCard);
                if (orderId == -1)
                {
                    //TODO:ADD ADDRESS MESSAGE
                   return Redirect("/Identity/Account/Manage/AddAddress");
                }
                this.ViewData["orderId"] = orderId;
                this.HttpContext.Session.Clear();
                return View();
            }
            //TODO: Empty cart message
            return RedirectToAction("Index");
        }
    }
}