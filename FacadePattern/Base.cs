using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    /// <summary>
    /// All items sold in the restaurant must inherit from this.
    /// </summary>
    class FoodItem { public int DishID; }

    /// <summary>
    /// Each section of the kitchen must implement this interface.
    /// </summary>
    interface IKitchenSection
    {
        FoodItem PrepDish(int DishID);
    }

    /// <summary>
    /// Orders placed by Patrons.
    /// </summary>
    class Order
    {
        public FoodItem Appetizer { get; set; }
        public FoodItem Entree { get; set; }
        public FoodItem Drink { get; set; }
    }
}
