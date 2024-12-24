using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07
{
    /// <summary>
    /// Administrator class object should be able to call all special methods of any ArchiveIF object
    /// </summary>
    class Adminstrator
    {
        AdministratorPrivilegeIF administratorPrivilegeIF;

        public Adminstrator(AdministratorPrivilegeIF adminif)
        {
            administratorPrivilegeIF = adminif;
        }

        public void doView()
        {
            administratorPrivilegeIF.view();
        }
        public void doEdit()
        {
            administratorPrivilegeIF.edit();
        }
        public void doRetrieve()
        {
            administratorPrivilegeIF.retrieve();
        }
        public void doSave()
        {
            administratorPrivilegeIF.save();
        }
        public void doDelete()
        {
            administratorPrivilegeIF.delete();
        }
    }
}
