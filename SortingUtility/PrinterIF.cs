using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    /**
     *  PrinterIF<T>
     *  Interface designed to prime a series of subclass printer objects, each utilizing a print() method with unique behaviors as needed.
     */
    public interface PrinterIF<T>
    {
        public void print(List<T> data);
    }
}
