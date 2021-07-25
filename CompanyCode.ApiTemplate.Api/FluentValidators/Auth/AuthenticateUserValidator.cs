using CompanyCode.ApiTemplate.Api.Models.Auth;

using FluentValidation;

namespace CompanyCode.ApiTemplate.Api.FluentValidators.Auth
{
    public class AuthenticateUserValidator : AbstractValidator<AuthenticateUserRequest>
    {
        public AuthenticateUserValidator()
        {
            RuleFor(m => m.Username)
                .NotEmpty()
                .WithMessage("A0300: Username is required")
                .Length(3, 8)
                .WithMessage("A0301: Username must be between 3 and 8 characters");
            RuleFor(m => m.Password)
                .Password();
        }
    }
}