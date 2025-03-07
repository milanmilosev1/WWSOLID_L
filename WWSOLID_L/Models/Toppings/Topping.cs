using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WWSOLID_L.Models.Toppings
{
    public class Topping
    {
        public Enums.ToppingName? ToppingName { get; set; }
        public double? ToppingPrice { get; set; }

        public Topping(Enums.ToppingName? toppingName, double? toppingPrice)
        {
            ToppingName = toppingName;
            ToppingPrice = toppingPrice;
        }
        public Topping()
        {
            ToppingName = Enums.ToppingName.NoTopping;
            ToppingPrice = 0;
        }
    }
}
