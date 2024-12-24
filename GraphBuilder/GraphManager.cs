using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{
    /// <summary>
    /// GraphManager 
    /// Singleton class that is used to do user selected functions
    /// </summary>
    class GraphManager
    {
        private static GraphManager myInstance = new GraphManager();
        private List<GraphIF> graphs;
        private GraphBuilder gb;

        private GraphManager() { 
            graphs = new List<GraphIF>();
            gb = new GraphBuilder();
        }

        public static GraphManager getInstance()
        {
            return myInstance;
        }

        public Graph createGraph(int ID, List<ComponentIF> cifs)
        {

            Graph graph = new Graph(ID, cifs);
            return graph;
        }


        public void addGraph(Graph graph)
        {
            graphs.Add(graph);
        }

        public void reviseGraph(Graph graph)
        {

            ReviseForm rf = new ReviseForm(graph);
            rf.ShowDialog();
        }

        public List<GraphIF> getGraphs()
        {
            return graphs;
        }

        public Graph copyGraph(Graph graph)
        {
             return gb.provideCopy(graph);
        }

        public void printGraph(Graph graph, Graphics g)
        {
            graph.print(g);
        }
        
    }
}
