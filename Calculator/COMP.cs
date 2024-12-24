using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05
{

    public partial class COMP : Form
    {
        MathModuleFactory factory;
        MathModuleIF mmif;
        

        public COMP()
        {
            
           
            InitializeComponent();
            StreamReader streamReader = File.OpenText("..\\..\\modules.txt");
            string line = streamReader.ReadLine();

            while (line != null)
            {
                comboBox1.Items.Add(line);
                line = streamReader.ReadLine();
            }
            factory = new MathModuleFactory();
            mmif = new Initialize();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            label1.Text = mmif.compute().ToString();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            mmif = factory.callModule((string)cb.SelectedItem, Double.Parse(label1.Text));
        }

    }
}