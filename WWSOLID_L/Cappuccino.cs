using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WWSOLID_L
{
    public class Cappuccino : Coffee
    {
        public Enums.CoffeeName Name { get; set; }
        public Enums.Type Type { get; set; }
        public double? BasePrice { get; set; }
        public List<ITopping>? Toppings { get; set; }
        public Cappuccino(Enums.CoffeeName name, Enums.Type type, double basePrice, List<ITopping> toppings) : base(name, type, basePrice, toppings)
        {
            Name = (Enums.CoffeeName)1;
            Type = type;
            BasePrice = 210;
            Toppings = toppings;
        }

    }
}
