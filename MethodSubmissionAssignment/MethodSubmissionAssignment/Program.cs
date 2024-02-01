using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmissionAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //class and instantiate to methods in class 
            Paramaters obj = new Paramaters();
            //ask user to input two numbers, the second one is optional
            Console.WriteLine("Input two numbers.");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second number is optional");
            string num2 = Console.ReadLine();
            if (num2 == "")
            {
                //calling method with instance and one variable
                Console.WriteLine(obj.Parameters(num1));
            }
            else
            {
                int num3 = Convert.ToInt32(num2);
                 
                //calling method with instance and two variables
                Console.WriteLine(obj.Parameters(num1, num3));
            }
            
            Console.ReadLine();
        }
    }
}
