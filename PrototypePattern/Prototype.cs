using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypePattern
{
    /// <summary>
    /// The Prototype abstract class
    /// </summary>
    abstract class SandwichPrototype
    {
        public abstract SandwichPrototype Clone();
    }
}
