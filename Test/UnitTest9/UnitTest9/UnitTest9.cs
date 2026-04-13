using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UnitTest1;

namespace UnitTest9
{
    [TestClass]
    public class UnitTest9
    {
        [TestMethod]
        public void TestMethodFirstPositive()
        {
            string result = new StringOperations().FirstChar("выхухоль");

            Assert.AreEqual("в", result);
        }

        [TestMethod]
        public void TestMethodFirstNegative()
        {
            string result = new StringOperations().FirstChar("бравл-старс");

            Assert.AreNotEqual("ш", result);
        }

        [TestMethod]
        public void TestMethodLastPositive()
        {
            string result = new StringOperations().LastChar("изподвыподверта");

            Assert.AreEqual("а", result);
        }

        [TestMethod]
        public void TestMethodLastNegative()
        {
            string result = new StringOperations().LastChar("темно-голубой");

            Assert.AreNotEqual("т", result);
        }
    }
}
