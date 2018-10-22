namespace Zircon.Common.User.BindingModels
{
    using System.ComponentModel.DataAnnotations;

    public class LoginBindingModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = Constants.AttributeConstraint.RememberMeDisplay)]
        public bool RememberMe { get; set; }
    }
}