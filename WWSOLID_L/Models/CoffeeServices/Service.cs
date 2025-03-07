using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WWSOLID_L.Models.CoffeeServices
{
    public abstract class Service
    {
        public Enums.ServiceName? ServiceName { get; set; }
        public double? ServiceCharge { get; set; }
        public Service(Enums.ServiceName? serviceName, double? serviceCharge)
        {
            ServiceName = serviceName;
            ServiceCharge = serviceCharge;
        }
        public Service()
        {
            ServiceName = Enums.ServiceName.InHouse;
            ServiceCharge = 1;
        }
        
    }
}
