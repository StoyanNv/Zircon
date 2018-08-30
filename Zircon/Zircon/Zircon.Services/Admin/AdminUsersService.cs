using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Zircon.Common.Admin.ViewModels;
using Zircon.Data;
using Zircon.Services.Admin.Interfaces;

namespace Zircon.Services.Admin
{
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
            var user = await this.DbContext.Users.Include(u => u.Address).Include(u=>u.Orders).FirstOrDefaultAsync(u => u.Id == id);
            if (user == null)
            {
                return null;
            }

            var model = Mapper.Map<UserDetailsViewModel>(user);

            if (user.Address != null)
            {
                model.District = user.Address.District;
                model.Town = user.Address.Town;
                model.Street = user.Address.Street;
                model.Number = user.Address.Number;
                model.Postcode = user.Address.Postcode;
                model.Floor = user.Address.Floor;
                model.Block = user.Address.Block;
                model.Apartment = user.Address.Apartment;
                model.Bell = user.Address.Bell;
            }

            return model;
        }
    }
}