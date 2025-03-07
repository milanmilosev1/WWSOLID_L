using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WWSOLID_L.Models.Toppings;

namespace WWSOLID_L.Models.Coffees
{
    public class Espresso : Coffee
    {
        public Espresso() : base()
        {
            Name = Enums.CoffeeName.Espresso;
            Type = Enums.Type.R;
            BasePrice = 10;
            TotalPrice = BasePrice;
            FinalPrice = TotalPrice;
            Toppings = null;
        }
    }
}
