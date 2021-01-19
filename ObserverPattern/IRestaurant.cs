using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    /// <summary>
    /// The Observer interface
    /// </summary>
    interface IRestaurant
    {
        void Update(Veggies veggie);
    }
}
