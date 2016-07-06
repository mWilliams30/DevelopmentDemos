using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    public class DrinkService : IDrinkService
    {
        public IEnumerable<Drink> GetDrinks()
        {
            throw new NotImplementedException();
        }

        public void AddDrink(Drink drink)
        {
            throw new NotImplementedException();
        }

        public Drink GetDrink(Guid drinkId)
        {
            throw new NotImplementedException();
        }
    }
}