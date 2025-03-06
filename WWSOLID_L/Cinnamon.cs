using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WWSOLID_L
{
    public class Cinnamon : ITopping
    {
        public Enums.ToppingName? ToppingName { get; set; } = (Enums.ToppingName)1;
        public double? ToppingPrice { get; set; } = 20;

    }
}
