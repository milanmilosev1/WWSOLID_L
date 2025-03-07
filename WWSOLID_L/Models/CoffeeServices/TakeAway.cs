using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WWSOLID_L.Models.CoffeeServices
{
    public class TakeAway : Service
    {
        public TakeAway()
        {
            ServiceName = Enums.ServiceName.InHouse;
            ServiceCharge = 1.02;
        }
    }
}
