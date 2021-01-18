﻿using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern
{
    /// <summary>
    /// The Object Structure class, which is a collection of Concrete Elements.  
    /// This could be implemented using another pattern such as Composite.
    /// </summary>
    class Employees
    {
        private List<Employee> _employees = new List<Employee>();

        public void Attach(Employee employee)
        {
            _employees.Add(employee);
        }

        public void Detach(Employee employee)
        {
            _employees.Remove(employee);
        }

        public void Accept(IVisitor visitor)
        {
            foreach (Employee e in _employees)
            {
                e.Accept(visitor);
            }
            Console.WriteLine();
        }
    }

    class LineCook : Employee
    {
        public LineCook() : base("Dmitri", 32000, 7) { }
    }

    class HeadChef : Employee
    {
        public HeadChef() : base("Jackson", 69015, 21) { }
    }

    class GeneralManager : Employee
    {
        public GeneralManager() : base("Amanda", 78000, 24) { }
    }

}
