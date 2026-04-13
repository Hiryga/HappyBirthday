using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UnitTest1;

namespace UnitTest8
{
    [TestClass]
    public class UnitTest8
    {
        [TestMethod]
        public void TestMethodConcatPositive()
        {
            string result = new StringOperations().Concat("добрый ", "котик");

            Assert.AreEqual("добрый котик", result);
        }

        [TestMethod]
        public void TestMethodConcatNegative()
        {
            string result = new StringOperations().Concat("добрый ", "котик");

            Assert.AreNotEqual("добрый пудель", result);
        }

        [TestMethod]
        public void TestMethodLowerPositive()
        {
            bool result = new StringOperations().Contains("Крутой велик", "велик");

            Assert.AreEqual(true , result);
        }

        [TestMethod]
        public void TestMethodLowerNegative()
        {
            bool result = new StringOperations().Contains("Земля круглая", "Вода");

            Assert.AreNotEqual(0, result);
        }
    }
}
