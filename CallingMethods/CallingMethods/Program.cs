using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
         //class,instance to call method
            Math obj = new Math();
            //asking user to input number
            Console.WriteLine("\nPlease pick a number:\t");
            //saving input as userInput
            int userInput = Convert.ToInt32(Console.ReadLine());
            //calling addition method with instance and adding userInput
            Console.WriteLine(obj.Addition(userInput));
            //calling subtraction method ''  ''
            Console.WriteLine(obj.Subtraction(userInput));
            //calling multiplication method '' ''
            Console.WriteLine(obj.Multiplication(userInput));
            Console.ReadLine();
        }
        
    }
}
