using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    /// <summary>
    /// Level1Employee
    /// A subclass of Employee, superclass class for all Level 1 roles (which are head persons for Level 2 roles)
    /// </summary>
    class Level1Employee : Employee, Level1IF, Level2HeadPersonIF
    {
        private List<Level2IF> subordinates;

        public Level1Employee(string name):base(name)
        {
            subordinates = new List<Level2IF>();
        }

        public void setL2Subordinate(Level2IF l2if)
        {
            l2if.setHeadPerson(this);
            subordinates.Add(l2if); 
        }

        public void setHeadPerson(Level2HeadPersonIF l2hp)
        {
            return;
        }

        public void seeDanger()
        {
            Console.WriteLine(getName() + " has been notified of the danger, they will now gather decisions...");
            List<Decision> decisions = new List<Decision>();
            foreach(Level2IF l2 in subordinates)
            {
                if(l2 is Level2Employee)
                {
                    decisions.Add(((Level2Employee)l2).selectedDecision());
                }
            }
            Console.WriteLine("Decisions gathered CEO will now grant a decision...");
            Decision grantedDecision = grant(decisions.ToArray());
            grantedDecision.doIt();
            Console.WriteLine("Evacuation protocol proceeding...");
            evacuate();
        }

        public Decision grant(Decision[] da)
        {
            int max = da.Length;
            Random rand = new Random();
            int choice = rand.Next(0, max);
            return da[choice];
        }

        public void evacuate()
        {
            //Use BFS to generate a List of Level1IFs
            //for each Level1IF call evacuate
            //print out evac message for CEO
            Queue<Level1IF> evacQueue = new Queue<Level1IF>();
            Stack<Level1IF> evacStack = new Stack<Level1IF>();

            List<Level1IF> evacList = getSubordinates();

            foreach (Level1IF l1 in evacList)
            {
                evacQueue.Enqueue(l1);
            }

            while (evacQueue.Count != 0)
            {
                evacList = evacQueue.ElementAt(0).getSubordinates();
                if  (evacList != null)
                
                {
                    foreach  (Level1IF l1 in evacList)
                        {
                            evacQueue.Enqueue(l1);
                        }
                
                }
                evacStack.Push(evacQueue.Dequeue());
            }

            while (evacStack.Count != 0)
            {
                evacStack.Pop().evacuate();
            }
            Console.WriteLine("CEO " + getName() + " evacuated.");

        }

        public List<Level1IF> getSubordinates()
        {
            List<Level1IF> l1ifs = new List<Level1IF>();
            foreach(Level2IF l2 in subordinates)
            {
                l1ifs.Add((Level1IF)l2);
            }
            return l1ifs;
        }
    }
}
