using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    /// <summary>
    /// InvalidState
    /// One of the five major States,
    /// InvalidState occurs when the user divides by zero, or attempts to square root a negative number.
    /// entering this state deactivates certain buttons to only allow the user to enter a digit to proceed.
    /// </summary>
    class InvalidState : StateAC
    {
        public override StateAC statechange(char c)
        {
            string result = "" + c;
            v1 = Double.Parse(result);
            v2 = 0;
            form.exitInvalidState();
            form.GetTextBox().Text = "" + v1;

            return form.oneNumState;
        }

        public override StateAC statechange(OperatorIF op)
        {
            throw new NotImplementedException();
        }


        public override StateAC statechange(Equal eq)
        {
            string result = "" + 0;
            v1 = Double.Parse(result);
            v2 = 0;
            form.exitInvalidState();
            form.GetTextBox().Text = "" + v1;

            return form.oneNumState;
        }
    }
}
