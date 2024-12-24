using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Sony_UltraHD_TV
/// @author Jared Daniel
/// @author Stuart Walters
/// Object represents a Sony brand TV, Extending TV behavior with new brand functionality.
/// </summary>
namespace Lab08
{
    class Sony_UltraHD_TV:Sony_TV, UltraHD_TV_IF
    {
        public Sony_UltraHD_TV()
        {
            setBrand("Sony");
            setType("UltraHD");
        }        
    }
}
