using Caffetteria.Data;
using Caffetteria.Interfaces;
using Caffetteria.Prints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caffetteria.Classes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ICoffee coffee = Factory.CreateCoffee();
            PrintLastMessage printLastMessage = Factory.CreatePrintLastMessage();
            PrintErrorMessage printError = Factory.CreatePrintErrorMessage();

            bool terminate = true;
            Console.WriteLine("Press 1 for Espresso\n" +
                              "Press 2 for Latte Macchiato\n" +
                              "Press 3 for Cappucino.\n");
            while (terminate)
            {
                string key = Console.ReadLine();

                switch (key)
                {
                    case "1":
                        coffee.name = Name.Espresso;
                        terminate = false;
                        break;
                    case "2":
                        coffee.name = Name.LatteMacciato;
                        terminate = false;
                        break;
                    case "3":
                        coffee.name = Name.Cappuccino;
                        terminate = false;
                        break;
                    default:
                        printError.printError();
                        break;
                }
            }

            terminate = true;

            Console.WriteLine("\nPress 1 for Regular\n" +
                              "Press 2 for Large\n");
            while (terminate)
            {
                string key = Console.ReadLine();

                switch (key)
                {
                    case "1":
                        coffee.type = Data.Type.Regular;
                        terminate = false;
                        break;
                    case "2":
                        coffee.type = Data.Type.Large;
                        terminate = false;
                        break;
                    default:
                        printError.printError();
                        break;
                }
            }

            terminate = true;

            List<Topping> toppings = new List<Topping>();

            toppings = coffee.toppings;

            Console.WriteLine("\nPress 1 for Milk topping.\n" +
                             "Press 2 for Cinnamon topping.\n" +
                            "Press 3 for Brown Sugar topping.\n");
            while (terminate)
            {
                string key = Console.ReadLine();

                switch (key)
                {
                    case "1":
                        coffee.toppings.Add(Topping.Milk);
                        terminate = false;
                        break;
                    case "2":
                        coffee.toppings.Add(Topping.Cinnamon);
                        terminate = false;
                        break;
                    case "3":
                        coffee.toppings.Add(Topping.BrownSugar);
                        terminate = false;
                        break;
                    default:
                        printError.printError();
                        break;
                }
            }

            terminate = true;

            Console.WriteLine("\nPress 1 for In House\n" +
                              "Press 2 for Take Away\n");
            while (terminate)
            {
                string key = Console.ReadLine();

                switch (key)
                {
                    case "1":
                        coffee.service = Service.InHouse;
                        terminate = false;
                        break;
                    case "2":
                        coffee.service = Service.TakeAway;
                        terminate = false;
                        break;
                    default:
                        printError.printError();
                        break;
                }
            }

            terminate = true;

            Console.WriteLine("\nPress 1 if you have Coupon Code.\n" +
                              "Press 2 if you don't have Coupon Code.\n");
            while (terminate)
            {
                string key = Console.ReadLine();

                switch (key)
                {
                    case "1":
                        coffee.service = Service.CouponCode;
                        terminate = false;
                        break;
                    case "2":
                        terminate = false;
                        break;
                    default:
                        printError.printError();
                        break;
                }
            }

            printLastMessage.printLastMessage(coffee);
        }
    }
}



