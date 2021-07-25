using System.Text.RegularExpressions;

using CompanyCode.ApiTemplate.Api.Models.Auth;

using FluentValidation;

namespace CompanyCode.ApiTemplate.Api.FluentValidators.Auth
{
    public class CreateUserRequestValidator : AbstractValidator<CreateUserRequest>
    {
        public CreateUserRequestValidator()
        {
            RuleFor(m => m.Password)
                .NewPassword(8, 30);
            RuleFor(m => m.Username)
                .NotEmpty()
                .WithMessage("A0351: Username is required")
                .Length(3, 8)
                .WithMessage("A0352: Username must be between 3 and 8 characters")
                .Matches(@"^\w+$", RegexOptions.IgnoreCase)
                .WithMessage("A0353: Username must be characters in range [a-z][A-Z]");
            RuleFor(m => m.FirstName)
                .NotEmpty()
                .WithMessage("A0354: FirstName is required")
                .Length(2, 15)
                .WithMessage("A0355: FirstName must be between 3 and 8 characters")
                .Matches(@"^\w+$", RegexOptions.IgnoreCase)
                .WithMessage("A0356: FirstName must be characters in range [a-z][A-Z]");
            RuleFor(m => m.LastName)
                .NotEmpty()
                .WithMessage("A0357: LastName is required")
                .Length(2, 15)
                .WithMessage("A0358: LastName must be between 3 and 8 characters")
                .Matches(@"^\w+$", RegexOptions.IgnoreCase)
                .WithMessage("A0359: LastName must be characters in range [a-z][A-Z]");
            RuleFor(m => m.EmailAddress)
                .EmailAddress()
                .WithMessage("A0360: Invalid emailAddress");
            RuleFor(m => m.MobileNumber)
                .NotEmpty()
                .WithMessage("A0361: MobileNumber is required")
                .Length(10)
                .WithMessage("A0362: MobileNumber must be 10 characters")
                .Matches(@"^\d{10}$")
                .WithMessage("A0363: MobileNumber must be a number 10 digits long");
        }
    }
}
