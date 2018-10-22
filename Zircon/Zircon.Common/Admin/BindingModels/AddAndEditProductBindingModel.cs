namespace Zircon.Common.Admin.BindingModels
{
    using Microsoft.AspNetCore.Mvc.Rendering;
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

        [Display(Name = Constants.AttributeConstraint.PictureUrlDisplay)]
        [Url]
        [Required]
        public string PictureUrl { get; set; }

        [Required]
        [Range(Constants.AttributeConstraint.PriceMinValue, int.MaxValue)]
        public decimal Price { get; set; }

        [Required(ErrorMessage = Constants.ErrorMessages.ProductCategoryIsRequired)]
        [Display(Name = Constants.AttributeConstraint.CategoryDisplay)]
        public string CategoryId { get; set; }

        [Required]
        [Range(Constants.AttributeConstraint.WeightMinValue, int.MaxValue)]
        public double Weight { get; set; }

        public IEnumerable<SelectListItem> Categories { get; set; }
    }
}