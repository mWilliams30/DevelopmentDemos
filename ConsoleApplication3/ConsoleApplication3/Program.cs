using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            var type =  typeof(MyClass);
            Console.WriteLine(type);
            Console.WriteLine(type.GetType());
            Console.ReadLine();

        }
    }

    [TestClass]
    public class MyClass { }
}
