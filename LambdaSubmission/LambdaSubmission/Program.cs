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
                new Employee() { Id = 6, FirstName = "Peter", LastName = "Ryan" },
                new Employee() { Id = 7, FirstName = "Joe", LastName = "Reily"},
                new Employee() { Id = 8, FirstName = "Robert", LastName = "Jones"},
                new Employee() { Id = 9, FirstName = "Oberto", LastName = "Vialta"},
                new Employee() { Id = 10, FirstName = "Rodrigo", LastName = "Gonzalez"}
            };

            //foreach loop
            string fname = "Joe";
            List<Employee> joesList1 = new List<Employee>();
            
            foreach (Employee employee in employees)
            {
                if (employee.FirstName == fname)
                {
                    joesList1.Add(employee);
                    Console.WriteLine(employee.FirstName + " " + employee.LastName + " " + employee.Id);
                    Console.ReadLine();
                }
            }


            //lambda
            List<Employee> joeList = employees.Where(x => x.FirstName == fname).ToList();
            foreach (Employee employee in joeList)
            { 
                Console.WriteLine(employee.FirstName+" "+employee.LastName+" "+employee.Id); 
            }
            Console.ReadLine();

            //lambda expressions for employee.ID > 5
            List<Employee> IdList = employees.Where(x => x.Id >= 5).ToList();
            foreach (Employee employee1 in IdList)
            {
                Console.WriteLine(employee1.Id+" "+employee1.FirstName+" "+employee1.LastName);
            }
            Console.ReadLine();
        }
    }
}
