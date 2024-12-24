using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07
{
    /// <summary>
    /// AdministratorPrivledgeIF
    /// Read-Only interfacxe used by Administrator class to call all needed methods on ArchiveIF objects
    /// </summary>
    public interface AdministratorPrivilegeIF: EditorPrivilegeIF, WriterPrivilegeIF
    {
    }
}
