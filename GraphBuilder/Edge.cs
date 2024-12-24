using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab06
{
    /// <summary>
    /// Edge
    /// Edge is a class designed to act as a directed edge between two given Vertex objects.
    /// </summary>
    class Edge : ComponentIF
    {
        private int edge_ID;
        private Vertex from_vertex;
        private Vertex to_vertex;

        public Edge(int ID, Vertex from_vertex, Vertex to_vertex)
        {
            this.edge_ID = ID;
            this.from_vertex = from_vertex;
            this.to_vertex = to_vertex;
        }

        public int getEdgeID() { return edge_ID;  }
        public Vertex getFromVertex() { return from_vertex;  }
        public void setFromVertex(Vertex vertex) { from_vertex = vertex ;  }
        public Vertex getToVertex() { return to_vertex ;  }
        public void setToVertex(Vertex vertex) { to_vertex = vertex;  }

        public void draw(Graphics g)
        {
            //draw a line, from from_vertex, to  to_vertex. With a little arrow on the to end.

            int s = 25;
            int v = from_vertex.getY() > to_vertex.getY()  ? -1  : 1;
            double d = cosine(new Point(to_vertex.getX() - from_vertex.getX(), to_vertex.getY() - from_vertex.getY()), new Point(v, 0));
            double x = from_vertex.getX() + s + v * s * d;
            double y = from_vertex.getY() + s + v * s * Math.Sqrt(1 - d * d);
            double x2 = to_vertex.getX() + s - v * s * d;
            double y2 = to_vertex.getY() + s - v * s * Math.Sqrt(1 - d * d);
            Pen myPen = new Pen(System.Drawing.Color.Black, 5);
            g.DrawLine(myPen, (int)x, (int)y, (int)x2, (int)y2);
            g.FillEllipse(Brushes.Black, (int)(x - 5), (int)(y - 5), 10, 10);
            Point p = compute(new Point(to_vertex.getX() - from_vertex.getX(), to_vertex.getY() - from_vertex.getY()), Math.PI / 6);
            g.DrawLine(myPen, (int)x2, (int)y2, (int)x2 + p.X, (int)y2 + p.Y);
            p = compute(new Point(to_vertex.getX() - from_vertex.getX(), to_vertex.getY() - from_vertex.getY()), -Math.PI / 6);
            g.DrawLine(myPen, (int)x2, (int)y2, (int)x2 + p.X, (int)y2 + p.Y);

        }

        public double cosine(Point p1, Point p2)
        {
            //function calculated cosine for drawing purposes.
            double d0 = p1.X * p2.X + p1.Y * p2.Y;
            double d1 = Math.Sqrt(p1.X  *  p1.X  +  p1.Y  *  p1.Y);
            return d0  /  d1;
        }

        public Point compute(Point p1, double angle)
        {
            //function computes the angle to draw the arrowhead.
            double d1 = Math.Sqrt(p1.X  *  p1.X  +  p1.Y  *  p1.Y);
            double x = -20   *   p1.X   /   d1;
            double y = -20   *   p1.Y   /   d1;
            double nx = x  *  Math.Cos(angle) - y  *  Math.Sin(angle);
            double ny = x * Math.Sin(angle) + y  *  Math.Cos(angle);
            return new Point((int)nx, (int)ny);
        }

        public object Clone()
        {
            //Generate Clones of attributes.
            Vertex fromClone = (Vertex)from_vertex.Clone();
            Vertex toClone = (Vertex)to_vertex.Clone();
            //return new ionstance of cloned object.
            return new Edge(this.edge_ID, fromClone, toClone);
        }

        public override string ToString()
        {
            return "" + edge_ID;
        }
    }
}
