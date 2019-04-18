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
            var drinkMachine = new DrinkMachine();
            while (!drinkMachine.checkTotal())
            {
                Console.WriteLine("Please enter coin (50, 100, 200, 500)");
                drinkMachine.DepositCoin(Convert.ToInt32(Console.ReadLine()));
            }

            drinkMachine.DisplayDrinkSelections();

            Console.ReadLine();
        }
    }
}
