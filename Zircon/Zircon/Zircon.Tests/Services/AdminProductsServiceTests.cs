using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zircon.Common.Admin.BindingModels;
using Zircon.Data;
using Zircon.Models;
using Zircon.Services.Admin;
using Zircon.Services.Mapping;
using Zircon.Services.UserServices;
using Zircon.Services.UserServices.Interfaces;


namespace Zircon.Tests.Services
{
    [TestClass]
    public class AdminProductsServiceTests
    {
        private ZirconDbContext dbContext;

        [TestInitialize]
        public void InitializeTests()
        {
            var options = new DbContextOptionsBuilder<ZirconDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;

            this.dbContext = new ZirconDbContext(options);

        }
        [TestMethod]
        public async Task AdminProductsService_AddGiftCart()
        {
            AddGiftCardBindingModel model = new AddGiftCardBindingModel() { Code = "1234", Discount = 20 };
            dbContext.SaveChanges();

            AutoMapper.Mapper.Initialize(config => config.AddProfile<AutoMapperProfile>());

            var service = new AdminProductsService(dbContext, AutoMapper.Mapper.Instance);

            await service.AddGiftCardAsync(model);

            Assert.IsNotNull(dbContext.GiftCards.FirstOrDefault(c => c.Code == "1234"));
            Assert.IsNotNull(dbContext.GiftCards.FirstOrDefault(c => c.Discount == 20));
        }
        [TestMethod]
        public async Task AdminProductsService_AddCategoryAsync()
        {
            AddCategoryBindingModel model = new AddCategoryBindingModel() { Name = "Ring" };
            dbContext.SaveChanges();

            var service = new AdminProductsService(dbContext, AutoMapper.Mapper.Instance);

            await service.AddCategoryAsync(model);

            Assert.IsNotNull(dbContext.Categories.FirstOrDefault(c => c.Name == "Ring"));
        }
        [TestMethod]
        public async Task AdminProductsService_AddProductAsync()
        {
            AddProductBindingModel model = new AddProductBindingModel() { Price = 2, Name = "Ring", CategoryId = "1", PictureUrl = "https://media.tiffany.com/is/image/Tiffany/1X/20180403_CB_Necklaces_and_Pendants_Tile2_3x2Promo_US_paloma_picasso_something_to_love.jpg?v=20180322135418" };
            dbContext.SaveChanges();
            var service = new AdminProductsService(dbContext, AutoMapper.Mapper.Instance);
            await service.AddProductAsync(model);
            Assert.IsNotNull(dbContext.Products.FirstOrDefault(c => c.Id == 1 && c.Name == "Ring"));
            Assert.IsNotNull(dbContext.Products.FirstOrDefault(c => c.Id == 1 && c.Name == "Ring").PictureUrl);
        }
        [TestMethod]
        public async Task CartProductService_GetProductsAsync()
        {
            dbContext.Products.Add(new Product()
            {
                Id = 1,
                Price = 2,
                Name = "Ring",
            });
            dbContext.SaveChanges();

            var service = new CartProductService(dbContext, AutoMapper.Mapper.Instance);
            var product = await service.GetProductsAsync(1);

            Assert.IsNotNull(product);
            Assert.AreEqual(1, product.Id);
            Assert.AreEqual(2, product.Price);
            Assert.AreEqual("Ring", product.Name);
        }
        [TestMethod]
        public void CartProductService_ConvertForShoppingCart()
        {
            dbContext.Products.Add(new Product()
            {
                Id = 1,
                Price = 2,
                Name = "Ring",
            });
            dbContext.Products.Add(new Product()
            {
                Id = 2,
                Price = 23,
                Name = "Ring",
            });
            dbContext.SaveChanges();

            var service = new CartProductService(dbContext, AutoMapper.Mapper.Instance);
            var products = service.ConvertForShoppingCart(dbContext.Products.ToList());

            Assert.IsNotNull(products);
            Assert.AreEqual(2, products.Count());
            Assert.AreEqual(2, products.First().Price);
        }
        [TestMethod]
        public async Task UserProductDetailsService_GetProductAsync()
        {
            dbContext.Products.Add(new Product()
            {
                Id = 1,
                Price = 2,
                Name = "Ring",
                Category = new Category() { Id = 1, Name = "Ring" }
            });
            dbContext.SaveChanges();

            var service = new UserProductDetailsService(dbContext, AutoMapper.Mapper.Instance);
            var product = await service.GetProductAsync(1);

            Assert.IsNotNull(product);
            Assert.AreEqual(1, product.Id);
            Assert.AreEqual(2, product.Price);
            Assert.AreEqual("Ring", product.Name);
        }
        [TestMethod]
        public async Task UserProductDetailsService_GetProductsAsync()
        {
            dbContext.Products.Add(new Product()
            {
                Id = 1,
                Price = 2,
                Name = "Ring",
                Category = new Category() { Id = 1, Name = "Ring" }
            });
            dbContext.SaveChanges();

            var service = new UserProductDetailsService(dbContext, AutoMapper.Mapper.Instance);
            var product = await service.GetProductsAsync();

            Assert.IsNotNull(product);
            Assert.AreEqual(1, product.First().Id);
            Assert.AreEqual(2, product.First().Price);
            Assert.AreEqual("Ring", product.First().Name);
        }
        [TestMethod]
        public async Task CategoriesService_GetCategoriesAsync()
        {
            dbContext.Categories.Add(new Category()
            {
                Id = 1,
                Name = "Ring",
                Products = new List<Product>() { new Product(){ Id = 1,
                    Price = 2,
                    Name = "Ring",}}
            });
            dbContext.SaveChanges();

            var service = new CategoriesService(dbContext, AutoMapper.Mapper.Instance);
            var categories = await service.GetCategoriesAsync();

            Assert.IsNotNull(categories);
            Assert.AreEqual(1, categories.First().Id);
            Assert.AreEqual("Ring", categories.First().Name);
        }
        [TestMethod]
        public async Task CategoriesService_GetProductsAsync()
        {
            dbContext.Products.Add(new Product()
            {
                Id = 1,
                Price = 2,
                Name = "Ring",
                Category = new Category() { Id = 1, Name = "Ring" }
            });
            dbContext.SaveChanges();

            var service = new CategoriesService(dbContext, AutoMapper.Mapper.Instance);
            var products = await service.GetProductsAsync(1);

            Assert.IsNotNull(products);
            Assert.AreEqual(1, products.First().Id);
            Assert.AreEqual("Ring", products.First().Name);
        }
        [TestMethod]
        public async Task CangeUserInfoSerice_ChangeNameAsync()
        {
            dbContext.Users.Add(new User()
            {
                Name = "Ring",
                Email = "mail"
            });
            dbContext.SaveChanges();

            var service = new CangeUserInfoSerice(dbContext, AutoMapper.Mapper.Instance);
            await service.ChangeNameAsync("Name", "mail");

            Assert.IsNotNull(dbContext.Users.FirstOrDefault(u => u.Name == "Name"));

        }
    }
}