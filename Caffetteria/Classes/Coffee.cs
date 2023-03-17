using Caffetteria.Data;
using Caffetteria.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Type = Caffetteria.Data.Type;

namespace Caffetteria.Classes
{
    public class Coffee : ICoffee
    {
        public Name name { get; set; }
        public Type type { get; set; }
        public Topping topping { get; set; }
        public decimal price { get; set; }

        public List<Topping> toppings { get; set; } = new List<Topping>();
        public Service service { get; set; }

        public decimal CalculatePrice()
        {
            Calculations calculation = new Calculations(this);
            return calculation.FinalCalculation;
        }



    }
}
