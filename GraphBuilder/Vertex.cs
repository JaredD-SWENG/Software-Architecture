using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab06
{
    /// <summary>
    /// Vertex
    /// A subclass of ComponentIF that represents the vertex in a directed graph
    /// </summary>
    class Vertex : ComponentIF
    {
        private int vertex_ID;
        private int x_coordinate;
        private int y_coordinate;

        public int getVertexID() { return vertex_ID; }
        public int getX() { return x_coordinate; }
        public void setX(int x) { this.x_coordinate = x; }
        public int getY() { return y_coordinate; }
        public void setY(int y) { this.y_coordinate = y; }

        public Vertex (int ID, int x, int y)
        {
            this.vertex_ID = ID;
            this.x_coordinate = x;
            this.y_coordinate = y;
        }

        public void draw(Graphics g)
        {
            Pen myPen = new Pen(System.Drawing.Color.Black, 5);
            Rectangle rect = new Rectangle(x_coordinate, y_coordinate, 50, 50);
            g.DrawEllipse(myPen, rect);
            
        }

        public object Clone()
        {
            return new Vertex(this.vertex_ID, this.x_coordinate, this.y_coordinate);
        }

        public override string ToString()
        {
            return "" + vertex_ID;
        }
    }
}
