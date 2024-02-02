using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            //instantiating Employee object 
            Employee employee = new Employee();
            //inputting names for employee
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            //calling method 
            employee.SayName();
            //Quit() Method inherited by interface
            employee.Quit();
            Console.ReadLine();

        }
    }
}
