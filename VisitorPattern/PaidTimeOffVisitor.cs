using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern
{
    /// <summary>
    /// A Concrete Visitor class
    /// </summary>
    class PaidTimeOffVisitor : IVisitor
    {
        public void Visit(Element element)
        {
            Employee employee = element as Employee;

            employee.PaidTimeOffDays += 3;
            Console.WriteLine("{0} {1}'s new vacation days: {2}", employee.GetType().Name, employee.Name, employee.PaidTimeOffDays);
        }
    }
}
