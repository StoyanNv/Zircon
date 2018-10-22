namespace Zircon.Models
{
    using Common;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Product
    {
        public Product()
        {
            Orders = new List<ProductOrders>();
        }

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Url]
        [Required]
        public string PictureUrl { get; set; }

        [Required]
        [Range(Constants.AttributeConstraint.PriceMinValue, int.MaxValue)]
        public decimal Price { get; set; }

        [Required]
        [Range(Constants.AttributeConstraint.WeightMinValue, int.MaxValue)]
        public double Weight { get; set; }

        [Required]
        public Category Category { get; set; }

        public ICollection<ProductOrders> Orders { get; set; }
    }
}