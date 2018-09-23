namespace Zircon.Services.UserServices.Interfaces
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Common.User.ViewModels;

    public interface ICategoriesService
    {
        Task<IEnumerable<AllCategoriesViewModel>> GetCategoriesAsync();

        Task<IEnumerable<IndexProductsCardViewModel>> GetProductsAsync(int categoryId);

    }
}