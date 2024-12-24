using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    /// <summary>
    /// Level1IF
    /// An interface for all Level 1 roles and below
    /// </summary>
    interface Level1IF
    {
        public void evacuate();
        public void seeDanger();
        public List<Level1IF> getSubordinates();
        public void setHeadPerson(Level2HeadPersonIF l2hp);
    }
}
