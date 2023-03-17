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
    public class Calculations : ICalculations
    {
        public decimal FinalCalculation;
        public decimal FinalPrice;
        Constants constants = new Constants();
        public Calculations(Coffee coffee) 
        {
            FinalCalculation = CalculateFinalPrice(coffee);
        }
        public decimal CalculatePriceByName(Coffee coffee)
        {

            if(coffee.name == Name.Espresso)
            {
                FinalPrice += constants.espresso;
            }else if (coffee.name == Name.LatteMacciato)
            {
                FinalPrice += constants.lattemachiato;
            } else if (coffee.name == Name.Espresso)
            {
                FinalPrice += constants.cappuccino;
            }

            return FinalPrice;
        }

        public decimal CalculateByType(Coffee coffee)
        {
            if (coffee.type == Type.Large)
            {
                FinalPrice += constants.large;
            }
            return FinalPrice;
        }

        public decimal CalculateByToppings(Coffee coffee)
        {
            foreach (var item in coffee.toppings)
            {
                if (item == Topping.Milk)
                {
                    FinalPrice += constants.milk;
                }
                else if (item == Topping.Cinnamon)
                {
                    FinalPrice += constants.cinnamon;
                }
                else if (item == Topping.BrownSugar)
                {
                    FinalPrice += constants.brownsugar;
                }
            }
            return FinalPrice;
        }
        public decimal CalculatePriceByService(Coffee coffee)
        {

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

        public decimal CalculateFinalPrice(Coffee coffee)
        {
            var final = CalculatePriceByName(coffee) + CalculateByType(coffee) + CalculateByToppings(coffee) + CalculatePriceByService(coffee);
            return final; 
        }
    }
}
