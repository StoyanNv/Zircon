namespace Zircon.Services.Admin.Interfaces
{
    using System.Threading.Tasks;
    using Zircon.Common.Admin.BindingModels;

    public interface IAdminProductsService
    {
        Task<int> AddProductAsync(AddProductBindingModel model);
        Task<AddProductBindingModel> GetProductAsync();
        Task AddCategoryAsync(AddCategoryBindingModel model);
        Task AddGiftCardAsync(AddGiftCardBindingModel model);
    }
}