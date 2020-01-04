using System;

namespace FileHelpers.Fields
{
    /// <summary>
    /// add validation exceptions
    /// </summary>
    internal static class ExHelper
    {
        /// <summary>
        /// Check an integer value is positive (0 or greater)
        /// </summary>
        /// <param name="val">Integer to test</param>
        public static void PositiveValue(int val)
        {
            if (val < 0)
                throw new ArgumentException("The value must be greater than or equal to 0.");
        }
    }
}