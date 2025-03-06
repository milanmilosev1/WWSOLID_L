using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WWSOLID_L
{
    public interface ICoffee
    {
        public Enums.CoffeeName Name { get; set; }
        public Enums.Type Type { get; set; }
        public double? BasePrice { get; set; }
        public List<ITopping>? Toppings { get; set; }

        public double? CalculateToppingsPrice();
        public double? CalculateTotalPrice();
    }
}
