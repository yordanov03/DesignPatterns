using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern
{
    /// <summary>
    /// The Visitor interface, which declares 
    /// a Visit operation for each ConcreteVisitor to implement.
    /// </summary>
    interface IVisitor
    {
        void Visit(Element element);
    }
}
