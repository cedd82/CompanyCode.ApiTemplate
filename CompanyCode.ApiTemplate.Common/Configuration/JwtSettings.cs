namespace CompanyCode.ApiTemplate.Common.Configuration
{
    public class JwtSettings
    {
        public string Audience { get; set; }
        public string Issuer { get; set; }
        public string JwtPublicKey { get; set; }
        public string Secret { get; set; }
        public int Expiry { get;set; }
    }
}