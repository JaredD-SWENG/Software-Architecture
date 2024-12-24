using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab11
{
    /// <summary>
    /// Form1
    /// Authors: Jared Daniel, Stuart Walters
    /// Form1 is the form for the calculator app, hosting many declared object instances that are shared through the rest of the App.
    /// </summary>
    public partial class Form1 : Form
    {
        internal OneNumState oneNumState = new OneNumState();
        internal TwoNumState twoNumState = new TwoNumState();
        internal OperatorState operatorState = new OperatorState();
        internal EqualState equalState = new EqualState();
        internal InvalidState invalidState = new InvalidState();
        internal StateAC state;

        internal Add add = new Add();
        internal Multiply mult = new Multiply();
        internal Divide div = new Divide();
        internal Subtract sub = new Subtract();
        internal Equal eqs = new Equal();
        internal bool v1IsFunctional;
        internal bool v2IsFunctional;


        public Form1()
        {
            InitializeComponent();
            char sqrtchr = Convert.ToChar(0x221A);
            string sqrtstr = "" + sqrtchr;
            squareRoot.Text = sqrtstr;
            char signflpchr = Convert.ToChar(177);
            string signflpstr = "" + signflpchr;
            signFlip.Text = signflpstr;
            char backspacechr = Convert.ToChar(0x2190);
            string backspacestr = "" + backspacechr;
            backSpace.Text = backspacestr;
            state = oneNumState;
            StateAC.v1 = 0;
            StateAC.v2 = 0;
            StateAC.form = this;
            v1IsFunctional = false;
            v2IsFunctional = false;
            textBox1.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public TextBox GetTextBox()
        {
            return textBox1;
        }

        public void enterInvalidState()
        {
            reciprocal.Enabled = false;
            squareRoot.Enabled = false;
            period.Enabled = false;
            signFlip.Enabled = false;
            plus.Enabled = false;
            minus.Enabled = false;
            divide.Enabled = false;
            multiply.Enabled = false;
        }
        public void exitInvalidState()
        {
            reciprocal.Enabled = true;
            squareRoot.Enabled = true;
            period.Enabled = true;
            signFlip.Enabled = true;
            plus.Enabled = true;
            minus.Enabled = true;
            divide.Enabled = true;
            multiply.Enabled = true;
        }

        private void reciprocal_Click(object sender, EventArgs e)
        {
            if((state == oneNumState && StateAC.v1 == 0 || state == equalState && StateAC.v1 == 0) || (state == twoNumState && StateAC.v2 == 0))
            {
                textBox1.Text = "Cannot divide by zero";
                enterInvalidState();
                state = invalidState;
            }
            else if(state == oneNumState || state == equalState)
            {
                v1IsFunctional = true;
                StateAC.v1 = Math.Pow(StateAC.v1, -1);
                textBox1.Text = state.format(StateAC.v1);
            }
            else
            {
                v2IsFunctional = true;
                StateAC.v2 = Math.Pow(StateAC.v2, -1);
                textBox1.Text = state.format(StateAC.v2);
            }
        }

        private void squareRoot_Click(object sender, EventArgs e)
        {
            if ((state == oneNumState && StateAC.v1 < 0) || (state == twoNumState && StateAC.v2 < 0))
            {
                textBox1.Text = "Result is undefined";
                enterInvalidState();
                state = invalidState;
            }
            else if (state == oneNumState || state == equalState)
            {
                v1IsFunctional = true;
                StateAC.v1 = Math.Sqrt(StateAC.v1);
                textBox1.Text = state.format(StateAC.v1);
            }
            else
            {
                v2IsFunctional = true;
                StateAC.v2 = Math.Sqrt(StateAC.v2);
                textBox1.Text = state.format(StateAC.v2);
            }
        }

        private void equals_Click(object sender, EventArgs e)
        {
            state = state.statechange(eqs);
        }

        private void digit7_Click(object sender, EventArgs e)
        {
            state = state.statechange('7');
        }

        private void digit8_Click(object sender, EventArgs e)
        {
            state = state.statechange('8');
        }

        private void digit9_Click(object sender, EventArgs e)
        {
            state = state.statechange('9');
        }

        private void digit4_Click(object sender, EventArgs e)
        {
            state = state.statechange('4');
        }

        private void digit5_Click(object sender, EventArgs e)
        {
            state = state.statechange('5');
        }

        private void digit6_Click(object sender, EventArgs e)
        {
            state = state.statechange('6');
        }

        private void digit1_Click(object sender, EventArgs e)
        {
            state = state.statechange('1');
        }

        private void digit2_Click(object sender, EventArgs e)
        {
            state = state.statechange('2');
        }

        private void digit3_Click(object sender, EventArgs e)
        {
            state = state.statechange('3');
        }

        private void digit0_Click(object sender, EventArgs e)
        {
            state = state.statechange('0');

        }

        private void backSpace_Click(object sender, EventArgs e)
        {
            //check if one num or 2 num
            //if 1 num, edit textbox, parse new num to v1.
            //else if 2num, edit textbox, parse new num to v2.
            //special cases
            //if you "clear" the digits (I.E, only 1 digit when backspacing) set textbox and value to '0'.
            //make sure also to not have only '-' in textbox
            //if  -10 < v1||v2 < 10 set to '0'
            if(state == oneNumState)
            {
                if(StateAC.v1 > -10 && StateAC.v1 < 10)
                {
                    textBox1.Text = "0";
                    StateAC.v1 = 0;
                }
                else
                {
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                    StateAC.v1 = Double.Parse(textBox1.Text);
                }
            }
            else if (state == twoNumState)
            {
                if (StateAC.v2 > -10 && StateAC.v2 < 10)
                {
                    textBox1.Text = "0";
                    StateAC.v2 = 0;
                }
                else
                {
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                    StateAC.v2 = Double.Parse(textBox1.Text);
                }
            }
        }

        private void clearEntry_Click(object sender, EventArgs e)
        {
            if(state == oneNumState || state == equalState)
            {
                StateAC.v1 = 0;
                textBox1.Text = "" + 0;
            }
            else
            {
                StateAC.v2 = 0;
                textBox1.Text = "" + 0;
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            StateAC.v1 = 0;
            StateAC.v2 = 0;
            StateAC.opif = new NullOperator();
            textBox1.Text = "" + 0;
            state = oneNumState;
        }

        private void signFlip_Click(object sender, EventArgs e)
        {
            if (state == oneNumState || state == equalState)
            {
                StateAC.v1 *= -1;
                textBox1.Text = state.format(StateAC.v1);
            }
            else if(state == twoNumState)
            {
                StateAC.v2 *= -1;
                textBox1.Text = state.format(StateAC.v2);
            }
            else
            {
                StateAC.v2 = StateAC.v1 * -1;
                textBox1.Text = state.format(StateAC.v2);
            }
        }

        private void divide_Click(object sender, EventArgs e)
        {
            state = state.statechange(div);
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            state = state.statechange(mult);
        }

        private void minus_Click(object sender, EventArgs e)
        {
            state = state.statechange(sub);
        }

        private void plus_Click(object sender, EventArgs e)
        {
            state = state.statechange(add);
        }

        private void period_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains('.') && !(state == operatorState))
            {
                if(!(state == operatorState))
                {
                    textBox1.Text += '.';
                }
                
            }else if (state == operatorState)
            {
                StateAC.v2 = 0.0;
                textBox1.Text = "0.";
                state = twoNumState;
            }
                
        }
    }
}
