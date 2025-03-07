using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WWSOLID_L.Models.CoffeeServices
{
    public class InHouse : Service
    {
        public InHouse()
        {
            ServiceName = Enums.ServiceName.InHouse;
            ServiceCharge = 1;
        }
    }
}
