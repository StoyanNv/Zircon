namespace Zircon.Common.User.BindingModels
{
    using System.ComponentModel.DataAnnotations;

    public class RegisterBindingModel
    {

        [Required]
        [MinLength(Constants.AttributeConstraint.NameMinLenght)]
        public string Name { get; set; }
        [Required]
        [MinLength(Constants.AttributeConstraint.SurnameMinLenght)]
        public string Surname { get; set; }

        [Required]
        [MinLength(Constants.AttributeConstraint.PhoneMinLenght)]
        [Phone]
        public string Phone { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = Constants.AttributeConstraint.EmailDisplay)]
        public string Email { get; set; }

        [Required]
        [StringLength(Constants.AttributeConstraint.PasswordMaxLenght,
            ErrorMessage = Constants.ErrorMessages.PasswordLength,
            MinimumLength = Constants.AttributeConstraint.PasswordMinLenght)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = Constants.AttributeConstraint.ConfirmPasswordDisplay)]
        [Compare(Constants.AttributeConstraint.PasswordCompareValue, ErrorMessage = Constants.ErrorMessages.PasswordsDoNotMatch)]
        public string ConfirmPassword { get; set; }
    }
}