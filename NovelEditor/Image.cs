using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07
{
    /// <summary>
    /// Image
    /// Object containable by LineOfText, Column, and Frame objects.
    /// </summary>
    class Image : LOTableIF, FrameableIF
    {
        
        public void delete()
        {
            Console.WriteLine("Image Deleted.");
        }

        public void edit()
        {
            Console.WriteLine("Image Edited.");
        }

        public void retrieve()
        {
            Console.WriteLine("Image Retrieved");
        }

        public void save()
        {
            Console.WriteLine("Image Saved.");
        }

        public void view()
        {
            Console.WriteLine("Image Viewed");
        }
    }
}
