using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    //Genrics types allow code reuse with type safety
    public class MyGenricClass<T>
    {
        public string WhatTypeAmI()
        {
            return "I am of type " + GetType();
        }
    }
}
