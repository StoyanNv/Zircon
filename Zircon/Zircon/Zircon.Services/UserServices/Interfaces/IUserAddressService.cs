using System.Threading.Tasks;
using Zircon.Common.User.BindingModels;

namespace Zircon.Services.UserServices.Interfaces
{
    public interface IUserAddressService
    {
        Task<AddAddressBindingModel> BindAddress(string userId);

        Task<string> AddOrUpdateAddress(string userId, AddAddressBindingModel model);
    }
}