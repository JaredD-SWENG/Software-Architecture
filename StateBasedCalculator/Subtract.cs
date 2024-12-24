using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    /// <summary>
    /// Subtract
    /// A class that calculates the subtraction of two numbers
    /// </summary>
    class Subtract:OperatorIF
    {
        public double calculate(double v1, double v2)
        {
            return (v1 - v2);
        }
    }
}
