namespace Zircon.Models
{
    using Common;
    using System.ComponentModel.DataAnnotations;

    public class GiftCard
    {
        public int Id { get; set; }

        [Required]
        [MinLength(Constants.AttributeConstraint.GiftCodeMinLength, ErrorMessage = Constants.ErrorMessages.GiftCartMinimumLength)]
        public string Code { get; set; }

        [Required]
        [Range(Constants.AttributeConstraint.GiftCodeMinDiscount, Constants.AttributeConstraint.GiftCodeMaxDiscount)]
        public int Discount { get; set; }
    }
}