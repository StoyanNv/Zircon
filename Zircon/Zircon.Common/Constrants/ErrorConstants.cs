namespace Zircon.Common.Constrants
{
    public static class ErrorConstants
    {
        public const string InvalidFormData = "You have entered invalid data.";
        public const string NoCategoryName = "Category name is Required.";
        public const string UserNotFound = "Unable to load user with ID '{0}'.";
        public const string RemovingExternalLogin = "Unexpected error occurred removing external login for user with ID '{0}'.";
        public const string LoadingExternalLoginInfo = "Unexpected error occurred loading external login info for user with ID '{0}'.";
        public const string SettingPhoneNumber = "Unexpected error occurred setting phone number for user with ID '{0}'.";
        public const string ConfirmEmail = "Error confirming email for user with ID '{0}'.";
        public const string ExternalProvider = "Error from external provider: {0}.";
        public const string ExternalLoginInformation = "Error loading external login information.";
        public const string ExternalLoginInformationDuringConfirmation = "Error loading external login information during confirmation.";
        public const string FieldMinimumLength = "The {0} field must have minimum length of {1}";
        public const string ProductCategoryIsRequired = "You have to specify a category";
        public const string PasswordLength = "The {0} must be at least {2} and at max {1} characters long.";
        public const string PasswordsDoNotMatch = "Passwords don't match";
        public const string InvalidLoginCredentials = "Invalid login credentials";
        public const string UserAlreadyExists = "User {0} already exists.";
        public const string RequiredField = "The {0} field is required.";
        public const string RangeError = "Please enter a value between {1} and {2}.";
        public const string InvalidEmail = "The value in the {0} field is not valid address.";
        public const string InvalidPhone = "The value in the {0} field is not valid.";
        public const string ResetPasswordCodeMustBeSupplied = "A code must be supplied for password reset.";
    }
}