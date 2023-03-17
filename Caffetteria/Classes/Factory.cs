using Caffetteria.Data;
using Caffetteria.Prints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caffetteria.Classes
{
    public static class Factory
    {
        public static Coffee CreateCoffee()
        {
            return new Coffee();
        }
        public static PrintErrorMessage CreatePrintErrorMessage()
        {
            return new PrintErrorMessage();
        }
        public static PrintLastMessage CreatePrintLastMessage()
        {
            return new PrintLastMessage();
        }

    }
}
