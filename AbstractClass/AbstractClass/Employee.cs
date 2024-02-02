using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    //employee class inherits from person to use SayName method
    public class Employee : Person
    {
        public override void SayName() 
        {
            Console.WriteLine("Employee Name: " + FirstName + " " + LastName);
        }
    }
}
