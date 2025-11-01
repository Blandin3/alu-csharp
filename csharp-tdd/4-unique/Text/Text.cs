using System;
using System.Collections.Generic;

namespace Text
{
    /// <summary>
    /// Class for string operations
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Finds the index of the first unique character in a string
        /// </summary>
        /// <param name="s">String to search</param>
        /// <returns>Index of first unique character, or -1 if none found</returns>
        public static int UniqueChar(string s)
        {
            if (string.IsNullOrEmpty(s))
                return -1;

            // Dictionary to store character counts
            var counts = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                counts[c] = counts.ContainsKey(c) ? counts[c] + 1 : 1;
            }

            // Find index of first non-repeating character
            for (int i = 0; i < s.Length; i++)
            {
                if (counts[s[i]] == 1)
                    return i;
            }

            return -1; // No unique character found
        }
    }
}


