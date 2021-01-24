using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    /// <summary>
    /// Implementor which defines an interface for placing an order
    /// </summary>
    public interface IOrderingSystem
    {
        void Place(string order);
    }
}
