using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07
{
    /// <summary>
    /// Character object contains a char object used to store text.
    /// Character can be contained directly by Column, and LineOfText objects.
    /// </summary>
    class Character : LOTableIF
    {
        private char character;
        
        public Character(char c)
        {
            character = c;
        }
        public void delete()
        {
            character = ' ';
        }

        public void edit()
        {
            Console.Write("Please insert new char: ");
            character = Convert.ToChar(Console.ReadLine());
        }

        public void retrieve()
        {
            Console.Write(character);
        }

        public void save()
        {
            Console.WriteLine(character + " saved.");
        }

        public void view()
        {
            Console.Write(character);
        }
    }
}
