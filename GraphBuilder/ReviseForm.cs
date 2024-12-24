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
    /// ReviseForm
    /// Form used to revise the graph selected by the user
    /// </summary>
    public partial class ReviseForm : Form
    {
        Graph revisedGraph;


        public ReviseForm(Graph graph)
        {
            InitializeComponent();
            revisedGraph = graph;


            foreach(ComponentIF cifs in graph.getComponents())
            {
                if(cifs is Vertex)
                {
                    vertex_ID_combobox.Items.Add((Vertex)cifs);
                    to_vertex_combobox.Items.Add((Vertex)cifs);
                    from_vertex_combobox.Items.Add((Vertex)cifs);
                }
                else
                {
                    edge_ID_combobox.Items.Add((Edge)cifs); 
                }
            }

        }

        private void ReviseForm_Load(object sender, EventArgs e)
        {
        }


        private void change_vertex_button_Click(object sender, EventArgs e)
        {
            if(!(vertex_ID_combobox == null))
            {
                ((Vertex)vertex_ID_combobox.SelectedItem).setX(System.Convert.ToInt32(xUpDown.Text));
                ((Vertex)vertex_ID_combobox.SelectedItem).setY(System.Convert.ToInt32(yUpDown.Text));
            }
        }

        private void change_edge_button_Click(object sender, EventArgs e)
        {
            if(!(edge_ID_combobox == null && !(((Vertex)from_vertex_combobox.SelectedItem).getX() == ((Vertex)to_vertex_combobox.SelectedItem).getX()) && (((Vertex)from_vertex_combobox.SelectedItem).getY() == ((Vertex)to_vertex_combobox.SelectedItem).getY())))
            {
                ((Edge)edge_ID_combobox.SelectedItem).setFromVertex((Vertex)from_vertex_combobox.SelectedItem);
                ((Edge)edge_ID_combobox.SelectedItem).setToVertex((Vertex)to_vertex_combobox.SelectedItem);
            }
        }

        private void done_button_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
