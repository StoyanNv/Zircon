using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Zircon.Common.User.ViewModels;
using Zircon.Data;
using Zircon.Models;
using Zircon.Services.UserServices.Interfaces;

namespace Zircon.Services.UserServices
{
    public class CartProductService : BaseEfService, ICartProductService
    {
        public CartProductService(ZirconDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }

        public async Task<Product> GetProductsAsync(int productId)
        {
            var product = await this.DbContext.Products.FindAsync(productId);
            return product;
        }

        public IEnumerable<ShopingCartViewModel> ConvertForShoppingCart(IEnumerable<Product> products)
        {
            return this.Mapper.Map<IEnumerable<ShopingCartViewModel>>(products);
        }

        public async Task<int> AddOrderCardAsync(IEnumerable<Product> model, string userId, string giftCardCode)
        {
            var user = await DbContext.Users.Include(u => u.Address).Include(u => u.Orders).FirstOrDefaultAsync(u => u.Id == userId);
            if (user.Address == null)
            {
                return -1;
            }
            var giftCard = await DbContext.GiftCards.FirstOrDefaultAsync(c => c.Code == giftCardCode);
            var currOrder = new Order() { GiftCard = giftCard, FinalPrice = model.Select(p => p.Price).Sum() };
            if (giftCard != null)
            {
                currOrder.FinalPrice = currOrder.FinalPrice - (currOrder.FinalPrice * giftCard.Discount / 100);
            }
            var order = model.Select(p => new ProductOrders() { ProductId = p.Id, Order = currOrder, OrderDate = DateTime.Now }).ToList();
            user.Orders = order;
            DbContext.SaveChanges();
            return currOrder.Id;
        }
    }
}