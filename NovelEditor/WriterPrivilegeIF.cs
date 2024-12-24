using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07
{
    /// <summary>
    /// WriterPrivilegeIF
    /// An interface that outlines the privelages for a writer
    /// </summary>
    public interface WriterPrivilegeIF
    {
        public void view();
        public void edit();
    }
}
