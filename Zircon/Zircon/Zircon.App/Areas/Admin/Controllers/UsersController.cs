using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Zircon.Models;
using Zircon.Services.Admin.Interfaces;

namespace Zircon.App.Areas.Admin.Controllers
{
    public class UsersController : AdminController
    {
        private readonly UserManager<User> userManager;
        private readonly IAdminUsersService adminUsersService;
        public UsersController(
          IAdminUsersService adminUsersService,
            UserManager<User> userManager)
        {
            this.adminUsersService = adminUsersService;
            this.userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var currentUser = await userManager.GetUserAsync(this.User);
            var users = await this.adminUsersService.GetUsersAsync(currentUser.Id);

            return View(users);
        }
        [HttpGet]
        public async Task<IActionResult> Details(string id)
        {
            var model = await this.adminUsersService.GetUserDetailsAsync(id);

            if (model == null)
            {
                return NotFound();
            }

            return View(model);
        }
    }
}