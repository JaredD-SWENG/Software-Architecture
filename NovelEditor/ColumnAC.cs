using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07
{
    /// <summary>
    /// ColumnAC contains a composition relationship to any Objects that may be stored within a Column object.
    /// </summary>
    public abstract class ColumnAC : FrameableIF
    {
        private List<ColumnableIF> cifs;

        public ColumnAC()
        {
            cifs = new List<ColumnableIF>();
        }

        public List<ColumnableIF> getColumnables()
        {
            return cifs;
        }
        public void setColumnables(List<ColumnableIF> cifs)
        {
            this.cifs = cifs;
        }

        abstract public void delete();

        abstract public void edit();

        abstract public void retrieve();

        abstract public void save();

        abstract public void view();
    }
}
