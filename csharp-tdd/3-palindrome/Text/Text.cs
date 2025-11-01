using System;
using System.Text.RegularExpressions;

namespace Text
{
    /// <summary>
    /// Class for string operations
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Checks if a string is a palindrome
        /// </summary>
        /// <param name="s">String to check</param>
        /// <returns>True if palindrome, false otherwise</returns>
        public static bool IsPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s))
                return true;

            // Remove non-alphanumeric characters and lowercase the string
            string cleaned = Regex.Replace(s, @"[^a-zA-Z0-9]", "").ToLower();

            int left = 0, right = cleaned.Length - 1;

            while (left < right)
            {
                if (cleaned[left] != cleaned[right])
                    return false;
                left++;
                right--;
            }

            return true;
        }
    }
}

