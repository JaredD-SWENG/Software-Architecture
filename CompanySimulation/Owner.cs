using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SalaryWall;

namespace Lab02
{
    /**
     Owner
        Owner of company XYZ, is capable of sending messages to any other employee of the company.
     */
    class Owner: PeopleAC
    {

        string messageToEmployees;
        List<Employee> employeeList;
        
        /**
         Owner standard constructor
            @name - name of Owner
            @age - age of owner
         */
        public Owner(string name, int age):base("Owner", 100000)
        {
            setName(name);
            setAge(age);
        }

        /**
        assignSend
            initialize message to send, and list of employees to message for the send method.
            @message - message to send
            @employeeList - list of employees to message
        */
        public void assignSend(string message, List<Employee> employeeList)
        {
            messageToEmployees = message;
            this.employeeList = employeeList;
        }

        /*
         send
            Owners unique method, sends a provided message to a list of employees
         */
        public void send()
        {
            if(employeeList.Count() != 0) //If list contains people to message, send message to them.
            {
                foreach(Employee a in employeeList)
                {
                    Console.WriteLine("Message: \"" + messageToEmployees + "\" sent to " + a.getName());
                    
                }
                employeeList.Clear();
                messageToEmployees = "";
            }
        }
        
        /*
         doWork
            method call used by Manager class to access send method whem Manager is filling in for Owner.
         */
        public override void doWork()
        {
            send();
        }
    }
}
