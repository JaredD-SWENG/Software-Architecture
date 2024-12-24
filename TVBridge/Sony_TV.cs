using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Sony_TV
/// @author Jared Daniel
/// @author Stuart Walters
/// Object represents a Sony brand TV, Extending TV behavior with new brand functionality.
/// </summary>
namespace Lab08
{
    class Sony_TV:Branded_TV
    {
        public Sony_TV()
        {
            setBrand("Sony");
            setType("Regular");
        }
    }
}
