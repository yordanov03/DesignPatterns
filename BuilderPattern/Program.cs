﻿using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SandwichBuilder builder;

            // Create shop with sandwich assembly line
            AssemblyLine shop = new AssemblyLine();

            // Construct and display sandwiches
            builder = new HamAndCheese();
            shop.Assemble(builder);
            builder.Sandwich.Show();

            builder = new BLT();
            shop.Assemble(builder);
            builder.Sandwich.Show();

            builder = new TurkeyClub();
            shop.Assemble(builder);
            builder.Sandwich.Show();

            // Wait for user
            Console.ReadKey();
        }
    }
}
