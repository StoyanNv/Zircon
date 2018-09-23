namespace Zircon.Services.Admin
{
    using AutoMapper;
    using Data;
    using Interfaces;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.EntityFrameworkCore;
    using Models;
    using System.Linq;
    using System.Threading.Tasks;
    using Zircon.Common.Admin.BindingModels;
    public class AdminProductsService : BaseEfService, IAdminProductsService
    {
        public AdminProductsService(ZirconDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }

        public async Task<AddProductBindingModel> GetProductAsync()
        {
            var model = new AddProductBindingModel()
            {
                Categories = await this.DbContext.Categories
                    .Select(b => new SelectListItem()
                    {
                        Text = b.Name,
                        Value = b.Id.ToString()
                    })
                    .ToListAsync()
            };

            return model;
        }

        public async Task<int> AddProductAsync(AddProductBindingModel model)
        {
            var product = this.Mapper.Map<Product>(model);
            product.Category = await this.DbContext.Categories.FindAsync(int.Parse(model.CategoryId));
            await this.DbContext.Products.AddAsync(product);
            await this.DbContext.SaveChangesAsync();

            return product.Id;
        }
        public async Task AddCategoryAsync(AddCategoryBindingModel model)
        {
            var category = this.Mapper.Map<Category>(model);
            if (await this.DbContext.Categories.FirstOrDefaultAsync(c => c.Name == model.Name) == null)
            {
                await this.DbContext.Categories.AddAsync(category);
                await this.DbContext.SaveChangesAsync();
            }
        }
        public async Task AddGiftCardAsync(AddGiftCardBindingModel model)
        {
            var giftCard = this.Mapper.Map<GiftCard>(model);
            if (await this.DbContext.GiftCards.FirstOrDefaultAsync(c => c.Code == model.Code) == null)
            {
                await this.DbContext.GiftCards.AddAsync(giftCard);
                await this.DbContext.SaveChangesAsync();
            }
        }
    }
}