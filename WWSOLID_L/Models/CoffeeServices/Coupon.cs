using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WWSOLID_L.Enums;

namespace WWSOLID_L.Models.CoffeeServices
{
    public class Coupon : Service
    {
        public Coupon()
        {
            ServiceName = Enums.ServiceName.InHouse;
            ServiceCharge = 0.95;
        }
    }
}
