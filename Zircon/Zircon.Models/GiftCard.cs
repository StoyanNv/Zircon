namespace Zircon.Models
{
    using Common.Constrants;
    using System.ComponentModel.DataAnnotations;

    public class GiftCard
    {
        public int Id { get; set; }

        [Required]
        [MinLength(AttributeConstraintsConstants.GiftCodeMinLength, ErrorMessage = ErrorConstants.FieldMinimumLength)]
        public string Code { get; set; }

        [Required]
        [Range(AttributeConstraintsConstants.GiftCodeMinDiscount, AttributeConstraintsConstants.GiftCodeMaxDiscount)]
        public int Discount { get; set; }
    }
}