using CompanyCode.ApiTemplate.Common.Models;

using FluentValidation;

namespace CompanyCode.ApiTemplate.Api.FluentValidators
{
    public static class RuleBuilderExtensions
    {
        public static IRuleBuilder<T, string> NewPassword<T>(this IRuleBuilder<T, string> ruleBuilder, int minLength = 8, int maxLength = 30)
        {
            IRuleBuilderOptions<T, string> options = ruleBuilder
                .NotEmpty()
                .WithMessage(ErrorMessages.ErrUserMissingPassword.ToString())
                .MinimumLength(minLength)
                .WithMessage($"{ErrorMessages.ErrUserPasswordLengthRange} {minLength} characters and not more than {maxLength}")
                .Matches("[A-Z]")
                .WithMessage(ErrorMessages.ErrNewPasswordUppercaseLetter.ToString())
                .Matches("[a-z]")
                .WithMessage(ErrorMessages.ErrNewPasswordLowercaseLetter.ToString())
                .Matches("[0-9]")
                .WithMessage(ErrorMessages.ErrNewPasswordDigit.ToString())
                .Matches(@"[^a-zA-Z0-9]")
                .WithMessage(ErrorMessages.ErrNewPasswordSpecialCharacter.ToString());
            return options;
        }

        public static IRuleBuilder<T, string> Password<T>(this IRuleBuilder<T, string> ruleBuilder, int minLength = 8, int maxLength = 30)
        {
            IRuleBuilderOptions<T, string> options = ruleBuilder
                .NotEmpty()
                .WithMessage(ErrorMessages.ErrUserMissingPassword.ToString())
                .Length(minLength, maxLength)
                .WithMessage(ErrorMessages.ErrUserPassword.ToString());
            return options;
        }
    }
}