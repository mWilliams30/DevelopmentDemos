using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        private readonly IDrinkService _drinkService;

        public Program(IDrinkService drinkService)
        {
            _drinkService = drinkService;
        }

        private void Run()
        {
            _drinkService.AddDrink(new Beer());
        }

        static void Main(string[] args)
        {
           Drink d = new Beer();
           
        }
    }
}
