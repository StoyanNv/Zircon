namespace Zircon.Common.Admin.BindingModels
{
    using Constrants;
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
        [Required(ErrorMessage = ErrorConstants.RequiredField)]
        [Display(Name = AttributeConstraintsConstants.NameDisplay)]
        public string Name { get; set; }

        [Display(Name = AttributeConstraintsConstants.PictureUrlDisplay)]
        [Url]
        [Required(ErrorMessage = ErrorConstants.RequiredField)]
        public string PictureUrl { get; set; }

        [Required(ErrorMessage = ErrorConstants.RequiredField)]
        [Range(AttributeConstraintsConstants.PriceMinValue, int.MaxValue, ErrorMessage = ErrorConstants.RangeError)]
        [Display(Name = AttributeConstraintsConstants.PriceDisplay)]
        public decimal? Price { get; set; }

        [Required(ErrorMessage = ErrorConstants.ProductCategoryIsRequired)]
        [Display(Name = AttributeConstraintsConstants.CategoryDisplay)]
        public string CategoryId { get; set; }

        [Display(Name = AttributeConstraintsConstants.WeightDisplay)]
        [Required(ErrorMessage = ErrorConstants.RequiredField)]
        [Range(AttributeConstraintsConstants.WeightMinValue, int.MaxValue, ErrorMessage = ErrorConstants.RangeError)]
        public double? Weight { get; set; }

        public IEnumerable<SelectListItem> Categories { get; set; }
    }
}