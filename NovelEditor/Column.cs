using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07
{
    /// <summary>
    /// Column 
    /// Column may hold a Character, Image, LineOfText, or Frame, or any subclass of the ColumnableIF class.
    /// </summary>
    class Column : ColumnAC
    {
        
        public Column(List<ColumnableIF> colfs)
        {
            setColumnables(colfs);
        }

        public override void delete()
        {
            foreach (ColumnableIF cif in getColumnables())
            {
                cif.delete();
            }
        }

        public override void edit()
        {
            foreach (ColumnableIF cif in getColumnables())
            {
                cif.edit();
            }
        }

        public override void retrieve()
        {
            foreach (ColumnableIF cif in getColumnables())
            {
                cif.retrieve();
            }
        }

        public override void save()
        {
            foreach (ColumnableIF cif in getColumnables())
            {
                cif.save();
            }
        }

        public override void view()
        {
            foreach (ColumnableIF cif in getColumnables())
            {
                cif.view();
            }
        }
    }
}
