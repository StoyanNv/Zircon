namespace Zircon.Common.Admin.BindingModels
{
    using Microsoft.AspNetCore.Mvc.Rendering;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class AddProductBindingModel
    {
        public AddProductBindingModel()
        {
            Categories = new List<SelectListItem>();
        }

        [Required]
        public string Name { get; set; }

        [Display(Name = "Picture URL")]
        [Url]
        [Required]
        public string PictureUrl { get; set; }

        [Required]
        [Range(0.1, Double.MaxValue)]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "You have to specify a category.")]
        [Display(Name = "Category")]
        public string CategoryId { get; set; }
        public IEnumerable<SelectListItem> Categories { get; set; }
    }
}