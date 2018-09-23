namespace Zircon.App
{
    using AutoMapper;
    using Common;
    using Data;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.UI.Services;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Services.Admin;
    using Services.Admin.Interfaces;
    using Services.Mapping;
    using Services.UserServices;
    using Services.UserServices.Interfaces;
    using System.Reflection;
    using Zircon.App.Areas.Identity.Services;
    using Zircon.Models;

    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => false;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            services.AddDbContext<ZirconDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("ZirconConnection")));

            services.AddSession(options => options.Cookie.IsEssential = true);

            services.AddIdentity<User, IdentityRole>()
                .AddDefaultUI()
                .AddDefaultTokenProviders()
                .AddEntityFrameworkStores<ZirconDbContext>();

            services.AddAuthentication()
                .AddFacebook(options =>
                {
                    options.AppId = this.Configuration.GetSection("External Authentication:Facebook:AppId").Value;
                    options.AppSecret = this.Configuration.GetSection("External Authentication:Facebook:AppSecret").Value;
                })
                .AddGoogle(options =>
                {
                    options.ClientId = this.Configuration.GetSection("External Authentication:Google:ClientId").Value;
                    options.ClientSecret = this.Configuration.GetSection("External Authentication:Google:ClientSecret").Value;
                });
            services.Configure<IdentityOptions>(options =>
            {
                options.Password = new PasswordOptions()
                {
                    RequiredLength = 4,
                    RequiredUniqueChars = 1,
                    RequireLowercase = false,
                    RequireDigit = true,
                    RequireUppercase = false,
                    RequireNonAlphanumeric = false
                };

                options.SignIn.RequireConfirmedEmail = true;
            });
            services.AddSingleton<IEmailSender, SendGridEmailSender>();
            services.Configure<SendGridOptions>(this.Configuration.GetSection("EmailSettings"));

            services.AddAutoMapper(typeof(AutoMapperProfile).GetTypeInfo().Assembly);

            RegisterServiceLayer(services);
            services.AddDistributedMemoryCache();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(
            IApplicationBuilder app,
            IHostingEnvironment env,
            UserManager<User> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseAuthentication();
            app.UseSession();
            if (env.IsDevelopment())
            {
                app.SeedDatabase();
            }

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "area",
                    template: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");

            });
        }
        private static void RegisterServiceLayer(IServiceCollection services)
        {
            services.AddScoped<IAdminUsersService, AdminUsersService>();
            services.AddScoped<IAdminProductsService, AdminProductsService>();
            services.AddScoped<IUserProductDetailsService, UserProductDetailsService>();
            services.AddScoped<ICategoriesService, CategoriesService>();
            services.AddScoped<ICartProductService, CartProductService>();
            services.AddScoped<IUserAddressService, UserAddressService>();
            services.AddScoped<ICangeUserInfoSerice, CangeUserInfoSerice>();
        }
    }
}
