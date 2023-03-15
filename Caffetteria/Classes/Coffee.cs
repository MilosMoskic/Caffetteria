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
    public class Coffee
    {
        public Name name;
        public Type type;
        public Topping topping;
        public double price = 0;
        public List<Topping> toppings = new List<Topping>();
        public Service service;

        public Coffee() {

             

        }

        public double CalculatePrice()
        {
            Calculations calculation = new Calculations(this);
            return calculation.FinalCalculation;
        }

        
    }
}
