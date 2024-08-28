using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCentreTest.Employees
{
    internal abstract class Employee
    {
        public string name { get; private set; }

        public Employee(string name)
        {
            this.name = name;
        }
    }
}
