using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    abstract class CookStrategy
    {
        public abstract void Cook(string food);
    }
}
