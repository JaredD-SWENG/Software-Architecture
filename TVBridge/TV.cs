using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// TV
/// @author Jared Daniel
/// @author Stuart Walters
/// Object represents superclass of TV system. Provides base functionality for all TV classes.
/// </summary>
namespace Lab08
{
    public class TV
    {
        private int price;
        private string type;


        public TV()
        {
            setType("Regular");
        }


        internal void setPrice(int price)
        {
            this.price = price;
        }

        internal int getPrice()
        {
            return price;
        }

        internal string getType()
        {
            return type;
        }

        public void setType(string type)
        {
            this.type = type;
        }

        public virtual TV replenishTV(int budget)
        {
            return new TV();
        }

        public virtual void getInfo()
        {
            Console.WriteLine("Type of TV: " + getType());
            Console.WriteLine("Price of TV: " + getPrice());
        }
    }
}
