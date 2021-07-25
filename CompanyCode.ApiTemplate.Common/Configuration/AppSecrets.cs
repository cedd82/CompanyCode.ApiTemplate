namespace CompanyCode.ApiTemplate.Common.Configuration
{
    public class AppSecrets
    {
        public string IngresDatabaseConnection { get; set; }
        public string JwtSymmetricKey { get; set; }
        public string PostgresDatabaseConnection { get; set; }
        public bool SwaggerBasicAuthIsEnabled { get; set; }
        public string SwaggerBasicAuthPassword { get; set; }
        public string SwaggerBasicAuthUserName { get; set; }
    }
}