using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsurance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // pt 1

            // ask age
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();
            // ask about dui
            Console.WriteLine("Have you ever had a DUI? Answer true or false");
            bool dui = Convert.ToBoolean(Console.ReadLine());
            // as about speeding tickets
            Console.WriteLine("How many speeding tickets do you have? ");
            int tickets= Convert.ToInt32(Console.ReadLine());


            // pt 2

            // check to see if qualified 
            bool qualified = age > 15 && dui != true && tickets < 3;
            Console.WriteLine("Qualified? " + qualified);
            Console.ReadLine();

            



        }
    }
}
