using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    /// <summary>
    /// OneNumState
    /// One of the five major States,
    /// OneNumState is the state where the user is editing the first number
    /// pressing a digit alters the value v1, and transitions back to OneNumState
    /// pressing an operator transitions to OperatorState
    /// pressing '=' transitions to EqualState
    /// </summary>
    class OneNumState : StateAC
    {
        public override StateAC statechange(char c)
        {
            //check if isFunctional is true, if so, replace text and num. Else, append as usual.
            string result;
            if(form.v1IsFunctional == true)
            {
                result = "" + c;
                form.v1IsFunctional = false;
            }else
                result = form.GetTextBox().Text + c;

            v1 = Double.Parse(result);

            //if c == '0' && '.' > 1, DONT format, else format
            if(c == '0' && result.Contains('.'))
            {
                form.GetTextBox().Text = result;
            }else
                form.GetTextBox().Text = format(v1);
            return this;
        }

        public override StateAC statechange(OperatorIF op)
        {
            opif = op;
            v2 = v1;
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
