using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    /**
     * QuickSortUtility<T>
     * Class that extends the features of Utility by overriding sort method 
     */
    class QuickSortUtility<T> : Utility<T>
    {
        public QuickSortUtility(string sortName): base(sortName){ }

        /**
         * sort method that uses C#'s built in sort utilizing Quicksort algorithm, and then uses PrinterIF to print sorted data
         */
        public override List<T> sort(List<T> data)
        {
            data.Sort();
            PrinterIF<T> printer = new QuickSortPrint<T>();
            printer.print(data);
            return data;
        }

     
    }
}
