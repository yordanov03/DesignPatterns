using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    /// <summary>
    /// Composite class, root node
    /// </summary>
    public class SodaWater : SoftDrink
    {
        public SodaWater(int calories) : base(calories) { }
    }
}
