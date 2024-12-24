using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05
{

    /// <summary>
    /// InputMathModuleAC 
    /// Subclass of MathModuleIF
    /// 
    /// An abstract class that provides common attributes for current stored value in calculator
    abstract public class MathModuleAC: MathModuleIF
    {
        private double current;
        abstract public double compute();
        public void setCurrent(double current) { this.current = current ;  }
        public double getCurrent() { return current ;  }
    }
}
