namespace Zircon.App.Controllers
{
    using Helpers;
    using Helpers.Messages;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Localization;
    using Services.UserServices.Interfaces;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Zircon.Common.Constrants;
    using Zircon.Models;

    public class CartController : Controller
    {
        private ICartProductService cartProductService;
        private UserManager<User> userManager;
        private IStringLocalizer<CartController> localizer;

        public CartController(
            ICartProductService cartProductService,
            UserManager<User> userManager,
            IStringLocalizer<CartController> localizer)
        {
            this.cartProductService = cartProductService;
            this.userManager = userManager;
            this.localizer = localizer;
        }

        public decimal TotalPrice { get; set; }
        public IActionResult Index()
        {
            var products = this.HttpContext.Session.Get<List<Product>>("cart");
            if (products == null)
            {
                products = new List<Product>();
            }

            this.ViewData["ProductsCount"] = products.Count;

            this.TotalPrice = products.Select(x => x.Price).Sum();
            this.ViewData["TotalPrice"] = this.TotalPrice;

            return View(cartProductService.ConvertForShoppingCart(products));
        }

        public async Task<IActionResult> AddToCart(int id)
        {
            var product = await cartProductService.GetProductsAsync(id);
            var products = this.HttpContext.Session.Get<List<Product>>("cart");
            if (products == null)
            {
                products = new List<Product>();
            }

            if (!products.Contains(products.FirstOrDefault(p => p.Id == id)))
            {
                products.Add(product);
            }
            else
            {
                this.TempData["__MessageType"] = MessageType.Warning;
                this.TempData["__MessageText"] = this.localizer[InfoConstants.ProductAlreadyAdded].ToString();
            }

            this.HttpContext.Session.Put("count", products.Count);
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
            if (products.Count == 0)
            {
                this.HttpContext.Session.Clear();
            }
            else
            {
                this.HttpContext.Session.Put("cart", products);
                this.HttpContext.Session.Put("count", products.Count);
            }
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
                        this.TempData["__MessageText"] = this.localizer[InfoConstants.MissingAddress].ToString();
                        return Redirect("/Identity/Account/Manage/AddAddress");
                    }
                    this.ViewData["orderId"] = order.Id;
                    this.ViewData["orderFinalPrice"] = order.FinalPrice;

                    this.HttpContext.Session.Clear();
                    return View();
                }
            }
            this.TempData["__MessageType"] = MessageType.Info;
            this.TempData["__MessageText"] = this.localizer[InfoConstants.EmptyCart].ToString();
            return RedirectToAction("Index");
        }
    }
}