using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Composite
{
    public class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("I am a circle");
        }
    }

    public class Triange : IShape
    {
        public void Draw()
        {
            Console.WriteLine("I am a Triange");
        }
    }

    public class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine("I am a Square");
        }
    }
}
