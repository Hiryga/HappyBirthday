using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UnitTest1;

namespace UnitTest10
{
    [TestClass]
    public class UnitTest10
    {
        [TestMethod]
        public void TestMethodEmptyPositive()
        {
            bool result = new StringOperations().IsEmpty("выхухоль");

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void TestMethodEmptyNegative()
        {
            bool result = new StringOperations().IsEmpty("");

            Assert.AreNotEqual("ш", result);
        }

        [TestMethod]
        public void TestMethodSpacePositive()
        {
            int result = new StringOperations().CountSpaces("корабли лавировали лавировали ");

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void TestMethodSpaceNegative()
        {
            int result = new StringOperations().CountSpaces("");

            Assert.AreNotEqual(6, result);
        }
    }
}
