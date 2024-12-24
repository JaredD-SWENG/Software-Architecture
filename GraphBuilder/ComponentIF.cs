using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab06
{
    /// <summary>
    /// ComponentIF
    /// Interface super class for Edge and Vertex, provides draw method.
    /// </summary>
    public interface ComponentIF: ICloneable
    {
        void draw(Graphics g);
    }
}
