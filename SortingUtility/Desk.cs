using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    /**
     *  Desk
     *  Class extends the ProductAC object. Passes arguments to superclass when constructed.
     */
    class Desk : ProductAC
    {
        public Desk(string ID, string name, double price) : base(ID, name, price) {}

    }
}
