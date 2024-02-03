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
        public int Id {  get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public static bool operator == (Employee employee, Employee employee2)
        {
            return employee.Id == employee2.Id;
        }
        public static bool operator != (Employee employee, Employee employee2)
        {
            return employee.Id != employee2.Id;
        }
    }
}
