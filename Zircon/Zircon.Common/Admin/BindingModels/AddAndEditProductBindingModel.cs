namespace Zircon.Common.Admin.BindingModels
{
    using Microsoft.AspNetCore.Mvc.Rendering;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class AddAndEditProductBindingModel
    {
        public AddAndEditProductBindingModel()
        {
            Categories = new List<SelectListItem>();
        }

        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [Display(Name = "Picture URL")]
        [Url]
        [Required]
        public string PictureUrl { get; set; }

        [Required]
        [Range(0.1, Double.MaxValue)]
        public decimal Price { get; set; }

        [Required(ErrorMessage = Constants.ErrorMessages.ProductCategoryIsRequired)]
        [Display(Name = "Category")]
        public string CategoryId { get; set; }

        public double Weight { get; set; }

        public IEnumerable<SelectListItem> Categories { get; set; }
    }
}