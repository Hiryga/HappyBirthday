using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UnitTest1;

namespace UnitTest4
{
    [TestClass]
    public class UnitTest4
    {
        [TestMethod]
        public void TestMethodSquarePositive()
        {
            double result = new MathOperations().Square(2);

            Assert.AreEqual(4, result);

        }

        [TestMethod]
        public void TestMethodSquareNegative()
        {
            double result = new MathOperations().Square(2);

            Assert.AreNotEqual(3, result);

        }

        [TestMethod]
        public void TestMethodCubePositive()
        {
            double result = new MathOperations().Cube(2);

            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void TestMethodCubeNegative()
        {
            double result = new MathOperations().Cube(2);

            Assert.AreNotEqual(-2, result);
        }
    }
}
