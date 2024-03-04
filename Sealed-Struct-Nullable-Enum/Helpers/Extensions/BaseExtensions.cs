using System.Text.RegularExpressions;

namespace Sealed_Struct_Nullable_Enum.Helpers.Extensions
{
    internal static class BaseExtensions
    {
        public static bool CheckStr(this string str, char symbol)
        {
            return str.Contains(symbol);
        }

        public static bool CheckPasswordLength(this string password)
        {
            return password.Length > 8;
        }

        public static bool CheckTextWithRegex(this string str, string pattern)
        {
            return Regex.IsMatch(str, pattern);
        }

        public static int MultiplyArrayItems(this int[] nums)
        {
            int multiply = 1;

            foreach (var item in nums)
            {
                multiply *= item;
            }

            return multiply;
        }
    }
}
