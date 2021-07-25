namespace CompanyCode.ApiTemplate.Common.Models
{
    public static class ErrorMessages
    {
        public static readonly string ApiException = "A0000: Unhandled exception. Contact CEVA Support.";
        public static readonly ApiMessage UnableToSendEmail = new("A0003: Unable To Send Email.");

        // auth
        public static readonly ApiMessage UsernameOrPasswordIncorrect = new("A0200: Username or password is incorrect.");
        public static readonly ApiMessage UserIsDisabled = new("A0201: User is disabled in the system.");
        public static readonly ApiMessage UserIsLockedOut = new("A0202: User is locked");
        public static readonly ApiMessage UserDoesNotHaveCorrectRole = new("A0203: User does not have permission.");
        public static readonly ApiMessage InvalidUserTypeCodeOrDoesNotExist = new("A0214: User code not valid.");
        public static readonly ApiMessage ErrUserPassword = new("A0215: Invalid Password");
        public static readonly ApiMessage ErrUserMissingPassword = new("A0216: Password is missing.");
        public static readonly ApiMessage ErrUserPasswordLength = new("A0217: Minimum length of password is ");
        public static readonly ApiMessage ErrUserPasswordLengthRange = new("A0217: Passwords need be of length of at least ");
        public static readonly ApiMessage ErrUserPasswordHash = new("A0217: Invalid length of password hash(64 bytes expected).");
        public static readonly ApiMessage ErrUserPasswordSalt = new("A0218: Invalid length of password salt(128 bytes expected).");
        public static readonly ApiMessage ErrUserPermission = new("A0219: Could not get user permission.");
        public static readonly ApiMessage ErrUserNotFound = new("A0220: User not found");
        public static readonly ApiMessage ErrUserResetPassword = new("A0221: Reset password failed");
        public static readonly ApiMessage ErrUserMissingUsercode = new("A0222: User Code is missing");
        public static readonly ApiMessage UserAlreadyExists = new("A0223: User already exists.");
        public static readonly ApiMessage ErrUserCurrentPassword = new("A0225: Current password is missing");
        public static readonly ApiMessage ErrUserModifyUser = new("A0226: Updating user profile failed");
        public static readonly ApiMessage ErrUserEmptyCountryAdmin = new("A0227: Country Admin must be set to true.");
        public static readonly ApiMessage ErrUserMissingUserTypeCode = new("A0228: User Type Code is missing ");
        public static readonly ApiMessage ErrUserNotFoundUserType = new("A0229: User Type Code not found.");
        public static readonly ApiMessage ErrUserMissingEmail = new("A0230: Email address is missing");
        public static readonly ApiMessage ErrUserNotFoundMenuUser = new("A0231: Menu is not setup for this user role");
        public static readonly ApiMessage ErrUserFromUserCode = new("A0232: From Usercode is missing");
        public static readonly ApiMessage ErrUserToUserCode = new("A0233: To Usercode is missing");
        public static readonly ApiMessage ErrUserConfirmPassword = new("A0234: Confirm password is missing");
        public static readonly ApiMessage ErrUserMatchPassword = new("A0235: Password and Confirm Password do not match");
        public static readonly ApiMessage ErrUserUserName = new("A0236: User Name is missing");
        public static readonly ApiMessage ErrUserChangePassword = new("A0237: Change password failed");
        public static readonly ApiMessage ErrUserNewPassword = new("A0238: New Password is missing");
        public static readonly ApiMessage ErrInvalidCulture = new("A0239: Invalid culture");
        public static readonly ApiMessage InvalidPasswordOnUpdatePassword = new("A0240: Password is incorrect.");
        public static readonly ApiMessage ErrNewPasswordIsSameAsOld = new("A0241: New Password must be different.");
        public static readonly ApiMessage ErrNewPasswordUppercaseLetter = new("A0241: Password requires at least one upper case character");
        public static readonly ApiMessage ErrNewPasswordLowercaseLetter = new("A0241: Password requires at least one lower case character");
        public static readonly ApiMessage ErrNewPasswordDigit = new("A0241: Password requires at least one digit");
        public static readonly ApiMessage ErrNewPasswordSpecialCharacter = new("A0241: Password requires at least one special character");
        public static readonly ApiMessage ErrNewPasswordHasInvalidSpecialCharacter = new("A0241: Password can only have alphanumeric characters.");
        public static readonly ApiMessage AccountNotFound = new("A0260: Account not found.");
        public static readonly ApiMessage AccountDetailsNotFound = new("A0261: AccountDetails not found.");
        public static readonly ApiMessage AccountCodeRequired = new("A0262: AccountCode is required.");

        public static ApiMessage DeliveryLocationNotFound(string suburb, string postcode, string state) => new($"A0051: delivery address is invalid for combination for postcode:{postcode} suburb:{suburb} state:{state}");
    }
}