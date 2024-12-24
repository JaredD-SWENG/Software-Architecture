using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    /// <summary>
    /// Divide
    /// class object designed to implement an division when calculate is called.
    /// </summary>
    class Divide :OperatorIF
    {
        public double calculate(double v1, double v2)
        {
            return (v1 / v2);
        }
    }
}
