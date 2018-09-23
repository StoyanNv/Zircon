namespace Zircon.Services.UserServices.Interfaces
{
    using Common.User.ViewModels;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IUserProductDetailsService
    {
        Task<ProductDetailsVIewModel> GetProductAsync(int id);
        Task<IEnumerable<IndexProductsCardViewModel>> GetProductsAsync();
    }
}