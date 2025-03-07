using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using WWSOLID_L.Models.Coffees;
using WWSOLID_L.Models.CoffeeServices;
using WWSOLID_L.Models.Toppings;

namespace WWSOLID_L.Managers
{
    public class OrderManager
    {
        public void PlaceOrder()
        {
            Order order = new Order() { coffees = new List<Coffee>() };
            List<Topping> toppings = new List<Topping>();
            CoffeeManager coffeeManager = new CoffeeManager();
            ServiceManager serviceManager = new ServiceManager();
            ToppingManager toppingManager = new ToppingManager();
            Coffee coffeeObj = new Coffee();

            Console.WriteLine("===== PLACE YOUR ORDER =====\n");

            Console.Write("Choose a coffee (0 - Espresso, 1 - Latte Macchiato, 2 - Cappuchino): ");
            int coffeeId = Convert.ToInt32(Console.ReadLine());
            double basePrice = coffeeManager.GetCoffeeBasePrice(coffeeId);

            coffeeObj = coffeeManager.GetCoffeeById(coffeeId);

            Console.Write("Choose size (0 - Regular, 1 - Large): ");
            int coffeeSize = Convert.ToInt32(Console.ReadLine());

            Console.Write("Choose toppings (Enter IDs separated by commas, or -1 for none; 0 - Milk, 1 - Cinnamon, 2 - Brown Sugar): ");
            string toppingInput = Console.ReadLine();

            if (toppingInput != "-1")
            {
                var toppingIds = toppingInput.Split(',').Select(id => int.Parse(id.Trim()));

                foreach (int id in toppingIds)
                {
                    toppings.Add(toppingManager.GetToppingById(id));
                }
            }

            // Get Service Type
            Console.Write("Choose service (0 - In House, 1 - Coupon, 2 - TakeAway): ");
            int serviceId = Convert.ToInt32(Console.ReadLine());

            coffeeObj.Type = (Enums.Type)coffeeSize;
            coffeeObj.Toppings = toppings;

            order.coffees.Add(coffeeObj);

            order.service = serviceManager.GetServiceById(serviceId);

            CalculateTotalPrice(order);
            PrintReceipt(order);
        }

        public void CalculateTotalPrice(Order order)
        {
            CoffeeManager coffeeManager = new CoffeeManager();
            foreach(var coffee in order.coffees)
            {
                coffeeManager.CalculateCoffeePrice(coffee);
                order.TotalPrice += coffee.TotalPrice;
            }
            order.TotalPrice *= order.service.ServiceCharge;
        }

        public void PrintReceipt(Order order)
        {
            Console.WriteLine("\n===== ORDER RECEIPT =====\n");

            foreach (var coffee in order.coffees)
            {
                Console.WriteLine($"Coffee: {coffee.Name} ({coffee.Type})");
                if (coffee.Toppings != null && coffee.Toppings.Count > 0)
                {
                    Console.WriteLine("Toppings: " + string.Join(", ", coffee.Toppings.Select(t => t.ToppingName)));
                }
                else
                {
                    Console.WriteLine("Toppings: None");
                }
            }

            Console.WriteLine($"Service: {order.service.ServiceName}");
            Console.WriteLine("----------------------------");
            Console.WriteLine($"\nTotal Price: {order.TotalPrice:C}");
            Console.WriteLine("============================\n");
        }
    }
}
