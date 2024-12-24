using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07
{
    /// <summary>
    /// Novel
    /// A class that holds novelable items and performs various tasks.
    /// </summary>
    class Novel : NovelAC
    {
        
        public Novel(List<NovelableIF> nifs)
        {
            setNovelables(nifs);
        }

        public override void delete()
        {
            foreach (NovelableIF nif in getNovelables())
            {
                nif.delete();
            }
        }

        public override void edit()
        {
            foreach (NovelableIF nif in getNovelables())
            {
                nif.edit();
            }
        }

        public override void retrieve()
        {
            foreach (NovelableIF nif in getNovelables())
            {
                nif.retrieve();
            }
        }

        public override void save()
        {
            foreach (NovelableIF nif in getNovelables())
            {
                nif.save();
            }
        }

        public override void view()
        {
            foreach(NovelableIF nif in getNovelables())
            {
                nif.view();
            }
        }
    }
}
