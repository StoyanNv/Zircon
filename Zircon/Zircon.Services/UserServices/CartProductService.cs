namespace Zircon.Services.UserServices
{
    using AutoMapper;
    using Common.User.ViewModels;
    using Data;
    using Interfaces;
    using Microsoft.EntityFrameworkCore;
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

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

        public async Task<Order> FinishOrderAsync(IEnumerable<Product> model, string userId, string giftCardCode)
        {
            var user = await GetDbUser(userId);
            if (user.Address == null)
            {
                return null;
            }
            var giftCard = await GetDbGiftCard(giftCardCode);
            var currOrder = new Order() { GiftCard = giftCard, FinalPrice = model.Select(p => p.Price).Sum() };
            if (giftCard != null)
            {
                currOrder.FinalPrice = CalculateFinalPrice(currOrder, giftCard);
            }
            var order = model
                .Select(p => new ProductOrders()
                {
                    ProductId = p.Id,
                    Order = currOrder,
                    OrderDate = DateTime.Now
                })
                .ToList();
            user.Orders = order;
            DbContext.SaveChanges();
            return currOrder;
        }

        private async Task<GiftCard> GetDbGiftCard(string giftCardCode)
        {
            return await DbContext.GiftCards.FirstOrDefaultAsync(c => c.Code == giftCardCode);
        }

        private static decimal CalculateFinalPrice(Order currOrder, GiftCard giftCard)
        {
            return currOrder.FinalPrice - (currOrder.FinalPrice * giftCard.Discount / 100);
        }

        private async Task<User> GetDbUser(string userId)
        {
            return await DbContext
                .Users
                .Include(u => u.Address)
                .Include(u => u.Orders)
                .FirstOrDefaultAsync(u => u.Id == userId);
        }
    }
}