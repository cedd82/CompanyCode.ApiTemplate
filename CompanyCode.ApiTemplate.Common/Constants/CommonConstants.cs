namespace CompanyCode.ApiTemplate.Common.Constants
{
    public static class CommonConstants
    {
        public static class DateFormats
        {
            public static readonly string[] IsoDates = {"yyyy-MM-ddTHH:mm:ss zzz", "yyyy-MM-ddTHH:mm:sszzz"};
        }

        public static class MessageLevel
        {
            public const int Error = 1;
            public const int Warn = 2;
            public const int Information = 3;
        }

        public readonly struct CustomClaims
        {
            public const string UserTypeCode = "UserTypeCode";
            public const string CompanyCode = "CompanyCode";
        }

        public static class AuthRoles
        {
            public const string CevaSiteOperator = "CSO";
            public const string CevaSiteSupervisor = "CSS";
            public const string CevaSiteAdmin = "CSA";
            public const string BillingAdmin = "BIL";
            public const string WharfOperatorMobile = "MWO";
            public const string YardOperatorMobile = "MYO";
            public const string Driver = "DRV";
            public const string RailYardStaff = "RST";
            public const string Agent = "AGT";
        }
    }
}