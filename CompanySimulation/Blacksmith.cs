using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SalaryWall;

namespace Lab02
{
    /**
        Blacksmith
        Worker that takes a given Task object and completes it, is capable of performing the tasks of other blacksmiths.
     */
    class Blacksmith : Employee, AccountantBlacksmithLink
    {
        Task assignedTask;

        /**
         BlackSmith standard constructor
            @name - name of person
            @age -  age of person
         */
        public Blacksmith(string name, int age):base("Blacksmith", 35000)
        {
            setName(name);
            setAge(age);
        }

        /**
         BlackSmith assignment constructor
            @self - previous instance of worker.
            @coWorker - coWorker being assigned to worker.
         */
        public Blacksmith(Blacksmith self, Blacksmith coWorker) : base(self.getTitle(), self.getSalary())
        {
            setName(self.getName());
            setAge(self.getAge());
            if  (self.assignedTask != null) assignedTask = self.getTask();
            this.coWorker = coWorker;
        }
        /**
         perform
            method perform completed the assigned task given to blacksmith.
         */

        public void perform()
        {
            if   (assignedTask != null) //if blacksmith is assigned a task, complete it.
            {
                assignedTask.complete();
                assignedTask = null;
            }
            if(coWorker!= null) //if blacksmith is assigned a coWorker to fill in for, complete their task.
            {
                coWorker.doWork();
            }
        }

        /**
         assignTask
            method call to assign blacksmith a given task.
            @task - Task object for blacksmith to complete
         */
        public void assignTask(Task task)
        {
            assignedTask = task;
        }


        /**
         getTask
            return - returns assigned task of blacksmith.
         */
        public Task getTask()
        {
            return assignedTask;            
        }

        
        /**
         doWork
            method calls given classes unique method, for Blacksmioth that method is perform.
         */
        public override void doWork()
        {
            perform();
        }
                
    }
}
