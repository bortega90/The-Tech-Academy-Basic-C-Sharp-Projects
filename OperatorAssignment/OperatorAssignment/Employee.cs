using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorAssignment
{
    public class Employee
    {
        //properties for Employee class
        public string Id {  get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public static Employee operator == (Employee employee, Employee FirstName)
        {
            if (employee.Equals(FirstName))
            {
                return true;
            }
            else
                return false;
        }
        public static Employee operator == (Employee employee, Employee LastName)
        {
            if (employee.Equals(LastName))
            {
                return true;
            }
            else
                return false;
        }
    }
}
