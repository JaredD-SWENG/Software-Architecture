using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07
{
    /// <summary>
    /// Frame
    /// Frame object may contain either a Column, Image, or any subclass of FrameableIF.
    /// </summary>
    class Frame : FrameAC
    {
        
        public Frame(List<FrameableIF> frafs)
        {
            setFrameables(frafs);
        }

        public override void delete()
        {
            foreach (FrameableIF fif in getFrameables())
            {
                fif.delete();
            }
        }

        public override void edit()
        {
            foreach (FrameableIF fif in getFrameables())
            {
                fif.edit();
            }
        }

        public override void retrieve()
        {
            foreach (FrameableIF fif in getFrameables())
            {
                fif.retrieve();
            }
        }

        public override void save()
        {
            foreach (FrameableIF fif in getFrameables())
            {
                fif.save();
            }
        }

        public override void view()
        {
            foreach (FrameableIF fif in getFrameables())
            {
                fif.view();
            }
        }
    }
}
