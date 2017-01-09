using ExtentionMethods;
using NUnit.Framework;

namespace DemoUnitTests
{
    [TestFixture]
    public class ExtentionMethodTest
    {
        [Test]
        public void Add50ToIntegerValue()
        {
            int x = 100;
            Assert.AreEqual(x.Add50(), 150);
        }

        [Test]
        public void AddHelloWorldToStringValue()
        {
            string personSays = "Mark Says";
            Assert.AreEqual(personSays.HelloWord(), $"{personSays} Hello World");
        }
    }
}
