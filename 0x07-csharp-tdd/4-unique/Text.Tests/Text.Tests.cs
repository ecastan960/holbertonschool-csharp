using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void checkUniqueChar()
        {
            string s = "geeksforgeeks";
            Assert.AreEqual(5, Text.Str.UniqueChar(s));
        }

        [Test]
        public void checkRepeatChar()
        {
            string s = "aaaaaa";
            Assert.AreEqual(-1, Text.Str.UniqueChar(s));
        }
    }
}
