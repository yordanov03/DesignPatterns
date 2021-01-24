﻿using System;

namespace FlyWeightPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Build a slider order using patron's input
            Console.WriteLine("Please enter your slider order (use characters B, V, Z with no spaces):");
            var order = Console.ReadLine();
            char[] chars = order.ToCharArray();

            SliderFactory factory = new SliderFactory();

            int orderTotal = 0;

            //Get the slider from the factory
            foreach (char c in chars)
            {
                orderTotal++;
                Slider character = factory.GetSlider(c);
                character.Display(orderTotal);
            }

            Console.ReadKey();
        }
    }
}
