using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryWall
{
    /**Employee
     * Super class for employees of the company
     */
    public class Employee : PeopleAC
    {
        public PeopleIF coWorker; //The coworker to be assigned

        /** Default Employee Constructor
         * @title - job title
         * @salary - salary
         */
        public Employee(string title, double salary):base(title, salary) {}

        /**Overriden method to do work
         */
        public override void doWork() { }
    }
}
