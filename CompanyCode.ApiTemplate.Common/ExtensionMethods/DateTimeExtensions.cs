using System;
using System.Globalization;

namespace CompanyCode.ApiTemplate.Common.ExtensionMethods
{
    public static class DateTimeExtensions
    {
        public static DateTime ToDateTimeNoLocale(this string date, string formatter = "s") 
            => DateTime.ParseExact(date, formatter, CultureInfo.InvariantCulture);

        public static string ToIngresDate(this DateTime value) 
            => DateTime.SpecifyKind(value, DateTimeKind.Unspecified).ToString("yyyy-MM-dd");

        public static string ToIngresDateTime(this DateTime value)
            => DateTime.SpecifyKind(value, DateTimeKind.Unspecified).ToString("yyyy-MM-dd HH:mm:ss");

        public static DateTime ToNoLocale(this DateTime date) 
            => DateTime.SpecifyKind(date, DateTimeKind.Unspecified);
        public static string ToStringNoLocale(this DateTime localDate, string formatter = "s") 
            => DateTime.SpecifyKind(localDate, DateTimeKind.Unspecified).ToString(formatter);
    }
}