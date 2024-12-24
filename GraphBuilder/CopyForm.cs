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
    /// CopyForm
    /// Form called during Graph Copy process, Form designed to request user for new ID for the graph copy.
    /// </summary>
    public partial class CopyForm : Form
    {
        GraphManager gm;
        public int ReturnID { get;  set; }
        public CopyForm()
        {
            InitializeComponent();
            gm = GraphManager.getInstance();
        }

        private void done_button_Click(object sender, EventArgs e)
        {
            if  (!(graph_ID_textbox.Text.Length == 0) && !(IDTaken(System.Convert.ToInt32(graph_ID_textbox.Text))))
            {
                this.ReturnID = System.Convert.ToInt32(graph_ID_textbox.Text);
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void graph_ID_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private bool IDTaken(int ID)
        {
            List<GraphIF> graphs = gm.getGraphs();
            foreach(GraphIF g in graphs)
            {
                if  (((Graph)g).getID() == ID) return true;
            }
            return false;
        }

        private void graph_ID_textbox_TextChanged(object sender, EventArgs e)
        {
            id_taken_label.Visible = IDTaken(System.Convert.ToInt32(graph_ID_textbox.Text));
        }
    }
}
