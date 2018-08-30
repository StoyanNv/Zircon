using System;

namespace Zircon.Models
{
    public class ProductOrders
    {
        public int ProductId { get; set; }

        public Product Product { get; set; }

        public int OrderId { get; set; }    

        public Order Order { get; set; }

        public DateTime OrderDate { get; set; }
    }
}