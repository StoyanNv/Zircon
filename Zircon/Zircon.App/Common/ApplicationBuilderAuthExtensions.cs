namespace Zircon.App.Common
{
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.Extensions.DependencyInjection;
    using Zircon.Common.Constrants;
    using Zircon.Models;

    public static class ApplicationBuilderAuthExtensions
    {
        private static readonly IdentityRole[] roles =
        {
            new IdentityRole(AttributeConstraintsConstants.AdminRole)
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

                var user = await userManager.FindByNameAsync(Constants.DefaultAdminEmail);

                if (user == null)
                {
                    user = new User()
                    {
                        UserName = Constants.DefaultAdminEmail,
                        Email = Constants.DefaultAdminEmail,
                        EmailConfirmed = true
                    };
                    var result = await userManager.CreateAsync(user, Constants.DefaultAdminPassword);
                    result = await userManager.AddToRoleAsync(user, roles[0].Name);
                }
            }
        }
    }
}