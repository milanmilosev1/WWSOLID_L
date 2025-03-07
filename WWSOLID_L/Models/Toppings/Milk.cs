using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WWSOLID_L.Models.Toppings
{
    public class Milk : Topping
    {
        public Enums.ToppingName? ToppingName { get; set; }
        public double? ToppingPrice { get; set; }

        public Milk(Enums.ToppingName? toppingName = Enums.ToppingName.Milk, double? toppingPrice = 1) : base(toppingName, toppingPrice)
        {
            ToppingName = toppingName;
            ToppingPrice = toppingPrice;
        }
    }
}
