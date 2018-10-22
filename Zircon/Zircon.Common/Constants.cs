namespace Zircon.Common
{
    public static class Constants
    {
        public const string EmailSenderEmail = "stoian.nedkov@abv.bg";
        public const string EmailSenderName = "Admin";
        public const string DefaultAdminEmail = "nedkov98@gmail.com";
        public const string DefaultAdminPassword = "adminasdasd1";
        public const string BlankImg = "http://www.shreejeeschool.in/wp-content/uploads/2016/11/blank-img.jpg";

        public static class SuccessMessages
        {
            public const string ProductAdded = "Product added successfully.";
            public const string ProductEdited = "Product edited successfully.";
            public const string CategoryAdded = "{0} category added successfully.";
            public const string GiftCardAdded = "Gift Card {0} added successfully.";
            public const string ExternalLoginAdded = "The external login was added.";
            public const string ExternalLoginRemoved = "The external login was removed.";
            public const string UpdateProfile = "Your profile has been updated.";
            public const string VerificationEmailSent = "Verification email sent. Please check your email.";
            public const string AddressAdd = "Address was added.";
            public const string AddressUpdate = "Address was updated.";
        }
        public static class ErrorMessages
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
            public const string GiftCartMinimumLength = "The code must have minimum length of 4";
            public const string RequiredGiftCartDiscount = "Discount field is required";
            public const string ProductCategoryIsRequired = "You have to specify a category";
            public const string PasswordLength = "The {0} must be at least {2} and at max {1} characters long.";
            public const string PasswordsDoNotMatch = "Passwords don't match";
            public const string InvalidLoginCredentials = "Invalid login credentials";
            public const string UserAlreadyExists = "User already exists";
            //public const string GiftCartDiscountRange = "Gift cart discount must be at least 1%";
        }
        public static class InfoMessages
        {
            public const string ProductAlreadyAdded = "Product already added.";
            public const string MissingAddress = "You should add an address before completing your order.";
            public const string EmptyCart = "Cart is empty.";
        }
        public static class AttributeConstraint
        {
            public const string AdminArea = "Admin";
            public const string AdminRole = "Administrator";
            public const string PhoneNumberDisplay = "Phone number";
            public const string PictureUrlDisplay = "Picture URL";
            public const string CategoryDisplay = "Category";
            public const string TownDisplay = "Town *";
            public const string DistrictDisplay = "District *";
            public const string StreetDisplay = "Street *";
            public const string NumberDisplay = "Number *";
            public const string PostcodeDisplay = "Postcode *";
            public const string RememberMeDisplay = "Remember me?";
            public const string EmailDisplay = "E-mail";
            public const string ConfirmPasswordDisplay = "Confirm password";
            public const string PasswordCompareValue = "Password";

            public const double PriceMinValue = 0.1;
            public const double WeightMinValue = 0.1;
            public const int GiftCodeMinLength = 4;
            public const int GiftCodeMinDiscount = 1;
            public const int GiftCodeMaxDiscount = 99;
            public const int NameMinLenght = 3;
            public const int SurnameMinLenght = 3;
            public const int PhoneMinLenght = 10;
            public const int PasswordMinLenght = 6;
            public const int PasswordMaxLenght = 100;
        }
    }
}