using System.Net.Mime;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void palindromeCorrectCheck()
        {
            string s = "madam";
            Assert.AreEqual(true, Text.Str.IsPalindrome(s));
            s = "Racecar ";
            Assert.AreEqual(true, Text.Str.IsPalindrome(s));
            s = "level ";
            Assert.AreEqual(true, Text.Str.IsPalindrome(s));
            s = "A man, a plan, a canal: Panama.";
            Assert.AreEqual(true, Text.Str.IsPalindrome(s));
        }

        [Test]
        public void palindromeIncorrectCheck()
        {
            string s = "madama";
            Assert.AreEqual(false, Text.Str.IsPalindrome(s));
        }

        [Test]
        public void palindromeemptyCheck()
        {
            string s = "";
            Assert.AreEqual(true, Text.Str.IsPalindrome(s));
        }
    }
}