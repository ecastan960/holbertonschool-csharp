using NUnit.Framework;
using System.Collections.Generic;

namespace MyMath.Tests
{
    [TestFixture]
    public class MaxTests
    {

        [Test]
        public void MaxTest()
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            Assert.AreEqual(4, MyMath.Operations.Max(list));
        }

        [Test]
        public void zeroTest()
        {
            List<int> list = new List<int>();
            Assert.AreEqual(0, MyMath.Operations.Max(list));
        }
    }
}