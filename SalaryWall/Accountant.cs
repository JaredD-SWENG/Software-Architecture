using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryWall
{
    /** Accountant
     * Worker that updates the salary for a assigned employee and their given assigned raise
     */
    public class Accountant : Employee, AccountantBlacksmithLink
    {
        Employee assignedEmployee; //Employee that the Accountant will update salary
        double assignedRaise; //The amount of raise that will be given the the employee Acccountant updates salary

        
        /** Default Accountant Constructor 
         * @name
         * @age
         */
        public Accountant(string name, int age):base("Accountant", 45000)
        {
            setName(name);
            setAge(age);
        }

        /** Constructor for filling in for a Blacksmith
         * @self - instance of this accountant
         * @blacksmith - blacksmith to fill in for
         */
        public Accountant(Accountant self, AccountantBlacksmithLink blacksmith):base("Accountant", self.getSalary())
        {
            setName(self.getName());
            setAge(self.getAge());
            if(self.assignedEmployee != null)
            {
                this.assignedEmployee = self.getAssignedEmployee();
                this.assignedRaise = self.getAssignedRaise();
            }
            coWorker = blacksmith;
        }

        /**Constructor for filling in for an other Accountant
         * @self - instance of this accountant
         * @accountant - accountant to fill in for
         */
        public Accountant(Accountant self, Accountant accountant):base("Accountant", self.getSalary())
        {
            setName(self.getName());
            setAge(self.getAge());
            if (self.assignedEmployee != null)
            {
                this.assignedEmployee = self.getAssignedEmployee();
                this.assignedRaise = self.getAssignedRaise();
            }
            coWorker = accountant;
        }
        
        /**Method to update salary
         */
        public void update()
        {
            if  (assignedEmployee != null)
            {
                assignedEmployee.setSalary(assignedEmployee.getSalary() + assignedRaise);
                assignedEmployee = null;
                assignedRaise = 0;
            }

            if   (coWorker != null) { coWorker.doWork(); }

        }

        /**Overriden method to do Accountant's work
         */
        public override void doWork()
        {
            update();
        }
        
        /**Method to assign the employee and the given raise
         * @employee - assigned employee
         * @raise - assigned raise
         */
        public void assignEmployeeAndRaise(Employee employee, double raise)
        {
            assignedEmployee = employee;
            assignedRaise = raise;
        }

        /**Getter for assignedEmployee
         */
        public Employee getAssignedEmployee()
        {
            return assignedEmployee;            
        }

        /**Getter for assignRaise
         */
        public double getAssignedRaise()
        {
            return assignedRaise;            
        }
        
    }
}
