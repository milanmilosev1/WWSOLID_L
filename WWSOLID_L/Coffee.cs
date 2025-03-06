using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WWSOLID_L
{
    public class Coffee : ICoffee
    {
        public Enums.CoffeeName Name { get; set; }
        public Enums.Type Type { get; set; }
        public double? BasePrice { get; set; }
        public List<ITopping>? Toppings { get; set; }

        public Coffee(Enums.CoffeeName name, Enums.Type type, double basePrice, List<ITopping> toppings)
        {
            Name = name;
            Type = type;
            BasePrice = basePrice;
            Toppings = toppings;
        }


        public virtual double? CalculateToppingsPrice()
        {
            double? totalPrice = 0.0;
            foreach(var topping in Toppings)
            {
                totalPrice += topping.ToppingPrice;
            }
            return totalPrice;
        }

        public virtual double? CalculateTotalPrice()
        {
            if (Type == (Enums.Type)1)
                return BasePrice * 1.7 + CalculateToppingsPrice();
            else
                return BasePrice + CalculateToppingsPrice();
        }
    }
}
