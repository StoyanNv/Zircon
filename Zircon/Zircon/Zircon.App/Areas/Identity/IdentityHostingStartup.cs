using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(Zircon.App.Areas.Identity.IdentityHostingStartup))]
namespace Zircon.App.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}