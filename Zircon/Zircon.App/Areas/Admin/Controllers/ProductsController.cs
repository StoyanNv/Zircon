using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Zircon.App.Areas.Admin.Controllers
{
    using Helpers.Messages;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;
    using Zircon.Common;
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
                this.TempData["__MessageText"] = Constants.ErrorMessages.InvalidFormData;
                return View(model);
            }

            var id = await this.adminProductsService.AddProductAsync(model);

            this.TempData["__MessageType"] = MessageType.Success;
            this.TempData["__MessageText"] = Constants.SuccessMessages.ProductAdded;
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
                this.TempData["__MessageText"] = Constants.ErrorMessages.NoCategoryName;
                return View();
            }

            await this.adminProductsService.AddCategoryAsync(model);

            this.TempData["__MessageType"] = MessageType.Success;
            this.TempData["__MessageText"] = string.Format(Constants.SuccessMessages.CategoryAdded, model.Name);
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
                this.TempData["__MessageText"] = Constants.ErrorMessages.InvalidFormData;
                return View(model);
            }

            var id = await this.adminProductsService.EditProductAsync(model);

            this.TempData["__MessageType"] = MessageType.Success;
            this.TempData["__MessageText"] = Constants.SuccessMessages.ProductEdited;

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