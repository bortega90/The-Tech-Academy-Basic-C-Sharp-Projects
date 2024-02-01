using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Objects
{
    public class Person
    {
        //setting two properites to Person class
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //Adding method that will display first and last name
        public void SayName() { Console.WriteLine("Name: " + FirstName + " " +  LastName); }
    }
}
