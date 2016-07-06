using System;
using System.Net.NetworkInformation;
using System.Runtime;

namespace ConsoleApplication2
{
    public class Tea : Drink
    {
        public Int16 SugarTotal { get; set; }
        public bool Milk { get; set; }
        public Tea() : base("Tea")
        {
            
        }
    }
}