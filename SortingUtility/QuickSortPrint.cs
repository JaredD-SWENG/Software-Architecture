using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    /**
     * QuickSortPrint<T>
     * Class that prints out List of objects of type ProductIF in the order: Price, name, ID
     */
    class QuickSortPrint<T> : PrinterIF<T>
    {
        public void print(List<T> data)
        {
            List<ProductIF> temp = data as List<ProductIF>; //Typecasting to ProductIF

            //For each ProductAC object in the List, print out the ID, name, then price of the object.
            foreach (ProductIF pac in temp)
            {
                Console.WriteLine("Price: " + ((ProductAC)pac).getPrice() + ", Name: " + ((ProductAC)pac).getName() + ", ID: " + ((ProductAC)pac).getID());
            }
        }
    }
}
