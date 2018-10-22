namespace Zircon.Services.UserServices.Interfaces
{
    using Common.User.ViewModels;
    using Models;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface ICartProductService
    {
        Task<Product> GetProductsAsync(int productId);

        IEnumerable<ShopingCartViewModel> ConvertForShoppingCart(IEnumerable<Product> products);

        Task<Order> FinishOrderAsync(IEnumerable<Product> model, string userId, string giftCardCode);

    }
}