namespace Zircon.Common.Admin.BindingModels
{
    using System.ComponentModel.DataAnnotations;

    public class AddGiftCardBindingModel
    {
        [Required]
        [MinLength(4, ErrorMessage = Constants.ErrorMessages.GiftCartMinimumLength)]
        public string Code { get; set; }

        [Required(ErrorMessage = Constants.ErrorMessages.RequiredGiftCartDiscount)]
        public int Discount { get; set; }
    }
}