using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Zircon.Common.User.BindingModels;
using Zircon.Data;
using Zircon.Models;
using Zircon.Services.UserServices.Interfaces;

namespace Zircon.Services.UserServices
{
    public class UserAddressService : BaseEfService, IUserAddressService
    {
        public UserAddressService(ZirconDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {

        }

        public async Task<AddAddressBindingModel> BindAddress(string userId)
        {
            var dbUser = await DbContext.Users.Include(u => u.Address).FirstOrDefaultAsync(u => u.Id == userId);

            if (dbUser.Address == null)
            {
                return null;
            }

            var address = dbUser.Address;

            var model = Mapper.Map<AddAddressBindingModel>(address);
            return model;
        }

        public async Task<string> AddOrUpdateAddress(string userId, AddAddressBindingModel model)
        {
            var dbUser = await DbContext.Users.Include(u => u.Address).FirstOrDefaultAsync(u => u.Id == userId);

            if (dbUser.Address == null)
            {
                var address = Mapper.Map<Address>(model);
                DbContext.Addresses.Add(address);
                DbContext.SaveChanges();
                dbUser.Address = address;
                DbContext.SaveChanges();
                return "Address was added";
            }
            else
            {
                var currAddress =await DbContext.Addresses.FirstOrDefaultAsync(a => a.Id == dbUser.Address.Id);
                currAddress.Town = model.Town;
                currAddress.Apartment = model.Apartment;
                currAddress.Bell = model.Bell;
                currAddress.District = model.District;
                currAddress.Block = model.Block;
                currAddress.Floor = model.Floor;
                currAddress.Number = model.Number;
                currAddress.Postcode = model.Postcode;
                currAddress.Street = model.Street;
                DbContext.Addresses.Update(currAddress);
                DbContext.SaveChanges();
                return "Address was updated";
            }
        }
    }
}