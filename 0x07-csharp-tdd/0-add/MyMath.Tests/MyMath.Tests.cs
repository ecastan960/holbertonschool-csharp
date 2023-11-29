using System.Reflection;
using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    public class AddTests
    {
        [Test]
        public void sum()
        {
            int a = 4;
            int b = 7;
            Assert.AreEqual(11, MyMath.Operations.Add(a, b));
        }


        [TestCase(-10, -30)]
        [TestCase(-10, 25)]
        public void sumCases(int a, int b)
        {
            Assert.AreEqual(a + b, MyMath.Operations.Add(a, b));
        }
    }
}