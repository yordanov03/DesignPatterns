using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern
{
    class IncomeVisitor : IVisitor
    {
        public void Visit(Element element)
        {
            Employee employee = element as Employee;

            employee.AnnualSalary *= 1.10;
            Console.WriteLine("{0} {1}'s income: {2:C}", employee.GetType().Name, employee.Name, employee.AnnualSalary);
        }
    }
}
