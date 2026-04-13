using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UnitTest1;

namespace UnitTest5
{
    [TestClass]
    public class UnitTest5
    {
        [TestMethod]
        public void TestMethodMaxPositive()
        {
            double result = new MathOperations().Max(2,3);

            Assert.AreEqual(3, result);

        }

        [TestMethod]
        public void TestMethodMaxNegative()
        {
            double result = new MathOperations().Max(2,4);

            Assert.AreNotEqual(2, result);

        }

        [TestMethod]
        public void TestMethodMinPositive()
        {
            double result = new MathOperations().Min(2,3);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void TestMethodMinNegative()
        {
            double result = new MathOperations().Min(2,5);

            Assert.AreNotEqual(5, result);
        }
    }
}
