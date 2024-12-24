using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    /// <summary>
    /// Multiply
    /// class object designed to implement an multiplication when calculate is called.
    /// </summary>
    class Multiply :OperatorIF
    {
        public double calculate(double v1, double v2)
        {
            return (v1 * v2);
        }
    }
}
