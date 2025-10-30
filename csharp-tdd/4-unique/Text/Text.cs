using System;
using System.Collections.Generic;

namespace Text
{
    public class Str
    {
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


