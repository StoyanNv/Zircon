using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Zircon.Common.User.ViewModels;
using Zircon.Data;

namespace Zircon.Services.UserServices.Interfaces
{
    public class CategoriesService : BaseEfService, ICategoriesService
    {
        public CategoriesService(ZirconDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }

        public async Task<IEnumerable<AllCategoriesViewModel>> GetCategoriesAsync()
        {
            var categories = await DbContext.Categories.Include(c => c.Products).ToListAsync();

            var result = Mapper.Map<IEnumerable<AllCategoriesViewModel>>(categories);

            foreach (var res in result)
            {
                res.ImageUrl = categories.FirstOrDefault(c => c.Id == res.Id).Products.First().PictureUrl;
            }

            return result;
        }

        public async Task<IEnumerable<IndexProductsCardViewModel>> GetProductsAsync(int categoryId)
        {
            var products = await this.DbContext.Products.Include(p => p.Category).Where(p => p.Category.Id == categoryId).ToListAsync();
            if (products == null)
            {
                return null;
            }

            var result = this.Mapper.Map<IEnumerable<IndexProductsCardViewModel>>(products);
            foreach (var res in result)
            {
                res.Category = products.FirstOrDefault(p => p.Id == res.Id).Category.Name;
            }
            return result;
        }
    }
}