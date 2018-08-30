using System.Collections.Generic;
using System.Threading.Tasks;
using Zircon.Common.Admin.ViewModels;

namespace Zircon.Services.Admin.Interfaces
{
    public interface IAdminUsersService
    {
        Task<IEnumerable<UserConciseViewModel>> GetUsersAsync(string adminId);
        Task<UserDetailsViewModel> GetUserDetailsAsync(string id);
    }
}