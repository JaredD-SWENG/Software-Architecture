using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    /// <summary>
    /// CEO
    /// A concrete class that serves as the CEO of a company (which is a Level 1 role)
    /// </summary>
    class CEO : Level1Employee
    {
        private Decision chosenDecision;

        public CEO(string name) : base(name)
        {
            
        }
    }
}
