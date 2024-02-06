using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //displaying time in console
            Console.WriteLine("Today's time is {0}", DateTime.Now);
            //aksing user for an integer
            Console.WriteLine("Please type an integer.");
            //saving user's input as variable answer
            int answer = Convert.ToInt32(Console.ReadLine());
            //calculating new time in hours with user's integer
            DateTime newTime = DateTime.Now.AddHours(answer);
            //displaying time in x hrs ahead
            Console.WriteLine("The time in {0} hours will be {1}", answer, newTime);
            Console.ReadLine();
        }
    }
}

