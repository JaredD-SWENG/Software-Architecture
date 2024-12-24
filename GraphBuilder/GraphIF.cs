using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{
    /// <summary>
    /// GraphIF 
    /// Interface that implements IClonable
    /// </summary>
    interface GraphIF: ICloneable
    {
        void print(Graphics g);
    }
}
