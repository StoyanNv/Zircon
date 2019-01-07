namespace Zircon.Common.Admin.BindingModels
{
    using Constrants;
    using System.ComponentModel.DataAnnotations;

    public class AddGiftCardBindingModel
    {
        [Display(Name = AttributeConstraintsConstants.CodeDisplay)]
        [Required(ErrorMessage = ErrorConstants.RequiredField)]
        [MinLength(AttributeConstraintsConstants.GiftCodeMinLength, ErrorMessage = ErrorConstants.FieldMinimumLength)]
        public string Code { get; set; }

        [Display(Name = AttributeConstraintsConstants.DiscountDisplay)]
        [Required(ErrorMessage = ErrorConstants.RequiredField)]
        [Range(AttributeConstraintsConstants.GiftCodeMinDiscount, AttributeConstraintsConstants.GiftCodeMaxDiscount, ErrorMessage = ErrorConstants.RangeError)]
        public int? Discount { get; set; }
    }
}