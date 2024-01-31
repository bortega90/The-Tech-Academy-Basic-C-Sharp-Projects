using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //class and instantiate to methods in class
            MethodTypes obj = new MethodTypes();
            int number = Convert.ToInt32(6);
            //calling addition method with instance and variable number
            Console.WriteLine(obj.Methods(number));
            Console.ReadLine();

            //class and instantiate the second method in class
            MethodTypes obj2 = new MethodTypes();
            decimal number2 = Convert.ToDecimal(3.75);
            //calling division method with instance and variable number2
            Console.WriteLine(obj2.Methods(number2));
            Console.ReadLine();

            //class and instantiate the third method in class
            MethodTypes obj3 = new MethodTypes();
            string word = "Britny";
            //Calling string method with instance and variable word
            Console.WriteLine(obj3.Methods(word));
            Console.ReadLine();

        }
        
    }
    

}
