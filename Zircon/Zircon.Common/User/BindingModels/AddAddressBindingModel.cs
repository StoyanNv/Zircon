namespace Zircon.Common.User.BindingModels
{
    using Constrants;
    using System.ComponentModel.DataAnnotations;

    public class AddAddressBindingModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = ErrorConstants.RequiredField)]
        [Display(Name = AttributeConstraintsConstants.TownDisplay)]
        public string Town { get; set; }

        [Required(ErrorMessage = ErrorConstants.RequiredField)]
        [Display(Name = AttributeConstraintsConstants.DistrictDisplay)]
        public string District { get; set; }

        [Required(ErrorMessage = ErrorConstants.RequiredField)]
        [Display(Name = AttributeConstraintsConstants.StreetDisplay)]
        public string Street { get; set; }

        [Required(ErrorMessage = ErrorConstants.RequiredField)]
        [Display(Name = AttributeConstraintsConstants.NumberDisplay)]
        public int Number { get; set; }

        [Required(ErrorMessage = ErrorConstants.RequiredField)]
        [Display(Name = AttributeConstraintsConstants.PostcodeDisplay)]
        public int Postcode { get; set; }

        [Display(Name = AttributeConstraintsConstants.FloorDisplay)]
        public int? Floor { get; set; }

        [Display(Name = AttributeConstraintsConstants.BlockDisplay)]
        public int? Block { get; set; }

        [Display(Name = AttributeConstraintsConstants.ApartmentDisplay)]
        public string Apartment { get; set; }

        [Display(Name = AttributeConstraintsConstants.BellDisplay)]
        public string Bell { get; set; }
    }
}