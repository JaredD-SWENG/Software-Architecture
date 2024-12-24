using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    /*
     Task
        Task for Blacksmith to store, and complete.
     */
    public class Task
    {
        private string id;
        private string dueDate;
        private string description;

        /*
         Task standard constructor
            @id - ID of task
            @dueDate - Due date of task
            @description - brief description of task to complete.
         */
        public Task (string id, string dueDate, string description)
        {
            this.id = id;
            this.dueDate = dueDate;
            this.description = description;
        }

        /*
         complete
            method call to give visual feedback when task has been completed.
         */
        public void complete ()
        {
            Console.WriteLine("Task " + id + " has been completed");
        }
    }
}
