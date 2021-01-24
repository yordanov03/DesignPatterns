using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    /// <summary>
    /// RefinedAbstraction for a dairy-free order
    /// </summary>
    public class SendDairyFreeOrder : SendOrder
    {
        public override void Send()
        {
            _restaurant.Place("Dairy-Free Order");
        }
    }

    /// <summary>
    /// RefinedAbstraction for a gluten free order
    /// </summary>
    public class SendGlutenFreeOrder : SendOrder
    {
        public override void Send()
        {
            _restaurant.Place("Gluten-Free Order");
        }
    }
}
