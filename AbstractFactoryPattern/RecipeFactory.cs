using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    /// <summary>
    /// The AbstractFactory class, which defines methods for creating abstract objects.
    /// </summary>
    abstract class RecipeFactory
    {
        public abstract Sandwich CreateSandwich();
        public abstract Dessert CreateDessert();
    }
}
