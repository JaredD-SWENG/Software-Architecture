using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    
    /**
     * BubbleSortPrint<T>
     * Class prints out a List of object type ProductIF in the order of: ID, name, then price.
     */
    class BubbleSortPrint<T> : PrinterIF<T>
    {
        public void print(List<T> data)
        {
            List<ProductIF> temp = data as List<ProductIF>; ///Type cast generic type to be ProductIF
            
            ///For each ProductAC object in the List, print out the ID, name, then price of the object.
            foreach (ProductIF pac in temp)
            {
                Console.WriteLine("ID: " + ((ProductAC)pac).getID() + ", Name: " + ((ProductAC)pac).getName() + ", Price: " + ((ProductAC)pac).getPrice());
            }
        }
    }
}
