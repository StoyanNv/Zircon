using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Zircon.Common.Admin.BindingModels;
using Zircon.Services.Admin.Interfaces;

namespace Zircon.App.Areas.Admin.Controllers
{
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
                return View(model);
            }

            var id = await this.adminProductsService.AddProductAsync(model);
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
                return View();
            }

            await this.adminProductsService.AddCategoryAsync(model);
            return RedirectToAction("Add");
        }
    }
}