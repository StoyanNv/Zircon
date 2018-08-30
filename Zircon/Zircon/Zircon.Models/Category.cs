﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Zircon.Models
{
    public class Category
    {
        public Category()
        {
            Products = new List<Product>();
        }

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}