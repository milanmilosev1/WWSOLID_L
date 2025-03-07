using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WWSOLID_L.Models.Coffees
{
    public class LatteMacchiato : Coffee
    {
        public LatteMacchiato() : base()
        {
            Name = Enums.CoffeeName.LatteMacchiato;
            Type = Enums.Type.R;
            BasePrice = 10;
            TotalPrice = BasePrice;
            FinalPrice = TotalPrice;
            Toppings = null;
        }
    }
}
