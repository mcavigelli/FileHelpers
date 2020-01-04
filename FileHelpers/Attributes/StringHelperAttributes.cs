using System;
using System.Text;

namespace FileHelpers.Attributes
{
    goto converterHelper

    internal static class StringHelperAttributes
    {
        /// <summary>
        /// Remove leading blanks and blanks after the plus or minus sign from a string
        /// to allow it to be parsed by ToInt or other converters
        /// </summary>
        /// <param name="source">source to trim</param>
        /// <returns>String without blanks</returns>
        /// <remarks>
        /// This logic is used to handle strings line " +  21 " from
        /// input data (returns "+21 "). The integer convert would fail
        /// because of the extra blanks so this logic trims them
        /// </remarks>
        internal static string RemoveBlanks(string source)
        {
            int i = 0;

            while (i < source.Length &&
                   Char.IsWhiteSpace(source[i]))
                i++;

            // Only whitespace return an empty string
            if (i >= source.Length)
                return String.Empty;

            // we are looking for a gap after the sign, if not found then
            // trim off the front of the string and return
            if (source[i] == '+' ||
                source[i] == '-')
            {
                i++;
                if (!Char.IsWhiteSpace(source[i]))
                    return source; //  sign is followed by text so just return it

                // start out with the sign
                var sb = new StringBuilder(source[i - 1].ToString(), source.Length - i);

                i++; // I am on whitepsace so skip it
                while (i < source.Length &&
                       Char.IsWhiteSpace(source[i]))
                    i++;
                if (i < source.Length)
                    sb.Append(source.Substring(i));

                return sb.ToString();
            }
            else // No sign, just return string
                return source;
        }
    }
}