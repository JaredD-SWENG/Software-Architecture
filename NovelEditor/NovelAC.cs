using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07
{
    /// <summary>
    /// NovelAC
    /// An abstract class that hosts novelable items, and generalizes ArchiveIF
    /// </summary>
    public abstract class NovelAC: ArchiveIF
    {
        private List<NovelableIF> novelableIFs;

        public NovelAC()
        {
            novelableIFs = new List<NovelableIF>();
        }

        abstract public void delete();

        abstract public void edit();

        public List<NovelableIF> getNovelables()
        {
             return novelableIFs;
        }

        abstract public void retrieve();

        abstract public void save();

        public void setNovelables(List<NovelableIF> nifs)
        {
            novelableIFs = nifs;
        }

        abstract public void view();
    }
}
