using Laboratoria;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProjectLaboratoria
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethodSumEqual()
        {
            Assert.AreEqual(3,Utilities.Sum(1,2));
        }

        [TestMethod]
        public void TestMethodSumNotEqual()
        {
            Assert.AreNotEqual(5, Utilities.Sum(1, 2));
        }

        [TestMethod]
        public void TestMethodSumEqual2()
        {
            Assert.AreEqual(4, Utilities.Sum(2, 2));
        }

        [TestMethod]
        public void TestMethodSumNotEqual2()
        {
            Assert.AreNotEqual(10, Utilities.Sum(3, 2));
        }
    }
}
