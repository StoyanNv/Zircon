namespace Zircon.Services.Admin.Interfaces
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Zircon.Common.Admin.ViewModels;

    public interface IAdminUsersService
    {
        Task<IEnumerable<UserConciseViewModel>> GetUsersAsync(string adminId);
        Task<UserDetailsViewModel> GetUserDetailsAsync(string id);
    }
}