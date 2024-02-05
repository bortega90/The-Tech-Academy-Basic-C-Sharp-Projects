using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LambdaSubmission
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            //list of names
            List<string> FirstName = new List<string>() 
            { 
                "Joe", 
                "Maggy", 
                "Rafael", 
                "Britny",
                "Sally",
                "Bad",
                "Joe",
                "Ollie",
                "Nathan",
                "Tims"
            };

            List<string> LastName = new List<string>()
            {
                "Smith",
                "Lee",
                "Guevara",
                "Ortega",
                "Field",
                "Bunny",
                "Bob",
                "Girl",
                "Stanley",
                "Jacobs"
            };

            List<int> Id = new List<int>()
            {
                1,
                2,
                3,
                4,
                5,
                6,
                7,
                8,
                9,
                10
            };

            //foreach loop
            string fname = "Joe";
            //Employee employee = new Employee();
            foreach (Employee employee in FirstName)
            {
                if (employee.FirstName == fname)
                {
                    Console.WriteLine(fname);
                }
            }
            

            //lambda
            List<FirstName> joeList = employee.FirstName.Where( x => x.FirstName == fname).ToList();
            foreach (Employee employee in joeList) { Console.WriteLine(employee.FirstName); }
        }
    }
}
