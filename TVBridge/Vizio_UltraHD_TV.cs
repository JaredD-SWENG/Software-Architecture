using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08
{
    /// <summary>
    /// Vizio_UltraHD_TV
    /// @author Jared Daniel
    /// @author Stuart Walters
    /// Subclass of Vizio TV's that has UltraHD; implements UltraHD_TV_IF.
    /// </summary>

    class Vizio_UltraHD_TV :Vizio_TV, UltraHD_TV_IF
    {
        public Vizio_UltraHD_TV()
        {
            setBrand("Vizio");
            setType("UltraHD");
        }
    }
}
