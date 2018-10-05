namespace Zircon.Services.Admin
{
    using AutoMapper;
    using Data;
    using Interfaces;
    using Microsoft.EntityFrameworkCore;
    using Models;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Zircon.Common.Admin.ViewModels;

    public class AdminUsersService : BaseEfService, IAdminUsersService
    {
        public AdminUsersService(ZirconDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }

        public async Task<IEnumerable<UserConciseViewModel>> GetUsersAsync(string adminId)
        {
            var users = await this
                .DbContext
                .Users
                .Where(u => u.Id != adminId)
                .ToListAsync();
            return Mapper
                .Map<IEnumerable<UserConciseViewModel>>(users);
        }

        public async Task<UserDetailsViewModel> GetUserDetailsAsync(string id)
        {
            var user = await GetDbUser(id);

            if (user == null)
            {
                return null;
            }

            var userModel = Mapper.Map<UserDetailsViewModel>(user);

            if (user.Address != null)
            {
                userModel = MapAddress(user, userModel);
            }

            return userModel;
        }

        private UserDetailsViewModel MapAddress(User user, UserDetailsViewModel userModel)
        {
            var address = user.Address;
            var addressModel = Mapper.Map<UserDetailsViewModel>(address);
            var model = Mapper.Map(addressModel, userModel);
            userModel = model;
            return userModel;
        }

        private async Task<User> GetDbUser(string id)
        {
            return await this.DbContext
                .Users
                .Include(u => u.Address)
                .Include(u => u.Orders)
                .FirstOrDefaultAsync(u => u.Id == id);
        }
    }
}