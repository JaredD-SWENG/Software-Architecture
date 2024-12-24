using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07
{
    /// <summary>
    /// Writer
    /// A class for a writer to view and edit
    /// </summary>
    class Writer
    {
        WriterPrivilegeIF writerPrivilegeIF;

        public Writer(WriterPrivilegeIF wif)
        {
            writerPrivilegeIF = wif;
        }

        public void doView()
        {
            writerPrivilegeIF.view();
        }
        public void doEdit()
        {
            writerPrivilegeIF.edit();
        }
    }
}
