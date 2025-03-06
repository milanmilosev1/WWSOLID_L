using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WWSOLID_L
{
    public interface ITopping
    {
        public Enums.ToppingName? ToppingName { get; set; }
        public double? ToppingPrice { get; set; }

    }
}
