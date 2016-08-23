using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    public class Circle : IShape
    {
        public string Name
        {
            get
            {
                return "Circle";
            }
        }
    }
}
