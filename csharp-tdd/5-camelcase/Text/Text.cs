using System;

namespace Text
{
    /// <summary>
    /// Class for string operations
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Counts the number of words in a camelCase string
        /// </summary>
        /// <param name="s">CamelCase string to analyze</param>
        /// <returns>Number of words in the camelCase string</returns>
        public static int CamelCase(string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;

            int count = 1; // Always at least 1 word if string is not empty

            for (int i = 1; i < s.Length; i++) // Start from index 1
            {
                if (char.IsUpper(s[i]))
                    count++;
            }

            return count;
        }
    }
}

