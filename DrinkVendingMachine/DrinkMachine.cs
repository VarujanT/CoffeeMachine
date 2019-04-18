using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkVendingMachine
{
    public class DrinkMachine
    {
        const int CostOfDrink = 150;
        public int RunningTotal { get; set; }

        public DrinkMachine()
        {
            RunningTotal = 0;
        }

        public void DepositCoin(int money)
        {
            //the only valid entries are 50, 100, 200, 500
            switch(money)
            {
                case (50):
                    RunningTotal += 50;
                    break;
                case (100):
                    RunningTotal += 100;
                    break;
                case (200):
                    RunningTotal += 200;
                    break;
                case (500):
                    RunningTotal += 500;
                    break;
                default:
                    Console.WriteLine("Invalid Entry.");

                    break;
            }

        }

        public bool checkTotal()
        {
            if (RunningTotal >= CostOfDrink)
                return true;
            else
                return false;
        }

        public void DisplayDrinkSelections()
        {
            Console.WriteLine("***************************************************");
            Console.WriteLine("* 1 - Super Strong Expresso Coffee (NO Sugar)     *");
            Console.WriteLine("* 2 - Super Strong Expresso Coffee (Normal Sugar) *");
            Console.WriteLine("* 3 - Super Strong Expresso Coffee (Super Sweet)  *");
            Console.WriteLine("* 4 - Regular Black Coffee (NO Sugar)             *");
            Console.WriteLine("* 5 - Regular Black Coffee (Normal Sugar)         *");
            Console.WriteLine("* 6 - Regular Black Coffee (Super Sweet)          *");
            Console.WriteLine("* 7 - Lite Coffee (NO Sugar)                      *");
            Console.WriteLine("* 8-  Lite Coffee (Normal Sugar)                  *");
            Console.WriteLine("* 9 - Lite Coffee (Super Sweet)                   *");
            Console.WriteLine("* 0 - Double Expresso (NO Sugar)                  *");
            Console.WriteLine("***************************************************");
            Console.WriteLine();
            Console.WriteLine("Please Make Your Selection");
            MakeDrinkSelectin(Convert.ToChar(Console.ReadLine()));
        }

        private void MakeDrinkSelectin(char selection)
        {
            bool selectionOK = false;
            while(!selectionOK)
            {
                switch(selection)
                {
                    case '1':
                        Console.WriteLine("Thank you for choosing Super Strong Expresso Coffee (NO Sugar)");
                        ReturnChange();
                        selectionOK = true;
                        break;
                    case '2':
                        Console.WriteLine("Thank you for choosing Super Strong Expresso Coffee (Normal Sugar)");
                        selectionOK = true;
                        ReturnChange();
                        break;
                    case '3':
                        Console.WriteLine("Thank you for choosing Super Strong Expresso Coffee (Super Sweet)");
                        selectionOK = true;
                        ReturnChange();
                        break;
                    case '4':
                        Console.WriteLine("Thank you for choosing Regular Black Coffee (NO Sugar)");
                        selectionOK = true;
                        ReturnChange();
                        break;
                    case '5':
                        Console.WriteLine("Thank you for choosing Regular Black Coffee (Normal Sugar)");
                        selectionOK = true;
                        ReturnChange();
                        break;
                    case '6':
                        Console.WriteLine("Thank you for choosing Regular Black Coffee (Super Sweet)");
                        selectionOK = true;
                        ReturnChange();
                        break;
                    case '7':
                        Console.WriteLine("Thank you for choosing Lite Coffee (NO Sugar)");
                        selectionOK = true;
                        ReturnChange();
                        break;
                    case '8':
                        Console.WriteLine("Thank you for choosing Lite Coffee (Normal Sugar)");
                        selectionOK = true;
                        ReturnChange();
                        break;
                    case '9':
                        Console.WriteLine("Thank you for choosing Lite Coffee (Super Sweet)");
                        selectionOK = true;
                        ReturnChange();
                        break;
                    case '0':
                        Console.WriteLine("Thank you for choosing Double Expresso (NO Sugar)");
                        selectionOK = true;
                        ReturnChange();
                        break;

                    default:
                        Console.WriteLine("Invalid Selection! Please re-enter your selection");
                        selection = Convert.ToChar(Console.ReadLine());
                        selectionOK = false;
                        break;
                }
            }
        }

        private void ReturnChange()
        {
            if (RunningTotal > CostOfDrink)
                Console.WriteLine("Your Change is {0:C}",RunningTotal - CostOfDrink);
        }
    }
}
