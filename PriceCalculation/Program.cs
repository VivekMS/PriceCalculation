using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            Grocery freshGrocery = new Grocery();
            freshGrocery.Name = "Bread";
            freshGrocery.Price = 1;
            freshGrocery.Quantity = 1;
          

            Grocery grocery = new Grocery();
            grocery.Name = "Butter";
            grocery.Price = 0.80;
            grocery.Quantity = 1;

            Grocery items = new Grocery();
            items.Name = "Milk";
            items.Price = 1.15;
            items.Quantity = 1;

            ShoppingCart cart = new ShoppingCart();
            cart.Orders = new List<GroceryItem>();
            cart.Orders.Add(freshGrocery);
            cart.Orders.Add(grocery);
            cart.Orders.Add(items);


            double price = cart.Calculate();
            Console.WriteLine("Total Price: {0}", price);
            Console.ReadLine();
        }
    }

    
}
      