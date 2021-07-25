namespace CompanyCode.ApiTemplate.Api.Models.Auth
{
    public class AuthenticateUserResponse
    {
        /// <example>eyJhbGc.Ppmh4c4ELUpzDJyde8.SXbFSjEqre.l1p1UsR.....</example>
        public string AccessToken { get; set; }

        /// <example>username</example>
        public string UserName { get; set; }
    }
}