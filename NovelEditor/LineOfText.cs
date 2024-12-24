using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07
{
    /// <summary>
    /// LineOFText
    /// Object designed to eb able to contain Character, and Image objects. While also being storeable inside the Column object as a ColumnableIF object.
    /// </summary>
    class LineOfText : LineOfTextAC
    {
        public LineOfText(List<LOTableIF> lotif)
        {
             setLOTables(lotif);
        }

        public override void delete()
        {
            foreach (LOTableIF lif in getLOTables())
            {
                lif.delete();
            }
        }

        public override void edit()
        {
            foreach (LOTableIF lif in getLOTables())
            {
                lif.edit();
            }
        }

        public override void retrieve()
        {
            foreach (LOTableIF lif in getLOTables())
            {
                lif.retrieve();
            }
        }

        public override void save()
        {
            foreach (LOTableIF lif in getLOTables())
            {
                lif.save();
            }
        }

        public override void view()
        {
            foreach (LOTableIF lif in getLOTables())
            {
                lif.view();
            }
        }
    }
}
