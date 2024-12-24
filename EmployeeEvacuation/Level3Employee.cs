using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    /// <summary>
    /// Level3Employee
    /// A subclass of Employee, superclass class for all Level 3 roles (which are head persons for Level 4 roles)
    /// </summary>
    class Level3Employee : Employee, Level3IF, Level4HeadPersonIF
    {
        private List<Level4IF> subordinates;
        private Level3HeadPersonIF l3if;

        public Level3Employee(string name):base(name)
        {
            subordinates = new List<Level4IF>();
        }

        public void setL4Subordinate(Level4IF l4if)
        {
            l4if.setHeadPerson(this);
            subordinates.Add(l4if);
        }

        public Level3HeadPersonIF getLevel3HeadPersonIF()
        {
            return l3if;
        }

        public void setHeadPerson(Level2HeadPersonIF l2if)
        {
            this.l3if = (Level3HeadPersonIF)l2if;
        }

        public string provideInfo()
        {
            return getName() + " is providing info...";
        }

        public void seeDanger()
        {
            Console.WriteLine(getName() + "is now notifying all subordinates of the danger, and reporting to their head person...");
            l3if.seeDanger();
        }

        public List<Level1IF> getSubordinates()
        {
            List<Level1IF> l1ifs = new List<Level1IF>();
            foreach (Level4IF l4 in subordinates)
            {
                l1ifs.Add((Level1IF)l4);
            }
            return l1ifs;
        }

        public void evacuate()
        {
            Console.WriteLine("Level3 Employee " + getName() + " has evacuated...");
        }
    }
}
