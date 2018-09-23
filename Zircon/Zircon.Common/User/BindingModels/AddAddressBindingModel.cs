namespace Zircon.Common.User.BindingModels
{
    using System.ComponentModel.DataAnnotations;

    public class AddAddressBindingModel
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Town *")]
        public string Town { get; set; }

        [Required]
        [Display(Name = "District *")]
        public string District { get; set; }

        [Required]
        [Display(Name = "Street *")]
        public string Street { get; set; }

        [Required]
        [Display(Name = "Number *")]
        public int Number { get; set; }

        [Required]
        [Display(Name = "Postcode *")]
        public int Postcode { get; set; }

        public int? Floor { get; set; }

        public int? Block { get; set; }

        public string Apartment { get; set; }

        public string Bell { get; set; }
    }
}