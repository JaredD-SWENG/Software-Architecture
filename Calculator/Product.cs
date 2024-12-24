using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05
{
    /// <summary>
    /// Product 
    /// Subclass of InputMathModuleAC
    /// provides method compute the product of two provided string numbers
    /// </summary>
    class Product : InputMathModuleAC
    {
        public override double compute()
        {
            if (InputBox("Product", "Please enter a value to multiply:", ref input) == DialogResult.OK)
            {
                return (getCurrent() * input);
            }

            return getCurrent();
        }
    }
}
