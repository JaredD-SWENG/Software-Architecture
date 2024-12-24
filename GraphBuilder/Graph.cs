using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab06
{
    /// <summary>
    /// Graph
    /// Subclass of GraphIF that represents the directed graph 
    /// </summary>
    public class Graph : GraphIF
    {
        private List<ComponentIF> cifs;
        private int graph_ID;
        

        public Graph(int ID, List<ComponentIF> cifs)
        {
            this.graph_ID = ID;
            this.cifs = cifs;
        }

        public List<ComponentIF> getComponents() { return cifs ;  }

        public int getID() { return graph_ID; }


        public object Clone()
        {
            List<ComponentIF> cloneList = new List<ComponentIF>();
            foreach  (ComponentIF c in cifs)
            {
                if  (c is Vertex)
                {
                    cloneList.Add((Vertex)c.Clone());
                }
                else
                {
                    cloneList.Add((Edge)c.Clone());
                }
            }

            int cloneID = 0;
            CopyForm cf = new CopyForm();
            cf.ShowDialog();
            if  (cf.DialogResult == DialogResult.OK)
            {
                cloneID = cf.ReturnID;
            }
            return new Graph(cloneID, cloneList);
        }

        public void print(Graphics g)
        {
            //for each ConponentIF we, DRAW to bgm.

            foreach(ComponentIF c in cifs)
            {
                c.draw(g);
            }

        }

        public override string ToString()
        {
            return "" + graph_ID;
        }
    }
}
