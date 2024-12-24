using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{

    /**
     *  Utility<T>
     *  Host Superclass associated with class XYZ. Capable of taking in generic objects of type T, but mainly focused on taking ProductIF objects.
     */
    public class Utility<T>
    {
        string sortName;

        public Utility()
        {
            sortName = "bubblesort";
        }

        public Utility(string sortName)
        {
            this.sortName = sortName;
        }

        /**
     *  sort<T>
     *  Method takes List of ProductIF and performs a BubbleSort algorithm, then returns the result.
     */
        virtual public List<T> sort(List<T> data)
        {
            List<ProductIF> pac = data as List<ProductIF>;
            ProductIF temp;

            for(int j = 0; j <= data.Count - 2; j++)
            {
                for(int i = 0; i <= data.Count - 2; i++)
                {
                    if(pac[i].CompareTo(pac[i+1] as Object) > 0)
                    {
                        temp = pac[i + 1];
                        pac[i + 1] = pac[i];
                        pac[i] = temp;
                    }
                }
            }

            return pac as List<T>;
        }

        public string getName()
        {
            return sortName;
        }

    }
}
