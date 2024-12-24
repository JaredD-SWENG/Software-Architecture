using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    /// <summary>
    /// EqualState
    /// One of the five major States
    /// This State is entered when the '=' button is pressed.
    /// pressing a digit transitions to OneNumState
    /// pressing a operator transitions to OperatorState
    /// pressing '=' transitions back into EqualState
    /// </summary>
    class EqualState : StateAC
    {
        public override StateAC statechange(char c)
        {
            string result = "" + c;
            v1 = Double.Parse(result);
            form.GetTextBox().Text = format(v1);
            return form.oneNumState;
        }

        public override StateAC statechange(OperatorIF op)
        {
            opif = op;
            v2 = v1;
            return form.operatorState;
        }

        public override StateAC statechange(Equal eq)
        {
            //First check if operator is divide, and v2 is zero, if so go to invalid and set text to "result is undefinded"
            //else proceed as normal.

            v1 = opif.calculate(v1, v2);
            form.GetTextBox().Text = format(v1);
            return this;
        }
    }
}
