namespace Zircon.Common.User.BindingModels
{
    using System.ComponentModel.DataAnnotations;

    public class RegisterBindingModel
    {

        [Required]
        [MinLength(3)]
        public string Name { get; set; }
        [Required]
        [MinLength(3)]
        public string Surname { get; set; }

        [Required]
        [MinLength(10)]
        [Phone]
        public string Phone { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = Constants.ErrorMessages.PasswordLength, MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = Constants.ErrorMessages.PasswordsDoNotMatch)]
        public string ConfirmPassword { get; set; }
    }
}