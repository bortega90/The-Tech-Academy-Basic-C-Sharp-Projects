using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            //instantiating Employee object with Student FirstName
            employee.FirstName = "Sample";
            //instantiating Employee object with Student LastName
            employee.LastName = "Student";
            //using SayName function from Person, which is the superclass, since Employee class inheirited Person's properties
            employee.SayName() ;
            //display on console
            Console.ReadLine();
        }
    }
}
