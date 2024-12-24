using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05
{
    /// <summary>
    /// Subtract
    /// Subclass of InputMathModuleAC
    /// provides method compute the difference of two provided string numbers
    /// </summary>
    class Subtract : InputMathModuleAC
    {
        public override double compute()
        {
            if (InputBox("Subtract", "Please enter a value to subtract:", ref input) == DialogResult.OK)
            {
                double val = getCurrent() - input;
                return val;
            }

            return getCurrent();
        }
    }
}
