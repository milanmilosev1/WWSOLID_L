using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WWSOLID_L
{
    public class Milk : ITopping
    {
        public Enums.ToppingName? ToppingName { get; set; } = (Enums.ToppingName)0;
        public double? ToppingPrice { get; set; } = 50;

    }
}
