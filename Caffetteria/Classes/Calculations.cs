using Caffetteria.Data;
using Caffetteria.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Type = Caffetteria.Data.Type;

namespace Caffetteria.Classes
{
    public class Calculations : ICoffee
    {
        public double FinalCalculation;
        public double FinalPrice; 
        public Calculations(Coffee coffee) 
        {
            FinalCalculation = CalculateFinalPrice(coffee);
        }
        public double CalculatePriceByName(Coffee coffee)
        {

            if(coffee.name == Name.Espresso)
            {
                FinalPrice += 1.0;
            }else if (coffee.name == Name.Espresso)
            {
                FinalPrice += 2.0;
            } else if (coffee.name == Name.Espresso)
            {
                FinalPrice += 3.0;
            }

            return FinalPrice;
        }

        public double CalculateByType(Coffee coffee)
        {
            //CalculatePriceByName(coffee);
            if (coffee.type == Type.Large)
            {
                FinalPrice += 0.7;
            }
            return FinalPrice;
        }

        public double CalculateByToppings(Coffee coffee)
        {
            //CalculateByType(coffee);
            foreach (var item in coffee.toppings)
            {
                if (item == Topping.Milk)
                {
                    FinalPrice += 0.1;
                }
                else if (item == Topping.Cinnamon)
                {
                    FinalPrice += 0.2;
                }
                else if (item == Topping.BrownSugar)
                {
                    FinalPrice += 0.3;
                }
            }
            return FinalPrice;
        }
        public double CalculatePriceByService(Coffee coffee)
        {
            //CalculateByToppings(coffee);
            if (coffee.service == Service.TakeAway)
            {
                FinalPrice = FinalPrice + 2 * FinalPrice / 100;
            }
       
            if (coffee.service == Service.CouponCode)
            {
                FinalPrice = FinalPrice - 5 * FinalPrice / 100;
            }
            return FinalPrice;
        }

        public double CalculateFinalPrice(Coffee c)
        {
            var final = CalculatePriceByName(c) + CalculateByType(c) + CalculateByToppings(c) + CalculatePriceByService(c);
            return final; 
        }
    }
}
