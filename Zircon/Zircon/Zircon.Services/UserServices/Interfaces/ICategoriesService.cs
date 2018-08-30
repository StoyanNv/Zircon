using System.Collections.Generic;
using System.Threading.Tasks;
using Zircon.Common.User.ViewModels;

namespace Zircon.Services.UserServices.Interfaces
{
    public interface ICategoriesService
    {
        Task<IEnumerable<AllCategoriesViewModel>> GetCategoriesAsync();

        Task<IEnumerable<IndexProductsCardViewModel>> GetProductsAsync(int categoryId);

    }
}