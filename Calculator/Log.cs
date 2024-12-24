using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05
{
    public class Log : MathModuleAC
    {
        /// <summary>
        /// Log 
        /// Subclass of MathModuleAC
        /// finds the logarithm of the number 
        /// </summary>
        public override double compute()
        {
            return Math.Log(getCurrent());
        }
    }
}
