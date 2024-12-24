using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    /// <summary>
    /// Supervisor
    /// A concrete class that serves as the Supervisor (which is a Level 3 role)
    /// </summary>
    class Supervisor : Level3Employee
    {
        public Supervisor(string name) : base(name) { }
    }
}
