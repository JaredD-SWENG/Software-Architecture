using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalaryWall;

namespace Lab02
{
    /**
     Manager
        Employee of company that is capable of completing taks for the Owner, fellow Manager, and Blacksmith objects.
     */
    class Manager : Employee
    {
        Employee assignedEmployee;
        int assignedLinkertScale;

        /**
         Manager standard constructor
            @name - name of employee
            @age - age of employee
         */
        public Manager(String name, int age):base("Manager", 50000)
        {
            setName(name);
            setAge(age);
        }

        /**
         Manager assignment constructor
            Constructs manager and assigns them a coWorker to complete tasks for.
            @self - previous instance of Manager to preserve.
            @coWorker - coWorker that Manager must fill in for.
         */
        public Manager(Manager self, Manager coWorker) : base("Manager", self.getSalary())
        {
            setName(self.getName());
            setAge(self.getAge());
            if(self.assignedEmployee != null)
            {
                this.assignedEmployee = self.getAssignedEmployee();
                this.assignedLinkertScale = self.getAssignedLinkertScale();
            }
            this.coWorker = coWorker;
        }

        /**
         Manager assignment constructor
            Constructs manager and assigns them a coWorker to complete tasks for.
            @self - previous instance of Manager to preserve.
            @coWorker - coWorker that Manager must fill in for.
         */
        public Manager(Manager self, Blacksmith coWorker) : base("Manager", self.getSalary())
        {
            setName(self.getName());
            setAge(self.getAge());
            if (self.assignedEmployee != null)
            {
                this.assignedEmployee = self.getAssignedEmployee();
                this.assignedLinkertScale = self.getAssignedLinkertScale();
            }
            this.coWorker = coWorker;
        }


        /**
         Manager assignment constructor
            Constructs manager and assigns them a coWorker to complete tasks for.
            @self - previous instance of Manager to preserve.
            @owner - coWorker that Manager must fill in for.
         */
        public Manager(Manager self, Owner owner) : base("Manager", self.getSalary())
        {
            setName(self.getName());
            setAge(self.getAge());
            if (self.assignedEmployee != null)
            {
                this.assignedEmployee = self.getAssignedEmployee();
                this.assignedLinkertScale = self.getAssignedLinkertScale();
            }
            this.coWorker = owner;
        }

        /**
         assignEmployeeAndScore
            method call to initialize data needed to perform evaluate method.
            @employee - employee to evaluate
            @linkertScale - score to provide employee
         */
        public void assignEmployeeAndScore(Employee employee, int linkertScale)
        {
            assignedEmployee = employee;
            assignedLinkertScale = linkertScale;
        }

        
        /**
         evaluate
            unique method to Manager, provides an evaluation to given employee by providing them a score.
            
         */
        public void evaluate()
        {
            if(assignedEmployee != null) //If assigned an employee to evaluate, send message to confirm evaluation.
            {
                Console.WriteLine("Employee " + assignedEmployee.getName() + " was given a score of " + assignedLinkertScale);
                assignedEmployee = null;
            }
            if(coWorker != null)//if assigned coworker to fill in for, do their task.
            {
                coWorker.doWork();
            }

        }

        /**
         doWork
            method call used by fellow Employee objects to call Manager objects unique evaluate method.
         */
        public override void doWork()
        {
            evaluate();
        }

        /**
         getAssignedEmployee
            returns the currently assigned employee of Manager.
         */
        public Employee getAssignedEmployee()
        {
            return assignedEmployee;            
        }

        /**
         getAssignedLinkertScale
            returns the currently assigned linkers scale of Manager.
         */
        public int getAssignedLinkertScale()
        {
            return assignedLinkertScale;
        }

    }
}
