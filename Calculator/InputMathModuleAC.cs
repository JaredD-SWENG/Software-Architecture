using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05
{
    /// <summary>
    /// InputMathModuleAC 
    /// Subclass of MathModuleIF
    /// 
    /// An abstract class that provides common attributes and methods for modules that take in an input
    /// </summary>
    public abstract class InputMathModuleAC : MathModuleAC
    {


        protected double input;
        

        public double getInput()
        {
            return input;
        }

        /// <summary>
        /// Method creates and returns a pop up menu for user to input a value to use for certain math functions.
        /// </summary>
        /// <param name="title"></param> Title of Dialog Menu
        /// <param name="promptText"></param> Message for what input to ask for.
        /// <param name="input"></param> double value input from user to use for arithmetic.
        /// <returns></returns>/
        public DialogResult InputBox(string title, string promptText, ref double input)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;

            void textBox_KeyPress(object sender, KeyPressEventArgs e)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                    (e.KeyChar != '.' ) && (e.KeyChar != '-'))
                {
                    e.Handled = true;
                }

                // only allow one decimal point
                if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                {
                    e.Handled = true;
                }

                // only allow one minus sign
                if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
                {
                    e.Handled = true;
                }
            }

            textBox.KeyPress += textBox_KeyPress; //add custom local method to textBox

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(36, 36, 372, 13);
            textBox.SetBounds(36, 86, 700, 20);
            buttonOk.SetBounds(228, 160, 160, 60);
            buttonCancel.SetBounds(400, 160, 160, 60);

            label.AutoSize = true;
            form.ClientSize = new Size(796, 307);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;

            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();

            if (textBox.TextLength != 0)
            {
                input = Double.Parse(textBox.Text);
            }
            
            return dialogResult;

        }
    }
}
