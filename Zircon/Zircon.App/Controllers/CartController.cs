namespace Zircon.App.Controllers
{
    using Helpers;
    using Helpers.Messages;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Services.UserServices.Interfaces;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Zircon.Models;

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
                this.TempData["__MessageType"] = MessageType.Warning;
                this.TempData["__MessageText"] = $"Product already added.";
            }
            this.HttpContext.Session.Put("cart", products);
            return RedirectToAction("Index");
        }
        public IActionResult RemoveFromCart(int productId)
        {
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
                if (products.Count != 0)
                {
                    var id = userManager.GetUserId(User);
                    var order = await this.cartProductService.FinishOrderAsync(products, id, giftCard);
                    if (order == null)
                    {
                        this.TempData["__MessageType"] = MessageType.Info;
                        this.TempData["__MessageText"] = $"You should add an address before completing your order.";
                        return Redirect("/Identity/Account/Manage/AddAddress");
                    }
                    this.ViewData["orderId"] = order.Id;
                    this.ViewData["orderFinalPrice"] = order.FinalPrice;

                    this.HttpContext.Session.Clear();
                    return View();
                }
            }
            this.TempData["__MessageType"] = MessageType.Info;
            this.TempData["__MessageText"] = $"Cart is empty";
            return RedirectToAction("Index");
        }
    }
}