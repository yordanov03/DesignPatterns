using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    /// <summary>
    /// Composite class
    /// </summary>
    public class Cola : SoftDrink
    {
        public Cola(int calories) : base(calories) { }
    }

    /// <summary>
    /// Composite class
    /// </summary>
    public class RootBeer : SoftDrink
    {
        public RootBeer(int calories) : base(calories) { }
    }
}
