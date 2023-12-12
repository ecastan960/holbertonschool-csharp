using System;
using System.Linq;

namespace Text
{
    /// <summary>
    /// Text class operation
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Method to check if a string is a palindrome
        /// </summary>
        /// <param name="s">String to check</param>
        /// <returns></returns>
        public static bool IsPalindrome(string s)
        {
            bool invalidChar(char n)
            {
                if (Char.IsPunctuation(n) || n == ' ') return false;
                return true;
            }
            if (s.Length <= 1) return true;
            s = s.ToLower();
            char[] charArr = s.ToCharArray();
            charArr = Array.FindAll(charArr, invalidChar).ToArray();
            int j = charArr.Length - 1;
            for (int i = 0; i < j; i++)
            {
                if (charArr[i] != charArr[j]) return false;
                j--;
            }
            return true;
        }
    }
}
