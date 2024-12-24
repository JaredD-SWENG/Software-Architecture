using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05
{
    /**
     * MathModuleFactory
     * 
     * A class that serves as the factory to build specific math modules
     */
    class MathModuleFactory
    {
        public MathModuleIF callModule(string module, double current)
        {
            module = "Lab05." + module;
            Type t = Type.GetType(module);
            MathModuleIF mmif = (MathModuleIF)Activator.CreateInstance(t);
            ((MathModuleAC)mmif).setCurrent(current);
            return mmif;
        }
    }
}
