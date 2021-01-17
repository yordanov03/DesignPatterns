using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class MenuItem
    {
        /// <summary>
        /// Represents an item being ordered from this restaurant.
        /// </summary>
        
        public string Name { get; set; }
        public int Amount { get; set; }
        public double Price { get; set; }

        public MenuItem(string name, int amount, double price)
        {
            this.Name = name;
            this.Price = price;
            this.Amount = amount;
        }

        public void Display()
        {
            Console.WriteLine("\nName: " + Name);
            Console.WriteLine("\nAmount: " + Amount.ToString());
            Console.WriteLine("\nPrice: " + Price.ToString());
        }
    }
}
