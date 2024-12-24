using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05
{
    /// <summary>
    /// Initialize 
    /// Subclass of InputMathModuleAC
    /// initializes a value
    /// </summary>
    class Initialize : InputMathModuleAC
    {
        public override double compute()
        {
            if (InputBox("Initialize", "Please enter a value to initialize:", ref input) == DialogResult.OK)
            {
                return input;
            }

            return getCurrent();
        }
    }
}
