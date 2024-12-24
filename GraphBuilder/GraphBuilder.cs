using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{
    class GraphBuilder
    {
        /// <summary>
        /// GraphBuilder
        /// Class used as the prototype builder to provide copies of graphs
        /// </summary>
        /// <param name="graph"></param>
        /// <returns></returns>
        public Graph provideCopy(Graph graph)
        {
            Graph temp = null;
            try
            {
               temp = (Graph)graph.Clone();
            }catch(Exception e) { Console.WriteLine(e);  }

            return temp;
        }

    }
}
