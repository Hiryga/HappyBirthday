using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UnitTest1;

namespace UnitTest6
{
    [TestClass]
    public class UnitTest6
    {
        [TestMethod]
        public void TestMethodReversePositive()
        {
            string result = new StringOperations().Reverse("mom");

            Assert.AreEqual("mom", result);

        }

        [TestMethod]
        public void TestMethodReverseNegative()
        {
            string result = new StringOperations().Reverse("mom");

            Assert.AreNotEqual("mob", result);

        }

        [TestMethod]
        public void TestMethodLengthPositive()
        {
            int result = new StringOperations().GetLength("mother");

            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void TestMethodLengthNegative()
        {
            int result = new StringOperations().GetLength("mom");

            Assert.AreNotEqual(5, result);

        }
    }
}
