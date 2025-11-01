using System;
using System.Collections.Generic;

namespace MyMath
{
    /// <summary>
    /// Class for mathematical operations
    /// </summary>
    public class Operations
    {
        /// <summary>
        /// Finds the maximum value in a list of integers
        /// </summary>
        /// <param name="nums">List of integers</param>
        /// <returns>Maximum value, or 0 if list is null or empty</returns>
        public static int Max(List<int> nums)
        {
            if (nums == null || nums.Count == 0)
                return 0;

            int max = nums[0];
            foreach (int n in nums)
            {
                if (n > max)
                    max = n;
            }

            return max;
        }
    }
}

