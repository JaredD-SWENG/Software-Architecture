using System;
using System.Collections.Generic;
using SalaryWall;

namespace Lab02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employees are generated and added to company XYZ.
            Company XYZ = new Company();
            Owner Craig = new Owner("Craig", 45);
            XYZ.addStaff(Craig);
            Manager John = new Manager("John", 35);
            XYZ.addStaff(John);
            Manager Mary = new Manager("Mary", 35);
            XYZ.addStaff(Mary);
            Accountant Joe = new Accountant("Joe", 33);
            XYZ.addStaff(Joe);
            Accountant Jane = new Accountant("Jane", 25);
            XYZ.addStaff(Jane);
            Blacksmith Jack = new Blacksmith("Jack", 60);
            XYZ.addStaff(Jack);
            Blacksmith Lin = new Blacksmith("Lin", 52);
            XYZ.addStaff(Lin);
            Blacksmith Katie = new Blacksmith("Katie", 40);
            XYZ.addStaff(Katie);
            Blacksmith Amy = new Blacksmith("Amy", 47);
            XYZ.addStaff(Amy);
            Blacksmith Greg = new Blacksmith("Greg", 22);
            XYZ.addStaff(Greg);


            //Craig sends message Good Job to Employees John, Jane, and Jack.
            string message = "Good Job!";
            List<Employee> list = new List<Employee>();
            list.Add(John);
            list.Add(Jane);
            list.Add(Jack);
            Craig.assignSend(message, list);
            Craig.send();

            //Greg is assigned Task t1, Amy is assigned Task t2. Greg fills in for Amy ans completes both Tasks t1 and t2.
            Task t1 = new Task("T1", "1/22/2032", "Weld the joint");
            Task t2 = new Task("T2", "1/23/2023", "Mop the floor");
            Greg.assignTask(t1);
            Amy.assignTask(t2);
            Greg = new Blacksmith(Greg, Amy);
            Greg.perform();

            //Jane gives Greg a raise of 1000, and assists Lin with her task.
            Jane.assignEmployeeAndRaise(Greg, 1000);
            Jane = new Accountant(Jane, Lin);
            Jane.update();

            //John is assigned Jack to evaluate, Mary is assigned Katie to evaluate, John cannot evaluate so Mary fills in for John and performs both evaluations.
            John.assignEmployeeAndScore(Jack, 4);
            Mary.assignEmployeeAndScore(Katie, 5);
            Mary = new Manager(Mary, John);
            Mary.evaluate();

            //END OF PROGRAM
        }
    }
}
