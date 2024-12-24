using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    /// <summary>
    /// Employee
    /// A superclass for all employees
    /// </summary>
    class Employee
    {
        private string name;

        public Employee(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return name;
        }
        public void setName(string name)
        {
            this.name = name;
        }
    }
}
