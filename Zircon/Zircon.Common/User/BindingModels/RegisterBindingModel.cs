namespace Zircon.Common.User.BindingModels
{
    using Constrants;
    using System.ComponentModel.DataAnnotations;

    public class RegisterBindingModel
    {
        [Display(Name = AttributeConstraintsConstants.NameDisplay)]
        [Required(ErrorMessage = ErrorConstants.RequiredField)]
        [MinLength(AttributeConstraintsConstants.NameMinLenght, ErrorMessage = ErrorConstants.FieldMinimumLength)]
        public string Name { get; set; }

        [Display(Name = AttributeConstraintsConstants.SurnameDisplay)]
        [Required(ErrorMessage = ErrorConstants.RequiredField)]
        [MinLength(AttributeConstraintsConstants.SurnameMinLenght, ErrorMessage = ErrorConstants.FieldMinimumLength)]
        public string Surname { get; set; }

        [Display(Name = AttributeConstraintsConstants.PhoneDisplay)]
        [RegularExpression(Constants.PhoneRegx, ErrorMessage = ErrorConstants.InvalidPhone)]
        [Required(ErrorMessage = ErrorConstants.RequiredField)]
        [MinLength(AttributeConstraintsConstants.PhoneMinLenght, ErrorMessage = ErrorConstants.FieldMinimumLength)]
        public string Phone { get; set; }

        [Display(Name = AttributeConstraintsConstants.EmailDisplay)]
        [Required(ErrorMessage = ErrorConstants.RequiredField)]
        [EmailAddress(ErrorMessage = ErrorConstants.InvalidEmail)]
        public string Email { get; set; }

        [Display(Name = AttributeConstraintsConstants.PasswordDisplay)]
        [Required(ErrorMessage = ErrorConstants.RequiredField)]
        [StringLength(AttributeConstraintsConstants.PasswordMaxLenght,
            ErrorMessage = ErrorConstants.PasswordLength,
            MinimumLength = AttributeConstraintsConstants.PasswordMinLenght)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = ErrorConstants.RequiredField)]
        [DataType(DataType.Password)]
        [Display(Name = AttributeConstraintsConstants.ConfirmPasswordDisplay)]
        [Compare(AttributeConstraintsConstants.PasswordCompareValue, ErrorMessage = ErrorConstants.PasswordsDoNotMatch)]
        public string ConfirmPassword { get; set; }
    }
}