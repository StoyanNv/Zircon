namespace Zircon.Services.UserServices
{
    using AutoMapper;
    using Common.User.ViewModels;
    using Data;
    using Interfaces;
    using Microsoft.EntityFrameworkCore;
    using Models;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class UserProductDetailsService : BaseEfService, IUserProductDetailsService
    {
        public UserProductDetailsService(ZirconDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }
        public async Task<ProductDetailsVIewModel> GetProductAsync(int id)
        {
            var product = await GetDbProduct(id);
            if (product == null)
            {
                return null;
            }

            var result = this.Mapper.Map<ProductDetailsVIewModel>(product);
            result.Category = product.Category.Name;

            return result;
        }

        public async Task<IEnumerable<IndexProductsCardViewModel>> GetProductsAsync()
        {
            var products = await GetDbProductsWithCategories();
            if (products == null)
            {
                return null;
            }

            var result = this.Mapper.Map<IEnumerable<IndexProductsCardViewModel>>(products);
            foreach (var res in result)
            {
                var product = products.FirstOrDefault(p => p.Id == res.Id);
                if (product != null)
                {
                    res.Category = product.Category.Name;
                }
            }
            return result;
        }

        private async Task<List<Product>> GetDbProductsWithCategories()
        {
            return await this.DbContext.Products.Include(p => p.Category).ToListAsync();
        }

        private async Task<Product> GetDbProduct(int id)
        {
            return await this.DbContext
                .Products.Include(p => p.Category).FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}