using System;
using System.Globalization;
using System.Linq;

using CompanyCode.ApiTemplate.Common.Constants;

namespace CompanyCode.ApiTemplate.Common.ExtensionMethods
{
    public static class StringExtensions
    {
        public static DateTime ToDateTimeNoLocale(this string date, string formatter = "s") => DateTime.ParseExact(date, formatter, CultureInfo.InvariantCulture);

        public static bool IsJson(this string input)
        {
            input = input.Trim();
            return input.StartsWith("{") && input.EndsWith("}")
                   || input.StartsWith("[") && input.EndsWith("]");
        }

        public static bool IsValidAustralianState(this string value)
        {
            if (string.IsNullOrEmpty(value))
                return false;
            value = value.ToUpper().Trim();
            return AddressConstants.States.Contains(value);
        }

        public static (string, string) FormatPhoneNumber(this string value)
        {
            string phoneAreaCode = string.Empty;
            string phone;
            if (string.IsNullOrEmpty(value))
                return (phoneAreaCode, value);
            if (value.Trim().Length > 8)
            {
                phone = value.ToUpper().Replace(" ", "");
                if (phone.StartsWith("0"))
                    phoneAreaCode = phone.ToUpper().Trim().Substring(0, 2);
                int phoneLen = 8;
                if (phone.Length < 10)
                    phoneLen = phone.Length - 2;
                phone = phone.Substring(2, phoneLen);
            }
            else
                phone = value.Trim().ToUpper();

            return (phoneAreaCode, phone);
        }
        
        public static string MapState(this string value)
        {
            if (string.IsNullOrEmpty(value))
                return value;
            value = value.ToUpper().Trim();
            return value switch
            {
                "NEW SOUTH WALES" => "NSW",
                "QUEENSLAND" => "QLD",
                "SOUTH AUSTRALIA" => "SA",
                "TASMANIA" => "TAS",
                "VICTORIA" => "VIC",
                "WESTERN AUSTRALIA" => "WA",
                "AUSTRALIAN CAPITAL TERRITORY" => "ACT",
                "NORTHERN TERRITORY" => "NT",
                _ => value
            };
        }

        public static bool ToBoolean(this string value)
        {
            if (string.IsNullOrEmpty(value))
                return false;
            value = value.Trim().ToUpper();
            return value switch
            {
                "TRUE" => true,
                "YES" => true,
                "Y" => true,
                "1" => true,
                "FALSE" => false,
                "NO" => false,
                "N" => false,
                "0" => false,
                _ => false
            };
        }

        public static string ToIngresDateString(this string value)
        {
            if (DateTime.TryParse(value, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime outDate))
                outDate = DateTime.Now;

            return outDate.ToString("yyyy-MM-dd HH:mm:ss");
        }

        public static string ToIngresDateStringAddSecond(this string value)
        {
            if (DateTime.TryParse(value, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime outDate))
                outDate = DateTime.Now;

            outDate = outDate.AddSeconds(1);
            return outDate.ToString("yyyy-MM-dd HH:mm:ss");
        }

        public static string ToIngresString(this string value) => !string.IsNullOrEmpty(value) ? value.Replace("'", "''") : string.Empty;
        public static string Truncate(this string value, int maxLength)
        {
            if (string.IsNullOrEmpty(value))
                return value;
            return value.Length <= maxLength ? value : value.Substring(0, maxLength);
        }

        public static string TruncateTrim(this string value, int maxLength)
        {
            if (string.IsNullOrEmpty(value))
                return value;
            return value.Length <= maxLength ? value.Trim() : value.Substring(0, maxLength).Trim();
        }
    }
}