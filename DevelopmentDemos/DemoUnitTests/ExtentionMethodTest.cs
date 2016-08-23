using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtentionMethods;

namespace DemoUnitTests
{
    [TestClass]
    public class ExtentionMethodTest
    {
        [TestMethod]
        public void Add50ToIntegerValue()
        {
            int x = 100;
            Assert.AreEqual(x.Add50(), 150);
        }

        [TestMethod]
        public void AddHelloWorldToStringValue()
        {
            string personSays = "Mark Says";
            Assert.AreEqual(personSays.HelloWord(), $"{personSays} Hello World");
        }
    }
}
