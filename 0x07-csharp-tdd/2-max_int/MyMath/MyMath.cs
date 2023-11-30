﻿using System;
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
            int max = 0;
            if (nums.Count == 0)
            {
                return max;
            }
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
