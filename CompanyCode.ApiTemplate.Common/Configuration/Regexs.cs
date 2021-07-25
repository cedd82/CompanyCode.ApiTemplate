using System.Text.RegularExpressions;

namespace CompanyCode.ApiTemplate.Common.Configuration
{
    public static class QuoteRegex
    {
        public static readonly Regex TransportChargeRegex = new(@"##T\$\s*(?<transportCharge>\d*\.\d*)T##", RegexOptions.Compiled | RegexOptions.Multiline);
        public static readonly Regex InsuranceChargeRegex = new(@"##I\$\s*(?<insuranceCharge>\d*\.\d*)I##", RegexOptions.Compiled | RegexOptions.Multiline);
        public static readonly Regex SurchargeRegex = new(@"##S\$\s*(?<surcharge>\d*\.\d*)S##", RegexOptions.Compiled | RegexOptions.Multiline);
        public static readonly Regex GstRegex = new(@"##G(?<gst>\d*\.\d*)G##", RegexOptions.Compiled | RegexOptions.Multiline);
        public static readonly Regex MiscChargeRegex = new(@"##M\$\s*(?<miscCharge>\d*\.\d*)M##", RegexOptions.Compiled | RegexOptions.Multiline);
        public static readonly Regex TransitDaysRegex = new(@"##D\s*(?<transitDays>\d*)D##", RegexOptions.Compiled | RegexOptions.Multiline);
        public static readonly Regex PickUpDepotRegex = new(@"##1(?<pickupDepot>.{3})1##", RegexOptions.Compiled | RegexOptions.Multiline);
        public static readonly Regex DeliverDepotRegex = new(@"##2(?<deliverDepot>.{3})2##", RegexOptions.Compiled | RegexOptions.Multiline);
        public static readonly Regex RingCodeRegex = new(@"##R(?<ringCode>.{3})R##", RegexOptions.Compiled | RegexOptions.Multiline);
        public static readonly Regex RateCodeRegex = new(@"##A(?<rateCode>.{3})A##", RegexOptions.Compiled | RegexOptions.Multiline);
        public static readonly Regex RateRouteCodeRegex = new(@"##O(?<rateRouteCode>.{3})O##", RegexOptions.Compiled | RegexOptions.Multiline);
        public static readonly Regex IsDiscountRegex = new(@"##C(?<isDiscount>.{1})C##", RegexOptions.Compiled | RegexOptions.Multiline);
    }
}
