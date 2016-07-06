using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public abstract class Drink
    {
        private string Name { get; set; }
        public Drink(string name)
        {
            this.Name = name;
        }
    }
}
