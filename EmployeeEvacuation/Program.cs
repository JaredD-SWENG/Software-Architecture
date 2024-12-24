using System;
using System.Collections.Generic;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            CEO ceo = new CEO("Steve");
            Manager m1 = new Manager("Bob");
            Manager m2 = new Manager("Rachael");
            ProjectLeader pl1 = new ProjectLeader("Chuck");
            ProjectLeader pl2 = new ProjectLeader("Denise");
            Supervisor s1 = new Supervisor("Jack");
            Supervisor s2 = new Supervisor("Jeff");

            //Jack leads
            Worker w1 = new Worker("John");
            Worker w2 = new Worker("Mary");
            Worker w3 = new Worker("Jane");
            Worker w4 = new Worker("Tom");
            Worker w5 = new Worker("Nick");
            s1.setL4Subordinate(w1);
            s1.setL4Subordinate(w2);
            s1.setL4Subordinate(w3);
            s1.setL4Subordinate(w4);
            s1.setL4Subordinate(w5);
            

            //Jeff supervises
            Worker w6 = new Worker("Rob");
            Worker w7 = new Worker("Ed");
            Worker w8 = new Worker("Rick");
            Worker w9 = new Worker("Michael");
            s2.setL4Subordinate(w6);
            s2.setL4Subordinate(w7);
            s2.setL4Subordinate(w8);
            s2.setL4Subordinate(w9);
            

            //Chuck leads
            Worker w10 = new Worker("Joe");
            Worker w11 = new Worker("Frank");
            Worker w12 = new Worker("Sam");
            Worker w13 = new Worker("Greg");
            pl1.setL4Subordinate(w10);
            pl1.setL4Subordinate(w11);
            pl1.setL4Subordinate(w12);
            pl1.setL4Subordinate(w13);
            

            //Denise leads
            Worker w14 = new Worker("Amy");
            Worker w15 = new Worker("Wil");
            Worker w16 = new Worker("Nancy");
            Worker w17 = new Worker("Adam");
            pl2.setL4Subordinate(w14);
            pl2.setL4Subordinate(w15);
            pl2.setL4Subordinate(w16);
            pl2.setL4Subordinate(w17);
            
            //Bob manages Jack and Jeff
            m1.setL3Subordinate(s1);
            m1.setL3Subordinate(s2);
            //Rachel manages Chuck and Denise
            m2.setL3Subordinate(pl1);
            m2.setL3Subordinate(pl2);
            

            ceo.setL2Subordinate(m1);
            ceo.setL2Subordinate(m2);
           
            //John sees danger
            w1.seeDanger();

            List<Level1IF> repairCrew = s2.getSubordinates();
            foreach(Level1IF l1if in repairCrew)
            {
                if(((Level4Employee)l1if).getName().Equals("Rick") || ((Level4Employee)l1if).getName().Equals("Rob"))
                {
                    ((Level4Employee)l1if).fixIt();
                }
            }
        }
    }
}
