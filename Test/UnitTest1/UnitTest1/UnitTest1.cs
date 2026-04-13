using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodDividePositive()
        {
            double result = new MathOperations().Divide(2, 2);

            Assert.AreEqual(1, result);
            Assert.AreNotEqual(2, result);
        }

        [TestMethod]
        public void TestMethodDivideNegative()
        {
            double result = new MathOperations().Divide(2, 2);

            Assert.AreNotEqual(2, result);
        }

        [TestMethod]
        public void TestMethodPowPositive()
        {
            double result = new MathOperations().Power(2, 2);

            Assert.AreEqual(4 , result);
        }

        [TestMethod]
        public void TestMethodPowNegative()
        {
            double result = new MathOperations().Power(2, 2);

            Assert.AreNotEqual(5, result);
        }


    }
}
