namespace Zircon.Common.Admin.BindingModels
{
    using System.ComponentModel.DataAnnotations;

    public class AddGiftCardBindingModel
    {
        [Required]
        [MinLength(Constants.AttributeConstraint.GiftCodeMinLength, ErrorMessage = Constants.ErrorMessages.GiftCartMinimumLength)]
        public string Code { get; set; }

        [Required(ErrorMessage = Constants.ErrorMessages.RequiredGiftCartDiscount)]
        [Range(Constants.AttributeConstraint.GiftCodeMinDiscount, Constants.AttributeConstraint.GiftCodeMaxDiscount)]
        public int Discount { get; set; }
    }
}