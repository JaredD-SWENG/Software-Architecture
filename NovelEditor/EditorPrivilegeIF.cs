using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07
{
    /// <summary>
    /// Read only inetrface used by Editor class to enforce only specific method calls for Editor when workingw ith Archive objects.
    /// </summary>
    public interface EditorPrivilegeIF
    {
        public void save();
        public void retrieve();
        public void delete();
    }
}
