using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class CookingMethod
    {
        private CookStrategy _cookStrategy;
        private string Food;

        public void SetCookStrategy(CookStrategy cookStrategy)
        {
            this._cookStrategy = cookStrategy;
        }

        public void SetFood(string name)
        {
            this.Food = name;
        }

        public void Cook()
        {
            _cookStrategy.Cook(Food);
            Console.WriteLine();
        }
    }
}
