using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class ConcreteStrategy
    {
        internal class Grilling : CookStrategy
        {
            public override void Cook(string food)
            {
                Console.WriteLine("\nCooking " + food + " by grilling it.");
            }
        }

        internal class OvenBaking : CookStrategy
        {
            public override void Cook(string food)
            {
                Console.WriteLine("\nCooking " + food + " by oven baking it.");
            }
        }

        internal class DeepFrying : CookStrategy
        {
            public override void Cook(string food)
            {
                Console.WriteLine("\nCooking " + food + " by deep frying it");
            }
        }
    }
}
