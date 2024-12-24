using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07
{
    /// <summary>
    /// FrameAC
    /// FrameAC contains the composition relationship that allows objects to be stored withina frame. Any objects that wish to contain the same objects may subclass this.
    /// </summary>
    public abstract class FrameAC : ColumnableIF
    {
        public List<FrameableIF> fifs;

        public FrameAC()
        {
            fifs = new List<FrameableIF>();
        }

        public List<FrameableIF> getFrameables()
        {
            return fifs;
        }

        public void setFrameables(List<FrameableIF> list)
        {
            fifs = list;
        }

        abstract public void delete();

        abstract public void edit();


        abstract public void retrieve();

        abstract public void save();


        abstract public void view();
        
    }
}
