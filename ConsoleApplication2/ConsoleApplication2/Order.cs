﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class Order
    {
        public List<Drink> Drinks { get; set; }
        public Guid OrderId { get;  }
        public Order ()
        {
            this.OrderId = Guid.NewGuid();
        }
    }
}
