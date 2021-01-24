using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    /// <summary>
    /// A division of the kitchen.
    /// </summary>
    class ColdPrep : IKitchenSection
    {
        public FoodItem PrepDish(int dishID)
        {
            //Go prep the cold item
            return new FoodItem()
            {
                DishID = dishID
            };
        }
    }

    /// <summary>
    /// A division of the kitchen.
    /// </summary>
    class HotPrep : IKitchenSection
    {
        public FoodItem PrepDish(int dishID)
        {
            //Go prep the hot entree
            return new FoodItem()
            {
                DishID = dishID
            };
        }
    }

    /// <summary>
    /// A division of the kitchen.
    /// </summary>
    class Bar : IKitchenSection
    {
        public FoodItem PrepDish(int dishID)
        {
            //Go mix the drink
            return new FoodItem()
            {
                DishID = dishID
            };
        }
    }
}
