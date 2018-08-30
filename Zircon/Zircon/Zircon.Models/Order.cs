using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Zircon.Models
{
    public class Order
    {
        public Order()
        {
            Products = new List<ProductOrders>();
        }
        public int Id { get; set; }

        public ICollection<ProductOrders> Products { get; set; }
        [Required]
        public decimal FinalPrice { get; set; }

        public GiftCard GiftCard { get; set; }
    }
}