using CompanyCode.ApiTemplate.Common.Models;

namespace CompanyCode.ApiTemplate.Common.ErrorMessages
{
    public static class CommonErrorMessages
    {
        public static readonly ApiMessage ApiException = new("A0000", "Unknown error");
        public static readonly ApiMessage DatabaseException = new("A0001", "DB exception");
        public static readonly ApiMessage RequestModelValidationError = new("A0002", "Request Model Validation Error");
        public static readonly ApiMessage UnableToSendEmail = new("A0003: Unable To Send Email.");
        public static readonly ApiMessage InvalidSpecialCharacter = new("A0004", "Only alphanumeric characters are allowed.");
    }
}