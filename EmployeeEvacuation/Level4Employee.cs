using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    /// <summary>
    /// Level4Employee
    /// A subclass of Employee, superclass class for all Level 4 roles
    /// </summary>
    class Level4Employee : Employee, Level4IF
    {
        private Level4HeadPersonIF l4if;

        public Level4Employee(string name):base(name)
        {
           
        }

        public Level4HeadPersonIF getLevel4HeadPersonIF()
        {
            return l4if;
        }
        public void setHeadPerson(Level2HeadPersonIF l2if)
        {
            this.l4if = (Level4HeadPersonIF)l2if;
        }

        public void fixIt()
        {
            Console.WriteLine(getName() + " is fixing it.");
        }

        public void seeDanger()
        {
            Console.WriteLine(getName() + " has spotted a danger, reporting to head person...");
            l4if.seeDanger();
        }

        public List<Level1IF> getSubordinates()
        {
            return null; //Level 4 employees do not have subordinates.
        }

        public void evacuate()
        {
            Console.WriteLine("Level4 Employee " + getName() + " has evacuated...");
        }
    }
}

