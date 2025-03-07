using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using WWSOLID_L.Models.Coffees;
using WWSOLID_L.Models.CoffeeServices;

namespace WWSOLID_L.Managers
{
    public class CoffeeManager
    {

        public Coffee GetCoffeeById(int id)
        {
            return id switch
            {
                0 => new Espresso(),
                1 => new LatteMacchiato(),
                2 => new Cappuchino(),
                _ => throw new NotImplementedException()
            };
        }
        public double GetCoffeeBasePrice(int coffeeId)
        {
            if (coffeeId == 0)
            {
                return 10;
            }
            else if (coffeeId == 1)
            {
                return 12;
            }
            else
            {
                return 15;
            }
        }
        public void CalculateCoffeePrice(Coffee coffee)
        {
            CalculateFinalPrice(coffee);
            CalculateToppingsPrice(coffee);
        }
        public void CalculateToppingsPrice(Coffee coffee)
        {
            double? totalPrice = 0.0;
            foreach (var topping in coffee.Toppings)
            {
                totalPrice += topping.ToppingPrice;
            }
            coffee.TotalPrice = (coffee.FinalPrice ?? 0) + (totalPrice ?? 0);
        }

        public void  CalculateFinalPrice(Coffee coffee)
        {
            if (coffee.Type == (Enums.Type)1)
            {
                coffee.FinalPrice = coffee.BasePrice * 1.7;
                return;
            }
            coffee.FinalPrice = coffee.BasePrice;
        }
    }
}
