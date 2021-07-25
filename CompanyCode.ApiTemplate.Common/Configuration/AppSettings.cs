namespace CompanyCode.ApiTemplate.Common.Configuration
{
    public class AppSettings
    {
        public string ApplicationName { get; set; }
        public string ApplicationVersion { get; set; }
        public bool CapturePostRequestBodyOnError { get; set; }
        public string ContentRootPath { get; set; }
        public string EnvironmentName { get; set; }
        public bool StopAppOnOdbcConnectionFailure { get; set; }
    }
}