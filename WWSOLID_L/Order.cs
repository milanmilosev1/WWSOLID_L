using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace WWSOLID_L
{
    public class Order
    {
        public List<ICoffee> coffees { get; set; }
        public Order(List<ICoffee> coffees)
        {
            this.coffees = coffees;
        }

        public void PlaceOrder()
        {
            int coffeeSize;
            int coffeeId;
            int toppingId;
            List<ITopping> toppings = new List<ITopping>();
            do
            {
                Console.WriteLine("What coffee would you like to order?(0 - espresso, 1 - latte macchiato, 2 - cappuccino)");
                coffeeId = Convert.ToInt32(Console.ReadLine());
            } while (coffeeId > 2 || coffeeId < 0);       
            do
            {
                Console.WriteLine("What size?(0 - regular, 1 - large)");
                coffeeSize = Convert.ToInt32(Console.ReadLine());
            } while (coffeeSize > 1 || coffeeSize < 0);
            int i = 0;
            do
            {
                Console.WriteLine("Choose a topping (0 - milk, 1 - cinnamon, 2 - brown sugar, 3 - no topping)");
                toppingId = Convert.ToInt32(Console.ReadLine());
            } while (toppingId > 3 || toppingId < 0);

            switch (toppingId)
            {
                case 0:
                    toppings.Add(new Milk { });
                    break;
                case 1:
                    toppings.Add(new Cinnamon { });
                    break;
                case 2:
                    toppings.Add(new BrownSugar { });
                    break;
                case 3:
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }

            switch (coffeeId)
            {
                case 0:
                    coffees.Add(new Espresso (0, (Enums.Type)coffeeSize, 10, toppings));
                    break;
                case 1:
                    coffees.Add(new LatteMacchiato((Enums.CoffeeName)1, (Enums.Type)coffeeSize, 12, toppings));
                    break;
                case 2:
                    coffees.Add(new Cappuccino((Enums.CoffeeName)2, (Enums.Type)coffeeSize, 11, toppings));
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }

            Console.WriteLine("Order placed!\n");
        }
        public void PrintAllOrders()
        {
            double? totalPrice = 0.0;
            foreach(var coffee in coffees)
            {
                Console.WriteLine($"Name = {coffee.Name}, Type = {coffee.Type}");
                //var toppingArr = coffee.Toppings.Select(x => x.ToppingName).ToArray();
                Console.Write("Toppings: ");
                foreach (var topping in coffee.Toppings)
                {
                    Console.Write(topping.ToppingName + " ");
                }
                Console.WriteLine($"\nOrder Price: {coffee.CalculateTotalPrice()}\n");
                totalPrice += coffee.CalculateTotalPrice();
            }
            Console.WriteLine("\nTotal price: " + totalPrice);
        }

    }
}
