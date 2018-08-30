using System.Collections.Generic;
using System.Threading.Tasks;
using Zircon.Common.User.ViewModels;
using Zircon.Models;

namespace Zircon.Services.UserServices.Interfaces
{
    public interface ICartProductService
    {
        Task<Product> GetProductsAsync(int productId);

        IEnumerable<ShopingCartViewModel> ConvertForShoppingCart(IEnumerable<Product> products);

        Task<int> AddOrderCardAsync(IEnumerable<Product> model, string userId, string giftCardCode);
    }
}