using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07
{
    /// <summary>
    /// Page
    /// A class that holds pageable items and perfoms various tasks
    /// </summary>
    class Page : PageAC
    {
        
        public Page(List<PageableIF> pifs)
        {
            setPageables(pifs);
        }
        public override void delete()
        {
            foreach (PageableIF pif in getPageables())
            {
                pif.delete();
            }
        }

        public override void edit()
        {
            foreach (PageableIF pif in getPageables())
            {
                pif.edit();
            }
        }

        public override void retrieve()
        {
            foreach (PageableIF pif in getPageables())
            {
                pif.retrieve();
            }
        }

        public override void save()
        {
            foreach (PageableIF pif in getPageables())
            {
                pif.save();
            }
        }

        public override void view()
        {
            foreach(PageableIF pif in getPageables())
            {
                pif.view();
            }
        }
    }
}
