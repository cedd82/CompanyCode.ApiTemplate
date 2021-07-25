using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyCode.ApiTemplate.Common.ExtensionMethods
{
    public static class DateTimeExtensions
    {
        public static DateTime ToNoLocale(this DateTime date) => DateTime.SpecifyKind(date, DateTimeKind.Unspecified);
        public static string ToStringNoLocale(this DateTime localDate, string formatter = "s") => DateTime.SpecifyKind(localDate, DateTimeKind.Unspecified).ToString(formatter);
        public static DateTime ToDateTimeNoLocale(this string date, string formatter = "s")
        {
            return DateTime.ParseExact(date, formatter, CultureInfo.InvariantCulture);
        }
        
        public static string ToIngresDateTime(this DateTime value)
        {
            return DateTime.SpecifyKind(value, DateTimeKind.Unspecified).ToString("yyyy-MM-dd HH:mm:ss");
        }

        public static string ToIngresDate(this DateTime value)
        {
            return DateTime.SpecifyKind(value, DateTimeKind.Unspecified).ToString("yyyy-MM-dd");
        }
        
    }
}
