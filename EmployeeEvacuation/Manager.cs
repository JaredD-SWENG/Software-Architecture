using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    /// <summary>
    /// Manager
    /// A concrete class that serves as the Manager (which is a Level 2 role)
    /// </summary>
    class Manager : Level2Employee
    {
        public Manager(string name) : base(name)
        {

        }
    }
}
