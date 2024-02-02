using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OperatorAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //class and instantiating
            Employee employee = new Employee();
            Employee employee2 = new Employee();

            employee.FirstName = "Britny";
            employee.LastName = "Ortega";
         
            employee2.FirstName = "Sandra";
            employee2.LastName = "Bullock";

            
        }
    }
}
