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

            //list of first names, last names and id
            List<Employee> employees = new List<Employee>()
            {
                new Employee() {Id =1, FirstName = "Joe", LastName= "Smith"},
                new Employee() { Id = 2, FirstName = "Rafael", LastName = "Guevara" },
                new Employee() { Id = 3, FirstName = "Britny", LastName = "Ortega"},
                new Employee() {Id = 4, FirstName = "Ollie", LastName = "Ortega"},
                new Employee() { Id = 5, FirstName = "Gemini", LastName = "Ryan"},
                new Employee() { Id = 6, FirstName = "Peter", LastName = "Ryand" },
                new Employee() { Id = 7, FirstName = "Joe", LastName = "Reily"},
                new Employee() { Id = 8, FirstName = "Robert", LastName = "Jones"},
                new Employee() { Id = 9, FirstName = "Oberto", LastName = "Vialta"}
            };

            //foreach loop
            string fname = "Joe";
            int count = 0;
            foreach (Employee employee in employees)
            {
                if (employee.FirstName == fname)
                {
                    count++;
                    Console.WriteLine(employee.Id);
                    Console.ReadLine();
                }
                

               
            }


            //lambda
            List<Employee> joeList = employees.Where(x => x.FirstName == fname).ToList();
            foreach (Employee employee in joeList)
            { Console.WriteLine(employee.FirstName); }
            Console.ReadLine();
        }
    }
}
