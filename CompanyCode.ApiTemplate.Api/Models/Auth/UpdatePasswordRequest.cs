namespace CompanyCode.ApiTemplate.Api.Models.Auth
{
    public class UpdatePasswordRequest
    {
        /// <summary>
        ///     NewPassword
        /// </summary>
        /// <example>NewPassword1!</example>
        public string NewPassword { get; set; }

        /// <summary>
        ///     OldPassword
        /// </summary>
        /// <example>YourOldPassword1!</example>
        public string OldPassword { get; set; }
    }
}