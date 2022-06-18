using Laboratoria;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace UnitTestLaboratoryProject
{
    [TestClass]
    public class UnitTestLaboratory
    {
        [TestMethod]
        public void TestSum()
        {
            float a = 5.5F;
            float b = 4.5F;

            Assert.AreEqual(Utilities.Sum(a,b), 10);
        }
    }
}
