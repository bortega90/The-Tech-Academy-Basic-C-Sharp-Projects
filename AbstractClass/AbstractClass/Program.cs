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
            //instantiating Class and Interface 
            Employee employee = new Employee();
            IQuittable employee2 = new Employee();
            //inputting names for employee
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            //calling method 
            employee.SayName();
            employee2.Quit();
            Console.ReadLine();

        }
    }
}
