using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07
{
    /// <summary>
    /// PageAC
    /// An abstract class that holds a novalable item and a host for a page
    /// </summary>
    public abstract class PageAC : NovelableIF
    {
        private List<PageableIF> pifs;

        public PageAC()
        {
            pifs = new List<PageableIF>();
        }

        public List<PageableIF> getPageables()
        {
            return pifs;            
        }
        public void setPageables(List<PageableIF> pifs)
        {
            this.pifs = pifs;
        }
        abstract public void delete();

        abstract public void edit();


        abstract public void retrieve();


        abstract public void save();

        abstract public void view();
     }
}
