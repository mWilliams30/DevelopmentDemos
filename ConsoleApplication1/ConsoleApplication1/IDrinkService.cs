using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public interface IDrinkService
    {
        IEnumerable<Drink> GetDrinks();
        void AddDrink(Drink drink);
        Drink GetDrink(Guid drinkId);
    }
}
