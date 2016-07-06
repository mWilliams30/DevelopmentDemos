using System;

namespace ConsoleApplication2
{
    public class Coffee : Drink
    {
        public int SugarTotal { get; set; }
        public bool Milk { get; set; }
        public Coffee() : base("Coffee")
        {
        }
    }
}