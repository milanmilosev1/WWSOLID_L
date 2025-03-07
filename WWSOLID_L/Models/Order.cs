using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;
using WWSOLID_L.Models.Coffees;
using WWSOLID_L.Models.CoffeeServices;


namespace WWSOLID_L
{
    public class Order
    {
        public double? TotalPrice { get; set; }
        public List<Coffee> coffees { get; set; }
        public Service service { get; set; }

        public Order()
        {
            TotalPrice = 0;
            coffees = new List<Coffee>();
        }
        public Order(List<Coffee> coffees, Service service)
        {
            TotalPrice = 0;
            this.coffees = coffees;
            this.service = service;
        }
    }
}
