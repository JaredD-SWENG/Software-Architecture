using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05
{

    /// <summary>
    /// Power 
    /// Subclass of InputMathModuleAC
    /// provides method compute the current value to the power of the input value.
    /// </summary>
    class Power : InputMathModuleAC
    {
        public override double compute()
        {
            if (InputBox("Power", "Please enter the exponent:", ref input) == DialogResult.OK)
            {
                double val = Math.Pow(getCurrent(), input);
                return val;
            }

            return getCurrent();
        }
    }
}
