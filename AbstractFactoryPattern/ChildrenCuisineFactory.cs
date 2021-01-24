using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
        /// <summary>
        /// A concrete object
        /// </summary>
        class GrilledCheese : Sandwich { }

        /// <summary>
        /// A concrete object
        /// </summary>
        class IceCreamSundae : Dessert { }

        /// <summary>
        /// A concrete factory which creates concrete objects by implementing the abstract factory's methods.
        /// </summary>
        class KidCuisineFactory : RecipeFactory
        {
            public override Sandwich CreateSandwich()
            {
                return new GrilledCheese();
            }

            public override Dessert CreateDessert()
            {
                return new IceCreamSundae();
            }
        }
    }
