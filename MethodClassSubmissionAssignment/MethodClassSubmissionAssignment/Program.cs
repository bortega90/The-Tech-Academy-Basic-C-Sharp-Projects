using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassSubmissionAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //class and instantiate 
            Parameters obj = new Parameters();

            //pass two numbers
            int num1 = Convert.ToInt32(5); 
            int num2 = Convert.ToInt32(6);
         
            //calling method() for passing numbers
            Console.WriteLine(obj.Parameter(5,6));
            //calling method() by parameter name
            Console.WriteLine(obj.Parameter(num1,num2));
            Console.ReadLine();
            

        }
    }
}
