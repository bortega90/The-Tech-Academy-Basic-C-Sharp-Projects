using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidClasses
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            //class and instantiate
            Class1 class1 = new Class1();
            Class2 class2 = new Class2();
            //ask user to input an integer
            Console.WriteLine("Please input a number");
            int input = Convert.ToInt32(Console.ReadLine());
            //ask user to type a string
            Console.WriteLine("Please type a word");
            string word = Console.ReadLine();

            //calling overload Method() from both classes
            class1.Method(input);
            class2.Method(b:out word) ;
            
            Console.ReadLine();
        }
    }
}