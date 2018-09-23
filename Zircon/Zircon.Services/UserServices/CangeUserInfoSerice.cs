﻿using Zircon.Models;

namespace Zircon.Services.UserServices
{
    using AutoMapper;
    using Data;
    using Interfaces;
    using System.Linq;
    using System.Threading.Tasks;

    public class CangeUserInfoSerice : BaseEfService, ICangeUserInfoSerice
    {
        public CangeUserInfoSerice(ZirconDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }

        public async Task ChangeNameAsync(string name, string email)
        {
            var user = GetDbUser(email);
            if (user != null)
            {
                user.Name = name;
            }
            await DbContext.SaveChangesAsync();
        }

        public async Task ChangeSurnameAsync(string surname, string email)
        {
            var user = GetDbUser(email);
            if (user != null)
            {
                user.Surname = surname;
            }
            
            await DbContext.SaveChangesAsync();
        }
        private User GetDbUser(string email)
        {
            return DbContext.Users.FirstOrDefault(u => u.Email == email);
        }
    }
}