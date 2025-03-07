using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WWSOLID_L.Models.Coffees
{
    public class Cappuchino : Coffee
    {
        public Cappuchino() : base()
        {
            Name = Enums.CoffeeName.Cappuccino;
            Type = Enums.Type.R;
            BasePrice = 10;
            TotalPrice = BasePrice;
            FinalPrice = TotalPrice;
            Toppings = null;
        }
    }
}
