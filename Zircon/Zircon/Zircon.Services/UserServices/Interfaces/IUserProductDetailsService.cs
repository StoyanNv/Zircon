using System.Collections.Generic;
using System.Threading.Tasks;
using Zircon.Common.User.ViewModels;

namespace Zircon.Services.UserServices.Interfaces
{
    public interface IUserProductDetailsService
    {
        Task<ProductDetailsVIewModel> GetProductAsync(int id);
        Task<IEnumerable<IndexProductsCardViewModel>> GetProductsAsync();
    }
}