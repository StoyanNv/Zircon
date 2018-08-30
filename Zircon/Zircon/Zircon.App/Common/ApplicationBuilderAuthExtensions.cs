﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Zircon.Models;

namespace Zircon.App.Common
{
    public static class ApplicationBuilderAuthExtensions
    {
        private const string DefaultAdminPassword = "adminasdasd1";

        private static readonly IdentityRole[] roles =
        {
            new IdentityRole("Administrator")
        };

        public static async void SeedDatabase(
            this IApplicationBuilder app)
        {
            var serviceFactory = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>();
            var scope = serviceFactory.CreateScope();
            using (scope)
            {
                var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
                var userManager = scope.ServiceProvider.GetRequiredService<UserManager<User>>();

                foreach (var role in roles)
                {
                    if (!await roleManager.RoleExistsAsync(role.Name))
                    {
                        var result = await roleManager.CreateAsync(role);
                    }
                }

                var user = await userManager.FindByNameAsync("admin");

                if (user == null)
                {
                    user = new User()
                    {
                        UserName = "nedkov98@gmail.com",
                        Email = "nedkov98@gmail.com",
                        EmailConfirmed = true
                    };
                    var result = await userManager.CreateAsync(user, DefaultAdminPassword);
                    result = await userManager.AddToRoleAsync(user, roles[0].Name);
                }
            }
        }
    }
}