using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string myName = "mark.williams";
            Assert.IsTrue(string.Equals(myName, "mark.williams"));
        }
    }
}
