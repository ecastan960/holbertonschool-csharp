using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests
    {

        [Test]
        public void camelCaseCheck2Words()
        {
            string s = "Ice Cream";
            Assert.AreEqual(2, Text.Str.CamelCase(s));
        }

        [Test]
        public void camelCaseCheck3Words()
        {
            string s = "Hello Mono World";
            Assert.AreEqual(3, Text.Str.CamelCase(s));
        }
    }
}
