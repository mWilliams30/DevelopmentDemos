using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Drink tea = new Tea();
            Drink beer = new Beer();
            Drink coffee = new Coffee() {Milk = true,SugarTotal = 2};
            Drink coffee2 = new Coffee();
          
            Order order = new Order {Drinks = new List<Drink>()};
            order.Drinks.Add(tea);
            order.Drinks.Add(beer);
            order.Drinks.Add(coffee);
            order.Drinks.Add(coffee2);
            
            OrderService orderService = new OrderService();
            orderService.AddOrder(order);
            
            

            Console.ReadLine();
        }
    }
}
