using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    /// <summary>
    /// Worker
    /// A concrete class that serves as the Worker (which is a Level 4 role)
    /// </summary>
    class Worker : Level4Employee
    {
        public Worker(string name) : base(name) { }
    }
}
