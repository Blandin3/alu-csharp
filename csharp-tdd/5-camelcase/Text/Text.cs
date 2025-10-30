using System;

namespace Text
{
    public class Str
    {
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

