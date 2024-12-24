using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07
{
    /// <summary>
    /// LineOfTextAC
    /// An abstract class that has LOTable items, and hosts LineOfText
    /// </summary>
    public abstract class LineOfTextAC : ColumnableIF
    {

        private List<LOTableIF> lotif;

        public LineOfTextAC()
        {
            lotif = new List<LOTableIF>();
        }

        public List<LOTableIF> getLOTables()
        {
            return lotif;
        }
        
        public void setLOTables(List<LOTableIF> lotables)
        {
            lotif = lotables;
        }

        abstract public void delete();

        abstract public void edit();

        abstract public void retrieve();

        abstract public void save();
        
        abstract public void view();
     }
}
