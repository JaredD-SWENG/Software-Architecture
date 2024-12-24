using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab06
{
    /// <summary>
    /// Form1
    /// Form1 called on Program start up, acts as main menu for all other functions for the Program Lab06.
    /// </summary>
    public partial class Form1 : Form
    {
        GraphManager gm;
        Bitmap bm;
        Graphics bgm;
        public Form1()
        {
            InitializeComponent();
            gm = GraphManager.getInstance();
            bm = new Bitmap(panel1.Width,  panel1.Height);
            bgm = Graphics.FromImage(bm);
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void create_button_Click(object sender, EventArgs e)
        {
            CreateForm createForm = new CreateForm();
            createForm.ShowDialog();
            Graph newGraph = (Graph)gm.getGraphs()[gm.getGraphs().Count - 1];
            graph_ID_combobox.Items.Add(newGraph);
            
        }

        private void revise_button_Click(object sender, EventArgs e)
        {
            if(graph_ID_combobox.SelectedItem != null)
                gm.reviseGraph((Graph)graph_ID_combobox.SelectedItem);

        }

        private void copy_button_Click(object sender, EventArgs e)
        {
            if (graph_ID_combobox.SelectedItem != null)
            {
                Graph temp = gm.copyGraph((Graph)graph_ID_combobox.SelectedItem);
                gm.addGraph(temp);
                graph_ID_combobox.Items.Add(temp);
            }
            
        }

        private void print_button_Click(object sender, EventArgs e)
        {
            if  (graph_ID_combobox.SelectedItem != null)
            {
                bgm.FillRectangle(Brushes.White, new Rectangle(0,  0,  panel1.Width,  panel1.Height));
                gm.printGraph((Graph)graph_ID_combobox.SelectedItem, bgm);
                Graphics g = panel1.CreateGraphics();
                g.DrawImage(bm,  0,  0);
            }
        }
    }
}
