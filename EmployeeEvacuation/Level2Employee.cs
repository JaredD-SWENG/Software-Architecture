using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    /// <summary>
    /// Level2Employee
    /// A subclass of Employee, superclass class for all Level 2 roles (which are head persons for Level 3 roles)
    /// </summary>
    class Level2Employee : Employee, Level2IF, Level3HeadPersonIF
    {
        private List<Level3IF> subordinates;
        private Level2HeadPersonIF l2if;

        public Level2Employee(string name):base(name)
        {
            subordinates = new List<Level3IF>();
        }

        public void setL3Subordinate(Level3IF l3if)
        {
            l3if.setHeadPerson(this);
            subordinates.Add(l3if);
        }

        public Level2HeadPersonIF getLevel2HeadPersonIF()
        {
            return l2if;
        }

        public void setHeadPerson(Level2HeadPersonIF l2if)
        {
            this.l2if = l2if;
        }

        public void contactBoss()
        {
            Console.WriteLine("Contacting CEO...");
            l2if.seeDanger();
        }

        public Decision selectedDecision()
        {
            string dec = getName() + "'s decision";
            return new Decision(dec);
        }

        public void seeDanger()
        {
            Console.WriteLine(getName() + " has been alerted of the danger, they will now source info from all project leaders and supervisors...");
            
            foreach(Level3IF l3if in subordinates)
            {
                if(l3if is Level3Employee)
                {
                    Console.WriteLine(((Level3Employee)l3if).provideInfo());
                }
            }

            contactBoss();
        }

        public List<Level1IF> getSubordinates()
        {
            List<Level1IF> l1ifs = new List<Level1IF>();
            foreach (Level3IF l3 in subordinates)
            {
                l1ifs.Add((Level1IF)l3);
            }
            return l1ifs;
        }

        public void evacuate()
        {
            Console.WriteLine("Level2 Employee " + getName() + " has evacuated...");
        }
    }
}
