using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Vizio_Smart_TV
/// @author Jared Daniel
/// @author Stuart Walters
/// Object represents a Vizio Brand Smart TV, delegates all power usage methods/attributes to instance of Smart_TV
/// </summary>
namespace Lab08
{
    class Vizio_Smart_TV:Vizio_TV,Smart_TV_IF
    {
        public Vizio_Smart_TV()
        {
            Smart_TV smart_TV = new Smart_TV();
            smart_TV.setPowerUsage(6.35);
            regularTV = smart_TV;
            setBrand("Vizio");
            setType("Smart");
        }
    }
}
