using Caffetteria.Data;
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
            Coffee coffee = new Coffee();
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
                        coffee.name = Data.Name.Espresso;
                        terminate = false;
                        break;
                    case "2":
                        coffee.name = Data.Name.LatteMacciato;
                        terminate = false;
                        break;
                    case "3":
                        coffee.name = Data.Name.Cappuccino;
                        terminate = false;
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
                        coffee.toppings.Add(Data.Topping.Milk);
                        terminate = false;
                        break;
                    case "2":
                        coffee.toppings.Add(Data.Topping.Cinnamon);
                        terminate = false;
                        break;
                    case "3":
                        coffee.toppings.Add(Data.Topping.BrownSugar);
                        terminate = false;
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
                        coffee.service = Data.Service.InHouse;
                        terminate = false;
                        break;
                    case "2":
                        coffee.service = Data.Service.TakeAway;
                        terminate = false;
                        break;
                }
            }

            terminate = true;

            Console.WriteLine("\nPress 1 if you have Coupon Code.\n" +
                                "Press 2 if you have Coupon Code.\n");
            while (terminate)
            {
                string key = Console.ReadLine();

                switch (key)
                {
                    case "1":
                        coffee.service = Data.Service.CouponCode;
                        terminate = false;
                        break;
                    case "2":
                        terminate = false;
                        break;
                }
            }



            Console.WriteLine($"Coffee Name: {coffee.name}\n" +
                              $"Coffee Type: {coffee.type}\n" +
                              $"Coffee Toppings: {coffee.toppings}\n" +
                              $"Coffee Service: {coffee.service}\n" +
                              $"Total Cost: {coffee.CalculatePrice()}");
        }
    }
}



