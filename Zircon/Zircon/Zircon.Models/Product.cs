using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Zircon.Models
{
    public class Product
    {
        public Product()
        {
            Orders = new List<ProductOrders>();
        }

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string PictureUrl { get; set; }

        [Required]
        [Range(0.1, Double.MaxValue)]
        public decimal Price { get; set; }

        [Required]
        public Category Category { get; set; }

        public ICollection<ProductOrders> Orders { get; set; }
    }
}