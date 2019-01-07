namespace Zircon.Common.User.BindingModels
{
    using Constrants;
    using System.ComponentModel.DataAnnotations;

    public class LoginBindingModel
    {
        [Required(ErrorMessage = ErrorConstants.RequiredField)]
        [EmailAddress(ErrorMessage = ErrorConstants.InvalidEmail)]
        [Display(Name = AttributeConstraintsConstants.EmailDisplay)]
        public string Email { get; set; }

        [Display(Name = AttributeConstraintsConstants.PasswordDisplay)]
        [Required(ErrorMessage = ErrorConstants.RequiredField)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = AttributeConstraintsConstants.RememberMeDisplay)]
        public bool RememberMe { get; set; }
    }
}