using System;
using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    public class DivTests
    {

        [Test]
        public void divMatrix()
        {
            int[,] matrix = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
            int num = 3;
            Assert.AreEqual(new int[4, 2] { { 0, 0 }, { 1, 1 }, { 1, 2 }, { 2, 2 } }, MyMath.Matrix.Divide(matrix, num));
        }

        [Test]
        public void nullMatrix()
        {
            int[,] matrix = null;
            Assert.AreEqual(null, MyMath.Matrix.Divide(matrix, 3));
        }

        [Test]
        public void zeroDiv()
        {
            int[,] matrix = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
            int num = 0;
            Assert.AreEqual(null, MyMath.Matrix.Divide(matrix, num));
        }
    }
}