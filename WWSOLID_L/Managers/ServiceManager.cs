using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WWSOLID_L.Models.CoffeeServices;

namespace WWSOLID_L.Managers
{
    public class ServiceManager
    {
        public Service GetServiceById(int id)
        {
            return id switch
            {
                0 => new InHouse(),
                1 => new Coupon(),
                2 => new TakeAway(),
                _ => throw new NotImplementedException()
            };
        }
    }
}
