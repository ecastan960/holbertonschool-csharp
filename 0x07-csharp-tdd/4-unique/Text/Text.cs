using System;

namespace Text
{
    /// <summary>
    /// String Class
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Function that returns index of non-repeating character of a string
        /// </summary>
        /// <param name="s">input string</param>
        /// <returns></returns>
        public static int UniqueChar(string s)
        {
            int flag = 0;
            if (s.Length == 0) return -1;
            if (s.Length == 1) return 0;
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < s.Length; j++)
                {
                    if (i == j) continue;
                    if (s[i] == s[j]) flag = 1;
                }
                if (flag != 1) return i;
                flag = 0;
            }
            return -1;
        }
    }
}
