namespace Zircon.Common.User.BindingModels
{
    using System.ComponentModel.DataAnnotations;

    public class AddAddressBindingModel
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = Constants.AttributeConstraint.TownDisplay)]
        public string Town { get; set; }

        [Required]
        [Display(Name = Constants.AttributeConstraint.DistrictDisplay)]
        public string District { get; set; }

        [Required]
        [Display(Name = Constants.AttributeConstraint.StreetDisplay)]
        public string Street { get; set; }

        [Required]
        [Display(Name = Constants.AttributeConstraint.NumberDisplay)]
        public int Number { get; set; }

        [Required]
        [Display(Name = Constants.AttributeConstraint.PostcodeDisplay)]
        public int Postcode { get; set; }

        public int? Floor { get; set; }

        public int? Block { get; set; }

        public string Apartment { get; set; }

        public string Bell { get; set; }
    }
}