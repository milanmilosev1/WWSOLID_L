using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WWSOLID_L.Models.Toppings
{
    public class Cinnamon : Topping
    {
        public Enums.ToppingName? ToppingName { get; set; }
        public double? ToppingPrice { get; set; }

        public Cinnamon(Enums.ToppingName toppingName = Enums.ToppingName.Cinnamon, double toppingPrice = 0.5) : base(toppingName, toppingPrice)
        {
            ToppingName = toppingName;
            ToppingPrice = toppingPrice;
        }

    }
}
