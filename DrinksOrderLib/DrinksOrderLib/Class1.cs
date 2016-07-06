using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DrinksOrderLib
{
    public class Order
    {
        public Drink Drink { get; set; }
    }

    public abstract class Drink
    {
        public string Type { get; set; }   
    }



    public class Coffee : Drink
    {
    }

    public class Tea : Drink
    {

    }
}
