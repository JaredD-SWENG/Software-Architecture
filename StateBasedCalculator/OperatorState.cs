using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    /// <summary>
    /// OperatorState
    /// A class that serves as the state of the calculator when operator has been pressed.
    /// </summary>
    class OperatorState : StateAC
    {
        public override StateAC statechange(char c)
        {
            string result = "" + c;
            v2 = Double.Parse(result);
            form.GetTextBox().Text = format(v2);
            return form.twoNumState;
        }

        public override StateAC statechange(OperatorIF op)
        {
            opif = op;
            return this;
        }

      

        public override StateAC statechange(Equal eq)
        {
            v1 = opif.calculate(v1,  v2);
            form.GetTextBox().Text = format(v1);
            return form.equalState;
        }
    }
}
