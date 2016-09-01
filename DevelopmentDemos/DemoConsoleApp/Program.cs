using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericsDemo;
using DesignPatterns.Composite;

namespace DemoConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            MyGenricClass<string> genericClass = new MyGenricClass<string>();
            Console.WriteLine(genericClass.WhatTypeAmI());

            MyGenricClass<int> intGenricClass = new MyGenricClass<int>();
            Console.WriteLine(intGenricClass.WhatTypeAmI());

            MyGenricClass<double> doubleGenricClass = new MyGenricClass<double>();
            Console.WriteLine(doubleGenricClass.WhatTypeAmI());

            MyGenricClass<DateTime> dateTimeGenricClass = new MyGenricClass<DateTime>();
            Console.WriteLine(dateTimeGenricClass.WhatTypeAmI());

            Console.ReadKey();

            IShape c = new Circle();
            IShape t = new Triange();
            IShape s = new Square();

            ShapeComposite shapeComposite = new ShapeComposite();
            shapeComposite.Add(c);
            shapeComposite.Add(t);
            shapeComposite.Add(s);

            ShapeComposite shapeComposite2 = new ShapeComposite();
            shapeComposite2.AddRange(new IShape[] {new Circle(), new Square(), new Triange()});

            shapeComposite.Add(shapeComposite2);

            shapeComposite.Draw();
            Console.ReadKey();

        }
    }
}
