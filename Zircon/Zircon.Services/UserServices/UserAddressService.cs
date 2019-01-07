namespace Zircon.Services.UserServices
{
    using AutoMapper;
    using Common.Constrants;
    using Common.User.BindingModels;
    using Data;
    using Interfaces;
    using Microsoft.EntityFrameworkCore;
    using Models;
    using System.Threading.Tasks;

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
                return SuccessConstants.AddressAdd;
            }
            var currAddress = await DbContext.Addresses.FirstOrDefaultAsync(a => a.Id == dbUser.Address.Id);

            int id = currAddress.Id;
            currAddress = Mapper.Map(model, currAddress);
            currAddress.Id = id;
            DbContext.Addresses.Update(currAddress);
            DbContext.SaveChanges();
            return SuccessConstants.AddressUpdate;
        }
    }
}