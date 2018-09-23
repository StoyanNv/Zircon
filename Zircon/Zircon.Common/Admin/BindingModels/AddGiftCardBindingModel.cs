namespace Zircon.Common.Admin.BindingModels
{
    using System.ComponentModel.DataAnnotations;

    public class AddGiftCardBindingModel
    {
        [Required]
        [MinLength(4, ErrorMessage = "The code must have minimum length of 4")]
        public string Code { get; set; }

        [Required(ErrorMessage = "Discount field is required")]
        public int Discount { get; set; }
    }
}