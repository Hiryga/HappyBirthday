using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UnitTest1;

namespace UnitTest2
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethodSumPositive()
        {
            double result = new MathOperations().Sum(2, 2);

            Assert.AreEqual(4, result);
        
        }

        [TestMethod]
        public void TestMethodSumNegative()
        {
            double result = new MathOperations().Sum(2, 2);

            Assert.AreNotEqual(3, result);
        }

        [TestMethod]
        public void TestMethodMultiPositive()
        {
            double result = new MathOperations().Multiply(2, 2);

            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void TestMethodMultiNegative()
        {
            double result = new MathOperations().Multiply(2, 2);

            Assert.AreNotEqual(5, result);
        }
    }
}
