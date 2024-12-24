using System;
using System.Collections.Generic;

namespace Lab07
{
    class Program
    {
        static void Main(string[] args)
        {
            //Novel contains page

            //Page contains a Column and a Frame

            //Column contains a Line of text

            //That line of text contains 5 characters "SWENG"

            //The Frame in Page contains ANOTHER column

            //That column contains a line of text

            //that line of text contains 3 characters "421"

            //Writer is going to call te novels view method.

            //Should see "SWENG421"
            
            Character char1 = new Character('S');
            Character char2 = new Character('W');
            Character char3 = new Character('E');
            Character char4 = new Character('N');
            Character char5 = new Character('G');
            
            Character char6 = new Character('4');
            Character char7 = new Character('2');
            Character char8 = new Character('1');

            List<LOTableIF> lifs1 = new List<LOTableIF>();
            lifs1.Add(char1);
            lifs1.Add(char2);
            lifs1.Add(char3);
            lifs1.Add(char4);
            lifs1.Add(char5);

            List<LOTableIF> lifs2 = new List<LOTableIF>();
            lifs2.Add(char6);
            lifs2.Add(char7);
            lifs2.Add(char8);

            LineOfText lot1 = new LineOfText(lifs1);
            LineOfText lot2 = new LineOfText(lifs2);

            List<ColumnableIF> cifs1 = new List<ColumnableIF>();
            cifs1.Add(lot1);

            Column column1 = new Column(cifs1);

            List<ColumnableIF> cifs2 = new List<ColumnableIF>();
            cifs2.Add(lot2);

            Column column2 = new Column(cifs2);

            List<FrameableIF> fifs = new List<FrameableIF>();
            fifs.Add(column2);

            Frame frame = new Frame(fifs);

            List<PageableIF> pifs = new List<PageableIF>();
            pifs.Add(column1);
            pifs.Add(frame);

            Page page = new Page(pifs);

            List<NovelableIF> nifs = new List<NovelableIF>();
            nifs.Add(page);

            Novel novel = new Novel(nifs);


            Writer writer = new Writer(novel);

            writer.doView();

            
        }
    }
}
