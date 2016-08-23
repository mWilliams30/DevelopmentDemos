using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Factory;

namespace DemoUnitTests
{
    [TestClass]
    public class DesignPatternsTest
    {
        readonly IShapeFactory _shapeFactory;

        public DesignPatternsTest()
        {
            _shapeFactory = new ShapeFactory();
        }

        [TestMethod]
        public void TestCreateCircleShape()
        {
            IShape circle = _shapeFactory.CreateShape("Circle");
            Assert.IsTrue(circle is Circle);
        }

        [TestMethod]
        public void TestCreateTriangleShape()
        {
            IShape triangle = _shapeFactory.CreateShape("Triangle");
            Assert.IsTrue(triangle is Triangle);
        }

        [TestMethod]
        [ExpectedException(typeof(ApplicationException), "Square cannot be created")]
        public void TestCreateSquareShape()
        {
            IShape square = _shapeFactory.CreateShape("Square");           
        }
    }
}
