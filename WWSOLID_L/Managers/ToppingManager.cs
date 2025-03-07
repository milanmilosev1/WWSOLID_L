using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WWSOLID_L.Models.Toppings;

namespace WWSOLID_L.Managers
{
    public class ToppingManager
    {
        public Topping GetToppingById(int id)
        {
            return id switch
            {
                0 => new Milk(),
                1 => new Cinnamon(),
                2 => new BrownSugar(),
                _ => throw new NotImplementedException()
            };
        }
    }
}
