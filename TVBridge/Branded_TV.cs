using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08
{
    class Branded_TV: Proxy_TV, TV_IF
    {
        private string brand;

        internal string getBrand()
        {
            return brand;
        }

        internal void setBrand(string brand)
        {
            this.brand = brand;
        }

        override public void getInfo()
        {
            base.getInfo();
            Console.WriteLine("Brand: " + getBrand());
        }
    }
}
