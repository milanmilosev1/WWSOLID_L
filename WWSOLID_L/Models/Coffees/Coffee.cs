using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WWSOLID_L.Models.Toppings;

namespace WWSOLID_L.Models.Coffees
{
    public class Coffee
    {
        public Enums.CoffeeName Name { get; set; }
        public Enums.Type Type { get; set; }
        public double? BasePrice { get; set; }
        public double? FinalPrice { get; set; }
        public double? TotalPrice { get; set; }
        public List<Topping>? Toppings { get; set; }

        public Coffee(Enums.CoffeeName name, Enums.Type type, double basePrice, List<Topping> toppings)
        {
            Name = name;
            Type = type;
            BasePrice = basePrice;
            FinalPrice = basePrice;
            TotalPrice = basePrice;
            Toppings = toppings;
        }

        public Coffee()
        {
            Name = Enums.CoffeeName.Espresso;
            Type = Enums.Type.R;
            BasePrice = 0;
            FinalPrice = 0;
            TotalPrice = 0;
            Toppings = null;
        }
    }
}
