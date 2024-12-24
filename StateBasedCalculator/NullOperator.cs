using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    /// <summary>
    /// NullOperator
    /// Null Object design pattern object, created to protect the App when an operator has not yet been selected, yet the user attempts to calculate.
    /// </summary>
    class NullOperator :OperatorIF
    {
        public double calculate(double v1, double v2) { return v1 ;  }
    }
}
