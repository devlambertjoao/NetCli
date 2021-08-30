using System.Collections.Generic;

namespace Lambert.Domain.Extensions
{
    public static class IEnumerableExtensions
    {
        public static string SplitComma(this IList<string> list)
        {
            string str = string.Empty;
            foreach (string item in list)
            {
                str += $"{item}, ";
            }
            str += ".";

            return str.Replace(", .", ".");
        }
    }
}
