using System;
using System.Collections.Generic;
using System.Text;

namespace FlyWeightPattern
{
    class BaconMaster : Slider
    {
        public BaconMaster()
        {
            Name = "Bacon Master";
            Cheese = "American";
            Toppings = "lots of bacon";
            Price = 2.39m;
        }

        public override void Display(int orderTotal)
        {
            Console.WriteLine("Slider #" + orderTotal + ": " + Name + " - topped with " + Cheese + " cheese and " + Toppings + "! $" + Price.ToString());
        }
    }

    /// <summary>
    /// A ConcreteFlyweight class
    /// </summary>
    class VeggieSlider : Slider
    {
        public VeggieSlider()
        {
            Name = "Veggie Slider";
            Cheese = "Swiss";
            Toppings = "lettuce, onion, tomato, and pickles";
            Price = 1.99m;
        }

        public override void Display(int orderTotal)
        {
            Console.WriteLine("Slider #" + orderTotal
                              + ": " + Name + " - topped with "
                              + Cheese + " cheese and "
                              + Toppings + "! $" + Price.ToString());
        }

    }

    /// <summary>
    /// A ConcreteFlyweight class
    /// </summary>
    class BBQKing : Slider
    {
        public BBQKing()
        {
            Name = "BBQ King";
            Cheese = "American";
            Toppings = "Onion rings, lettuce, and BBQ sauce";
            Price = 2.49m;
        }

        public override void Display(int orderTotal)
        {
            Console.WriteLine("Slider #" + orderTotal + ": "
                              + Name + " - topped with "
                              + Cheese + " cheese and "
                              + Toppings + "! $" + Price.ToString());
        }
    }
}
