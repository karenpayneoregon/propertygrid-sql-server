using System;
using System.Text.RegularExpressions;

namespace PropertyGridConverterExample1.Classes
{
    public class WebAddressHelper
    {
        public static bool UrlChecker1(string url)
        {
            bool tryCreateResult = Uri.TryCreate(url, UriKind.Absolute, out var uriResult);
            return tryCreateResult && uriResult != null;
        }
        public static bool UrlChecker2(string url) => Uri.IsWellFormedUriString(url, UriKind.Absolute);
        public static bool UrlChecker3(string url)
        {
            var pattern = @"^(?:http(s)?:\/\/)?[\w.-]+(?:\.[\w\.-]+)+[\w\-\._~:/?#[\]@!\$&'\(\)\*\+,;=.]+$";
            var regex = new Regex(pattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);
            return regex.IsMatch(url);
        }
    }
}
