using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    interface IOrder { }
    class DairyFreeOrder : IOrder { } //This class keeps a 
                                      //private reference to an IRestaurantOrder
    class GlutenFreeOrder : IOrder { } //This class also keeps 
                                       //a private reference to an IRestaurantOrder
    interface IRestaurantOrder : IOrder { }
    class DinerOrder : IRestaurantOrder { }
    class FancyRestaurantOrder : IRestaurantOrder { }
}
