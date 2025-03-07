using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WWSOLID_L.Models.Toppings
{
    public class BrownSugar : Topping
    {
        public Enums.ToppingName? ToppingName { get; set; }
        public double? ToppingPrice { get; set; }

        public BrownSugar(Enums.ToppingName toppingName = Enums.ToppingName.BrownSugar, double toppingPrice = 0.2) : base(toppingName, toppingPrice)
        {
            ToppingName = toppingName;
            ToppingPrice = toppingPrice;
        }
    }
}
