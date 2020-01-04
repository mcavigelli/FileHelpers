using System;
using System.Text;

namespace FileHelpers.Engines
{
    /// <summary>
    /// Helper classes for strings
    /// </summary>
    internal static class StringHelper
    {
        /// <summary>
        /// Replace string with another ignoring the case of the string
        /// </summary>
        /// <param name="original">Original string</param>
        /// <param name="oldValue">string to replace</param>
        /// <param name="newValue">string to insert</param>
        /// <returns>string with values replaced</returns>
        public static string ReplaceIgnoringCase(string original, string oldValue, string newValue)
        {
            StringComparison comparisionType = StringComparison.OrdinalIgnoreCase;
            string result = original;

            if (!string.IsNullOrEmpty(oldValue))
            {
                int index = -1;
                int lastIndex = 0;

                var buffer = new StringBuilder(original.Length);

                while ((index = original.IndexOf(oldValue, index + 1, comparisionType)) >= 0)
                {
                    buffer.Append(original, lastIndex, index - lastIndex);
                    buffer.Append(newValue);

                    lastIndex = index + oldValue.Length;
                }
                buffer.Append(original, lastIndex, original.Length - lastIndex);

                result = buffer.ToString();
            }

            return result;
        }

        /// <summary>
        /// Determines whether the beginning of this string instance matches the specified string ignoring white spaces at the start.
        /// </summary>
        /// <param name="source">source string.</param>
        /// <param name="value">The string to compare.</param>
        /// <param name="comparisonType">string comparison type.</param>
        /// <returns></returns>
        public static bool StartsWithIgnoringWhiteSpaces(string source, string value, StringComparison comparisonType)
        {
            if (value == null)
            {
                return false;
            }
            // find lower bound
            int i = 0;
            int sz = source.Length;
            while (i < sz && char.IsWhiteSpace(source[i]))
            {
                i++;
            }
            // adjust upper bound
            sz = sz - i;
            if (sz < value.Length)
                return false;
            sz = value.Length;
            // search
            return source.IndexOf(value, i, sz, comparisonType) == i;
        }
    }
}