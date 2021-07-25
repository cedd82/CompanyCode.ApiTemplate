using CompanyCode.ApiTemplate.Common.Constants;

namespace CompanyCode.ApiTemplate.Common.Models
{
    public class Result
    {
        public ApiMessage Message { get; private set; }
        public bool Success() => Message == null;
        public bool Failure() => Message != null;
        public bool Warning() => Message?.Level == CommonConstants.MessageLevel.Warn;
        public bool Info() => Message?.Level == CommonConstants.MessageLevel.Information;
        public Result() { }

        public Result(string code, string message, int level = CommonConstants.MessageLevel.Error)
        {
            Message = new ApiMessage(code, message, level);
        }

        public Result(ApiMessage apiMessage)
        {
            Message = apiMessage;
        }

        public static Result Fail(ApiMessage message) => new(message);
        public static Result Fail(string code, string message, int level = CommonConstants.MessageLevel.Error) => new(code, message, level);
        public static Result Fail(string message, int level = CommonConstants.MessageLevel.Error) => new("", message, level);
        public static Result<T> Fail<T>(ApiMessage message) => new(message);
        public static Result<T> Ok<T>(T value) => new(value);
        public static Result Ok() => new();
    }

    public class Result<T> : Result
    {
        public T Value { get; set; }
        public Result(ApiMessage apiMessage) : base(apiMessage) { }
        public Result(string message, int level = CommonConstants.MessageLevel.Error) : base(new ApiMessage(message, level)) { }

        public Result(T value)
        {
            Value = value;
        }

        public Result()
        {
            Value = default;
        }
    }
}