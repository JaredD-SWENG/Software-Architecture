using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_SWENG421
{
    class RectShape : Shape
    {
        public void DrawColoredShape(Graphics g, Pen pen, int sX, int sY, int eX, int eY)
        {
            int w = Math.Abs(sX - eX);
            int h = Math.Abs(sY - eY);

            if (sX <= eX && sY < eY)
            {
                g.DrawRectangle(pen, sX, sY, w, h);
            }
            else if (sX > eX && sY > eY)
            {
                g.DrawRectangle(pen, eX, eY, w, h);
            }
            else if (sX > eX && sY <= eY)
            {
                g.DrawRectangle(pen, eX, sY, w, h);
            }
            else if (sX <= eX && sY >= eY)
            {
                g.DrawRectangle(pen, sX, eY, w, h);
            }
            
        }
    }
}
