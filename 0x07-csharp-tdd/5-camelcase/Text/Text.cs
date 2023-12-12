using System;

namespace Text
{
    /// <summary>
    /// Class Str method
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Method to count number of words in a string
        /// </summary>
        /// <param name="s">String to evaluate</param>
        /// <returns></returns>
        public static int CamelCase(string s)
        {
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == char.ToUpper(s[i]) && s[i] != ' ') count++;
            }
            return count;
        }
    }
}
