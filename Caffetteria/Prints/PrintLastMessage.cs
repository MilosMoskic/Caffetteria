using Caffetteria.Classes;
using Caffetteria.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caffetteria.Prints
{
    public class PrintLastMessage : IPrintMessage
    {
        public void printLastMessage(ICoffee coffee)
        {
            Console.WriteLine($"Coffee Name: {coffee.name}\n" +
                  $"Coffee Type: {coffee.type}\n" +
                  $"Coffee Toppings: {coffee.toppings}\n" +
                  $"Coffee Service: {coffee.service}\n" +
                  $"Total Cost: {coffee.CalculatePrice()}");
        }
    }
}
