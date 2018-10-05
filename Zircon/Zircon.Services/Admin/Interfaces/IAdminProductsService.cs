namespace Zircon.Services.Admin.Interfaces
{
    using System.Threading.Tasks;
    using Zircon.Common.Admin.BindingModels;

    public interface IAdminProductsService
    {
        Task<int> AddProductAsync(AddAndEditProductBindingModel model);
        Task<AddAndEditProductBindingModel> GetProductAsync();
        Task AddCategoryAsync(AddCategoryBindingModel model);
        Task AddGiftCardAsync(AddGiftCardBindingModel model);
        Task<AddAndEditProductBindingModel> GetEditProductDetailsAsync(int id);
        Task<int> EditProductAsync(AddAndEditProductBindingModel model);
        Task DeleteProductAsync(int id);
    }
}   