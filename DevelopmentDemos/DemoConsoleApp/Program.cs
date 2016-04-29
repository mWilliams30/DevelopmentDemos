using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericsDemo;

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
        }
    }
}
