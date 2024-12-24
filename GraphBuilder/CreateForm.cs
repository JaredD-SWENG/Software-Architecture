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
    /// CreateForm
    /// Form called when User requests to create a graph. User can input many Vertex, Edges, and provide ID names to each.
    /// </summary>
    public partial class CreateForm : Form
    {
        GraphManager gm;
        List<Vertex> vertices;
        List<Edge> edges;

        public CreateForm()
        {
            InitializeComponent();
            gm = GraphManager.getInstance();
            vertices = new List<Vertex>();
            edges = new List<Edge>();            
        }

       

        private void CreateForm_Load(object sender, EventArgs e)
        { }
        private void add_vertex_button_Click(object sender, EventArgs e)
        {
            if  (!(vertex_ID_textbox.Text.Length == 0))
            {
                Vertex vx = new Vertex(System.Convert.ToInt32(vertex_ID_textbox.Text), Decimal.ToInt32(xUpDown.Value), Decimal.ToInt32(yUpDown.Value));
                vertices.Add(vx);
                from_vertex_combobox.Items.Add(vx);
                to_vertex_combobox.Items.Add(vx);

            }
        }


        private void vertex_ID_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }



        private void add_edge_button_Click(object sender, EventArgs e)
        {
            if( !(edge_ID_textbox.Text.Count() == 0) && !(from_vertex_combobox.SelectedItem == null || to_vertex_combobox.SelectedItem == null) && !(((Vertex)from_vertex_combobox.SelectedItem).getX() == ((Vertex)to_vertex_combobox.SelectedItem).getX()) && (((Vertex)from_vertex_combobox.SelectedItem).getY() == ((Vertex)to_vertex_combobox.SelectedItem).getY()))
            {
                Edge ed = new Edge(System.Convert.ToInt32(edge_ID_textbox.Text), (Vertex)from_vertex_combobox.SelectedItem, (Vertex)to_vertex_combobox.SelectedItem);
                edges.Add(ed);
            }
        }

        private void done_button_Click(object sender, EventArgs e)
        {

            
            if(!IDTaken(System.Convert.ToInt32(graph_ID_textbox.Text)) && !(graph_ID_textbox.Text.Count() == 0) && !(vertices.Count == 0))
            {
                List<ComponentIF> cifs = new List<ComponentIF>();
                foreach (Vertex v in vertices) { cifs.Add(v); }
                foreach (Edge ed in edges) { cifs.Add(ed); }

                gm.addGraph(gm.createGraph(System.Convert.ToInt32(graph_ID_textbox.Text), cifs));
                Close();

            }
  
        }

        private bool IDTaken(int ID)
        {
            List<GraphIF> graphs = gm.getGraphs();
            foreach (GraphIF g in graphs)
            {
                if (((Graph)g).getID() == ID) return true;
            }
            return false;
        }

        private void graph_ID_textbox_TextChanged(object sender, EventArgs e)
        {
            id_taken_label.Visible = IDTaken(System.Convert.ToInt32(((TextBox)sender).Text));
        }
    }
}
