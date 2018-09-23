namespace Zircon.App.Areas.Admin.Controllers
{
    using Helpers.Messages;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;
    using Zircon.Common.Admin.BindingModels;
    using Zircon.Services.Admin.Interfaces;

    public class ProductsController : AdminController
    {
        private readonly IAdminProductsService adminProductsService;

        public ProductsController(IAdminProductsService adminProductsService)
        {
            this.adminProductsService = adminProductsService;
        }

        [HttpGet]
        public IActionResult Add()
        {
            var model = adminProductsService.GetProductAsync();
            return View(model.Result);
        }
        [HttpPost]
        public async Task<IActionResult> Add(AddProductBindingModel model)
        {
            if (!ModelState.IsValid)
            {
                this.TempData["__MessageType"] = MessageType.Warning;
                this.TempData["__MessageText"] = $"You have entered invalid data,";
                return View(model);
            }

            var id = await this.adminProductsService.AddProductAsync(model);

            this.TempData["__MessageType"] = MessageType.Success;
            this.TempData["__MessageText"] = $"Product added successfully.";
            return this.RedirectToPage("/Products/Details", new { id });
        }
        [HttpGet]
        public IActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddCategory(AddCategoryBindingModel model)
        {
            if (!ModelState.IsValid)
            {
                this.TempData["__MessageType"] = MessageType.Warning;
                this.TempData["__MessageText"] = $"Category name is Required";
                return View();
            }

            await this.adminProductsService.AddCategoryAsync(model);

            this.TempData["__MessageType"] = MessageType.Success;
            this.TempData["__MessageText"] = $"{model.Name} category added successfully.";
            return RedirectToAction("Add");
        }
    }
}