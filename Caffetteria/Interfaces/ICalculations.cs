using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caffetteria.Classes;
using Caffetteria.Data;

namespace Caffetteria.Interfaces
{
    public interface ICalculations
    {
        public decimal CalculatePriceByName(Coffee coffee);
        public decimal CalculateByType(Coffee coffee);
        public decimal CalculateByToppings(Coffee coffee);
        public decimal CalculatePriceByService(Coffee coffee);
    }
}
