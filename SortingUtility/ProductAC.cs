using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    /**
     *  ProductAC
     *  Class extends the ProductIF interface, primary host of attributes and methods for any subclass objects.
     */
    abstract class ProductAC : ProductIF
    {
        private string ID;
        private string name;
        private double price;

        public ProductAC(string ID, string name, double price)
        {
            this.ID = ID;
            this.name = name;
            this.price = price;
        }

        public string getID()
        {
            return ID;
        }

        public string getName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public double getPrice()
        {
            return price;
        }

        public void setPrice(double price)
        {
            this.price = price;
        }

        /**
     *  CompareTo()
     *  Method takes in another ProductAC, and compares this objects price against the passed in object.
     */
        public int CompareTo(object obj)
        {
            ProductAC pac = obj as ProductAC;               ///Typecast object to be ProductAC for comparisons
            if (price > pac.getPrice()) return 1;           ///If this objects price is greater, return 1.
            else if  (price < pac.getPrice()) return -1;    ///Else if this object's price is lesser, return -1.
            return 0;                                       ///If this price is not greater or less than, it is the same and we return 0.
        }
    }
}
