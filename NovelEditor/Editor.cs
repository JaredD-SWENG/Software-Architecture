using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07
{
    /// <summary>
    /// Editor object may call three specific methods of any Archive object. These methods are save, retrieve, and delete.
    /// </summary>
    class Editor
    {
        EditorPrivilegeIF editorPrivilegeIF;

        public Editor(EditorPrivilegeIF eif)
        {
            editorPrivilegeIF = eif;
        }

        public void doSave()
        {
            editorPrivilegeIF.save();
        }
        public void doRetrieve()
        {
            editorPrivilegeIF.retrieve();
        }
        public void doDelete()
        {
            editorPrivilegeIF.delete();
        }
    }
}
