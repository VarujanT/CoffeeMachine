using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkVendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            var coffeeMachine = new CoffeeMachine();
            while (!coffeeMachine.checkTotal())
            {
                Console.WriteLine("Please enter coin (50, 100, 200, 500)");
                coffeeMachine.DepositCoin(Convert.ToInt32(Console.ReadLine()));
            }

            coffeeMachine.DisplayDrinkSelections();

            Console.ReadLine();
        }
    }
}
