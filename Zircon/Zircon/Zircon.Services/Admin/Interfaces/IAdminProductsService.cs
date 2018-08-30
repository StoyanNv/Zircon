using System.Threading.Tasks;
using Zircon.Common.Admin.BindingModels;

namespace Zircon.Services.Admin.Interfaces
{
    public interface IAdminProductsService
    {
        Task<int> AddProductAsync(AddProductBindingModel model);
        Task<AddProductBindingModel> GetProductAsync();
        Task AddCategoryAsync(AddCategoryBindingModel model);
        Task AddGiftCardAsync(AddGiftCardBindingModel model);
    }
}