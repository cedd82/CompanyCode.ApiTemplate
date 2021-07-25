using System;
using System.Linq;

using FluentValidation;

namespace CompanyCode.ApiTemplate.Api.ExtensionMethods
{
    //https://stackoverflow.com/questions/33959323/checking-if-parameter-is-one-of-3-values-with-fluent-validation
    public static class FluentValidatorExtensions
    {
        public static IRuleBuilderOptions<T, TProperty> In<T, TProperty>(this IRuleBuilder<T, TProperty> ruleBuilder, params TProperty[] validOptions)
        {
            string formatted;
            if (validOptions == null || validOptions.Length == 0)
                throw new ArgumentException("At least one valid option is expected", nameof(validOptions));
            if (validOptions.Length == 1)
                formatted = validOptions[0].ToString();
            else
                formatted = $"{string.Join(", ", validOptions.Select(vo => vo.ToString()).ToArray(), 0, validOptions.Length - 1)} or {validOptions.Last()}";

            return ruleBuilder
                .Must(validOptions.Contains)
                .WithMessage("{PropertyName} is not valid");
        }
    }
}