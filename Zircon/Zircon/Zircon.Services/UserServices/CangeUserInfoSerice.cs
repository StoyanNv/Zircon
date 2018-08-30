using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Zircon.Data;
using Zircon.Services.UserServices.Interfaces;

namespace Zircon.Services.UserServices
{
    public class CangeUserInfoSerice : BaseEfService, ICangeUserInfoSerice
    {
        public CangeUserInfoSerice(ZirconDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }

        public async Task ChangeNameAsync(string name, string email)
        {
            DbContext.Users.FirstOrDefault(u => u.Email == email).Name = name;
            await DbContext.SaveChangesAsync();
        }

        public async Task ChangeSurnameAsync(string name, string email)
        {
            DbContext.Users.FirstOrDefault(u => u.Email == email).Surname = name;
            await DbContext.SaveChangesAsync();
        }
    }
}
