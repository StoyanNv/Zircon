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

    public class CategoriesService : BaseEfService, ICategoriesService
    {
        private const string BlankImg = "http://www.shreejeeschool.in/wp-content/uploads/2016/11/blank-img.jpg";
        public CategoriesService(ZirconDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }

        public async Task<IEnumerable<AllCategoriesViewModel>> GetCategoriesAsync()
        {
            var categories = await DbContext.Categories.Include(c => c.Products).ToListAsync();

            var result = Mapper.Map<IEnumerable<AllCategoriesViewModel>>(categories);

            foreach (var res in result)
            {
                var category = categories.FirstOrDefault(c => c.Id == res.Id);

                res.ImageUrl = CategoryImg(category);
            }

            return result;
        }

        public async Task<IEnumerable<IndexProductsCardViewModel>> GetProductsAsync(int categoryId)
        {
            var products = await GetDbProducts(categoryId);

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

        private async Task<List<Product>> GetDbProducts(int categoryId)
        {
            return await this.DbContext
                .Products
                .Include(p => p.Category)
                .Where(p => p.Category.Id == categoryId)
                .ToListAsync();
        }

        private string CategoryImg(Category category)
        {
            Product product = null;

            if (category != null)
            {
                product = category.Products.FirstOrDefault();
            }

            if (product == null)
            {
                return BlankImg;
            }
            return product.PictureUrl;
        }

    }
}