using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Lab05
{
    /// <summary>
    /// Sum 
    /// Subclass of InputMathModuleAC
    /// provides method compute the sum  of two provided string numbers
    /// </summary>
    class Sum : InputMathModuleAC
    {
        public override double compute()
        {

            if (InputBox("Sum", "Please enter a value to add:", ref input) == DialogResult.OK)
            {
                double val = getCurrent() + input;
                return val;
            }

            return getCurrent();
        }

    }
}
