using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UnitTest1;

namespace UnitTest3
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestMethodSubstractPositive()
        {
            double result = new MathOperations().Substract(2, 2);

            Assert.AreEqual(0, result);

        }

        [TestMethod]
        public void TestMethodSubstractNegative()
        {
            double result = new MathOperations().Substract(2, 2);

            Assert.AreNotEqual(3, result);
        }

        [TestMethod]
        public void TestMethodAbsPositive()
        {
            double result = new MathOperations().Abs(2);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void TestMethodAbsNegative()
        {
            double result = new MathOperations().Abs(-2);

            Assert.AreNotEqual(-2, result);
        }
    }
}
