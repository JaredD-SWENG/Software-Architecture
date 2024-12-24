using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    /**
     *  BubbleSortUtility<T>
     *  Class extends the normal behavior of the Utility class by overriding Utility's sort method
     */
    class BubbleSortUtility<T> : Utility<T>
    {
        public BubbleSortUtility() : base() { }

      /**
     *  sort<T>
     *  method calls superclass Utility's BubbleSort method, then proceeds to call a PrinterIF object to print out the result.
     */
        public override List<T> sort(List<T> data)
        {
            List<T> temp = base.sort(data); //Call Utility sort method
            PrinterIF<T> printer = new BubbleSortPrint<T>(); //instantiate printer object
            printer.print(temp); //print sorted list
            return temp;        //return sorted list
        }

        
    }
}
