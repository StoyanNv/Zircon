namespace Zircon.App.Areas.Admin.Controllers
{
    using Helpers.Messages;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Localization;
    using System.Threading.Tasks;
    using Zircon.Common.Constrants;
    using Zircon.Common.Admin.BindingModels;
    using Zircon.Services.Admin.Interfaces;

    public class ProductsController : AdminController
    {
        private readonly IAdminProductsService adminProductsService;
        private readonly IStringLocalizer<ProductsController> localizer;

        public ProductsController(IAdminProductsService adminProductsService,
            IStringLocalizer<ProductsController> localizer)
        {
            this.localizer = localizer;
            this.adminProductsService = adminProductsService;
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = await adminProductsService.GetProductAsync();
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Add(AddAndEditProductBindingModel model)
        {
            if (!ModelState.IsValid)
            {
                this.TempData["__MessageType"] = MessageType.Warning;
                this.TempData["__MessageText"] = this.localizer[ErrorConstants.InvalidFormData];
                return View(model);
            }

            var id = await this.adminProductsService.AddProductAsync(model);

            this.TempData["__MessageType"] = MessageType.Success;
            this.TempData["__MessageText"] = this.localizer[SuccessConstants.ProductAdded].ToString();
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
                this.TempData["__MessageText"] = this.localizer[ErrorConstants.NoCategoryName];
                return View();
            }

            await this.adminProductsService.AddCategoryAsync(model);

            this.TempData["__MessageType"] = MessageType.Success;
            this.TempData["__MessageText"] = string.Format(this.localizer[SuccessConstants.CategoryAdded], model.Name);
            return RedirectToAction("Add");
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var model = await this.adminProductsService.GetEditProductDetailsAsync(id);
            return this.View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(AddAndEditProductBindingModel model)
        {
            if (!ModelState.IsValid)
            {
                this.TempData["__MessageType"] = MessageType.Warning;
                this.TempData["__MessageText"] = this.localizer[ErrorConstants.InvalidFormData];
                return View(model);
            }

            var id = await this.adminProductsService.EditProductAsync(model);

            this.TempData["__MessageType"] = MessageType.Success;
            this.TempData["__MessageText"] = this.localizer[SuccessConstants.ProductEdited].ToString();

            return this.RedirectToPage("/Products/Details", new { id });
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            await this.adminProductsService.DeleteProductAsync(id);

            return this.RedirectToAction("Index", "Home");
        }
    }
}