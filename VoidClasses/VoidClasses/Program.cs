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
            //class and instantiate Class1
            Class1 class1 = new Class1();
            //ask user to input an integer
            Console.WriteLine("Please input a number");
            int input = Convert.ToInt32(Console.ReadLine());
            //ask user to type a string
            Console.WriteLine("Press enter");
            string b = Console.ReadLine();

            //calling overload Method() from class1 instantiated from Class1
            class1.Method(input);
            //calling Method() from Class2 since Class2 can't be instantiated from static class
            Class2.Method(out b);
            

            Console.ReadLine();
        }
        
    }
}