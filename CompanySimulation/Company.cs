using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalaryWall;

namespace Lab02
{
    /**
     Company
        Object instance of the Company, stores the name of the company and a list of all employees.
     */
    class Company
    {
        private String name;
        private List<PeopleIF> staff;


        /**
         Standard constructor
         */
        public Company()
        {
            name = "XYZ";
            staff = new List<PeopleIF>();
            
        }

        /**
         addStaff
            adds a given person as staff.
         */
        public void addStaff(PeopleIF staff)
        {
            staff.Add(staff);
        }

        /**
         removeStaff
            removes the given person from the staff list.
         */
        public void removeStaff(PeopleIF staff)
        {
            staff.Remove(staff);
        }
    }
}
