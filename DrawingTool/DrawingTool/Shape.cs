using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_SWENG421
{
    interface Shape
    {
        void DrawColoredShape(Graphics g, Pen pen, int sX, int sY, int eX, int eY);
    }
}
