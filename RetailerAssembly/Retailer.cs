using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab08;


/// <summary>
/// Retailer
/// @author Jared Daniel
/// @author Stuart Walters
/// class is responsible for creating a object instance of TV and calling its Info.
/// </summary>
namespace RetailerAssembly
{
    class Retailer
    {
        TV tv;
        public Retailer()
        {
            tv = new Proxy_TV();
        }

        public void OrderTV(int budget)
        {
            Proxy_TV ptv = new Proxy_TV();
            tv = ptv.replenishTV(budget);

            if (tv != null) tv.getInfo();
            else
            {
                Console.WriteLine("You do not have a TV.");
            }

        }
    }
}
