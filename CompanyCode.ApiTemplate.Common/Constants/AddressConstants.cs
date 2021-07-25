using System.Collections.Generic;

namespace CompanyCode.ApiTemplate.Common.Constants
{
    public static class AddressConstants
    {
        public const string Pick = "Pickup";
        public const string Deliver = "Delivery";

        public static IReadOnlyList<string> States { get; } = new List<string>
        {
            "NSW", "QLD", "SA", "TAS", "VIC", "WA", "ACT", "NT"
        };
    }
}