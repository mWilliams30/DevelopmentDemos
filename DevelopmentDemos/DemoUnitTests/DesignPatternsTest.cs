using System;
using System.Collections;
using System.Collections.Generic;
using DesignPatterns.Composite;
using DesignPatterns.Factory;
using NUnit.Framework;
using Circle = DesignPatterns.Factory.Circle;
using IShape = DesignPatterns.Factory.IShape;

namespace DemoUnitTests
{
    [TestFixture]
    public class FactoryDesignPatternsTest
    {
        readonly IShapeFactory _shapeFactory;

        public FactoryDesignPatternsTest()
        {
            _shapeFactory = new ShapeFactory();
        }

        [Test]
        public void TestCreateCircleShape()
        {
            IShape circle = _shapeFactory.CreateShape("Circle");
            Assert.IsInstanceOf<Circle>(circle);
        }

        [Test]
        public void TestCreateTriangleShape()
        {
            IShape triangle = _shapeFactory.CreateShape("Triangle");
            Assert.IsInstanceOf<Triange>(triangle);
        }

        [Test]
        public void TestCreateSquareShape()
        {
            Assert.Throws<ApplicationException>(() => _shapeFactory.CreateShape("Square"));

        }

        [TestFixture]
        public class CompositeDesignPatternTests
        {
            [Test]
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
                    new DesignPatterns.Composite.Circle(),
                    new Square(),
                    new Triange()
                });

               // Assert.AreEqual(shapeComposite, shapeComposite2);


            }

        }

    }

   
}
