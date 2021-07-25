using CompanyCode.ApiTemplate.Api.Models.Auth;
using CompanyCode.ApiTemplate.Common.Models;

using FluentValidation;

namespace CompanyCode.ApiTemplate.Api.FluentValidators.Auth
{
    public class UpdatePasswordValidator : AbstractValidator<UpdatePasswordRequest>
    {
        public UpdatePasswordValidator()
        {
            RuleFor(m => m.OldPassword)
                .NotEmpty()
                .WithMessage(ErrorMessages.ErrUserMissingPassword.ToString());
            RuleFor(m => m.NewPassword)
                .NewPassword(8, 30);
        }
    }
}