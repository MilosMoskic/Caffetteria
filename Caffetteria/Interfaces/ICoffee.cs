using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caffetteria.Classes;
using Caffetteria.Data;

namespace Caffetteria.Interfaces
{
    public interface ICoffee
    {
        public double CalculatePriceByName(Coffee coffee);
        public double CalculateByType(Coffee coffee);
        public double CalculateByToppings(Coffee coffee);
        public double CalculatePriceByService(Coffee coffee);
    }
}
