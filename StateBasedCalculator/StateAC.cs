using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    /// <summary>
    /// StateAC
    /// An abstract class that serves as the different states of the calculator. Hosts the form, two numbers, and operator.
    /// </summary>
    abstract class StateAC
    {
        internal static Form1 form;
        internal static double v1;
        internal static double v2;
        internal static OperatorIF opif = new NullOperator();


        public abstract StateAC statechange(char c);
        public abstract StateAC statechange(OperatorIF op);
        public abstract StateAC statechange(Equal eq);

        public string format(double d)
        {
            string result = (0 == (d - (int)d)) ? ("" + (int)d) : ("" + d);
            return result;
        }


    }
}
