using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WWSOLID_L
{
    public class LatteMacchiato : Coffee
    {
        public Enums.CoffeeName Name { get; set; } = (Enums.CoffeeName)1;
        public Enums.Type Type { get; set; }
        public double? BasePrice { get; set; } = 11.00;
        public List<ITopping>? Toppings { get; set; }

        public LatteMacchiato(Enums.CoffeeName name, Enums.Type type, double basePrice, List<ITopping> toppings) : base(name, type, basePrice, toppings)
        {
            Name = (Enums.CoffeeName)2;
            Type = type;
            BasePrice = 250;
            Toppings = toppings;
        }

    }
}
