using System;
using System.Globalization;

namespace _7_islower
{
    class Character
    {
        public static bool IsLower(char c)
        {
            string s1 = CharUnicodeInfo.GetUnicodeCategory(c).ToString();
            if (s1 == "LowercaseLetter")
            {
                return true;
            }
            return false;
        }
    }
}
