using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryWall
{
    /** PeopleAC
     * Abstract class that hosts shared attributes and methods
     */
    abstract public class PeopleAC : PeopleIF
    {
        private string name; //worker's name
        private int age; //worker's age
        private string title; //worker's job title
        private double salary; //worker's salary

        /**
         * Constructor to set title and salary
         * @title - job title
         * @salary - salary
         */
        public PeopleAC(string title, double salary)
        {
            this.title = title;
            this.salary = salary;
        }
     
        /**Getter for name
         */
        public string getName()
        {
            return name;
        }
        /**Setter for name
         */
        public void setName(string name)
        {
            this.name = name;
        }

        /**Setter for age
         */
        public void setAge(int age)
        {
            this.age = age;
        }

        /**Getter for age
         */
        public int getAge()
        {
            return age;
        }

        /**Setter for title
         */
        public void setTitle(string title)
        {
            this.title = title;
        }
        
        /**Getter for title
         */
        public string getTitle()
        {
            return title;
        }

        /**Setter for salary
         */
        internal void setSalary(double salary)
        {
            this.salary = salary;
        }

        /**Getter for salary
         */
        public double getSalary()
        {
            return salary;
        }

        /**Abstract method for do work
         */
        abstract public void doWork();
    }
}
