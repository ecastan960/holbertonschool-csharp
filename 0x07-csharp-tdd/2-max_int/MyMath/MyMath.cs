using System;
using System.Collections.Generic;

namespace MyMath
{
    /// <summary>
    /// Math class operation
    /// </summary>
    public class Operations
    {
        /// <summary>
        /// Method to find the max. integer in a list
        /// </summary>
        /// <param name="nums">List to search</param>
        /// <returns>max. integer in list</returns>
        public static int Max(List<int> nums)
        {
            if (nums.Count == 0 || nums == null)
            {
                return 0;
            }
            int max = nums[0];
            foreach (int num in nums)
            {
                if (num > max)
                {
                    max = num;
                }
            }
            return max;
        }
    }
}
