using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Zircon.Common.User.ViewModels;
using Zircon.Data;
using Zircon.Services.UserServices.Interfaces;

namespace Zircon.Services.UserServices
{
    public class UserProductDetailsService : BaseEfService, IUserProductDetailsService
    {
        public UserProductDetailsService(ZirconDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }
        public async Task<ProductDetailsVIewModel> GetProductAsync(int id)
        {
            var product = await this.DbContext.Products.Include(p => p.Category).FirstOrDefaultAsync(p => p.Id == id);
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
            var products = await this.DbContext.Products.Include(p => p.Category).ToListAsync();
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
