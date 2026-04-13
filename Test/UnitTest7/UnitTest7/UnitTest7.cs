using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UnitTest1;

namespace UnitTest7
{
    [TestClass]
    public class UnitTest7
    {
        [TestMethod]
        public void TestMethodUpperPositive()
        {
            string result = new StringOperations().ToUpperCase("студент");

            Assert.AreEqual("СТУДЕНТ", result);
        }

        [TestMethod]
        public void TestMethodUpperNegative()
        {
            string result = new StringOperations().ToUpperCase("студент");

            Assert.AreNotEqual("сТудент", result);
        }

        [TestMethod]
        public void TestMethodLowerPositive()
        {
            string result = new StringOperations().ToLowerCase("Преподаватель");

            Assert.AreEqual("преподаватель", result);
        }

        [TestMethod]
        public void TestMethodLowerNegative()
        {
            string result = new StringOperations().ToLowerCase("Земля");

            Assert.AreNotEqual("ОСТРОВ", result);
        }
    }
}
