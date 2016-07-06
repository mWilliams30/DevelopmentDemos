using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public abstract class Drink
    {
        public string Type { get; set; }
    }

    public class Beer : Drink
    {

        public Beer()
        {
            base.Type = "Beer";
        }
    }

    public class Tea : Drink
    {/// <summary>
     /// Initializes a new instance of the <see cref="Tea"/> class.
     /// </summary>
        public Tea()
        {
            base.Type = "Tea";
        }
    }

    public class Coffee : Drink
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Coffee"/> class.
        /// </summary>
        public Coffee()
        {
            base.Type = "Coffee";

        }
    }
}
