namespace Zircon.Services.UserServices.Interfaces
{
    using Common.User.BindingModels;
    using System.Threading.Tasks;

    public interface IUserAddressService
    {
        Task<AddAddressBindingModel> BindAddress(string userId);

        Task<string> AddOrUpdateAddress(string userId, AddAddressBindingModel model);
    }
}