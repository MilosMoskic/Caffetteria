using Caffetteria.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caffetteria.Prints
{
    public class PrintErrorMessage : IPrintErrorMessage
    {
        public void printError()
        {
            Console.WriteLine("Invalid number inserted.");
        }
    }
}
