using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Sony_Smart_TV
/// @author Jared Daniel
/// @author Stuart Walters
/// Object represents a Sony Brand Smart TV, delegates all power usage methods/attributes to instance of Smart_TV
/// </summary>
namespace Lab08
{
    class Sony_Smart_TV:Sony_TV,Smart_TV_IF
    {
        public Sony_Smart_TV()
        {
            Smart_TV smart_TV = new Smart_TV();
            smart_TV.setPowerUsage(5.15);
            regularTV = smart_TV;
            setBrand("Sony");
            setType("Smart");

        }
    }
}
