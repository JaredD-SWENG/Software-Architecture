using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    /// <summary>
    /// TwoNumState
    /// A class that serves as the second operand state of the calculator
    /// </summary>
    class TwoNumState : StateAC
    {
        public override StateAC statechange(char c)
        {
            string result;
            if (form.v2IsFunctional == true)
            {
                result = "" + c;
                form.v2IsFunctional = false;
            }
            else
            result = form.GetTextBox().Text + c;
            v2 = Double.Parse(result);
            if (c == '0' && result.Contains('.'))
            {
                form.GetTextBox().Text = result;
            }
            else
                form.GetTextBox().Text = format(v2);
            return this;
        }

        public override StateAC statechange(OperatorIF op)
        {
            opif = op;
            v1 = opif.calculate(v1, v2);
            form.GetTextBox().Text = "" + v1;
            return form.operatorState;
        }


        public override StateAC statechange(Equal eq)
        {
            v1 = opif.calculate(v1, v2);
            form.GetTextBox().Text = format(v1);
            return form.equalState;
        }
    }
}
