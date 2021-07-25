namespace CompanyCode.ApiTemplate.Api.Models.Auth
{
    public class AuthenticateUserRequest
    {
        /// <summary>
        ///     password
        /// </summary>
        /// <example>YourPassword1!</example>
        public string Password { get; set; }

        /// <summary>
        ///     username
        /// </summary>
        /// <example>Username</example>
        public string Username { get; set; }
    }
}