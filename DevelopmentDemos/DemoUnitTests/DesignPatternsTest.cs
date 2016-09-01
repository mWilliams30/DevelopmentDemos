using System;
using System.Collections;
using System.Collections.Generic;
using DesignPatterns.Composite;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Factory;
using Circle = DesignPatterns.Factory.Circle;
using IShape = DesignPatterns.Factory.IShape;

namespace DemoUnitTests
{
    [TestClass]
    public class FactoryDesignPatternsTest
    {
        readonly IShapeFactory _shapeFactory;

        public FactoryDesignPatternsTest()
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

    [TestClass]
    public class CompositeDesignPatternTests
    {
        [TestMethod]
        public void TestAddingToArrayIsSameAsAddRange()
        {
            DesignPatterns.Composite.IShape c = new DesignPatterns.Composite.Circle();
            DesignPatterns.Composite.IShape t = new Triange();
            DesignPatterns.Composite.IShape s = new Square();

            ShapeComposite shapeComposite = new ShapeComposite();
            shapeComposite.Add(c);
            shapeComposite.Add(t);
            shapeComposite.Add(s);

            ArrayList shapeComposite2 = new ArrayList();
            shapeComposite2.AddRange(new List<DesignPatterns.Composite.IShape>()
            {
                new DesignPatterns.Composite.Circle(), new Square(), new Triange()
            });

            Assert.AreEqual(shapeComposite, shapeComposite2);
            

        }



    }

   
}
