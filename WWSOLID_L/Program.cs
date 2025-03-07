using WWSOLID_L.Models;
using WWSOLID_L.Managers;

List<ICoffee> coffees = new List<ICoffee>();

List<ITopping> toppings = new List<ITopping>();

Espresso e1 = new Espresso(0, (Enums.Type)1, 10, toppings);

Order order1 = new Order(coffees);

order1.PlaceOrder(); 
order1.PlaceOrder();


order1.PrintAllOrders();


