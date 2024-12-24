using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08
{
    /// <summary>
    /// Vizio_TV
    /// @author Jared Daniel
    /// @author Stuart Walters
    /// Class of Vizio TV's that extend Branded_TV.
    /// </summary>
    class Vizio_TV :Branded_TV
    {
        
        public Vizio_TV()
        {
            setBrand("Vizio");
            setType("Regular");
        }
    }
}
