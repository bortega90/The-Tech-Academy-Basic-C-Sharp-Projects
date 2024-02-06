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
            
            Console.WriteLine("Today's time is {0}", DateTime.Now);
            Console.WriteLine("Please type an integer.");
            int answer = Convert.ToInt32(Console.ReadLine());
            DateTime newTime = DateTime.Now.AddHours(answer);
            Console.WriteLine("The time in {0} hours will be {1}", answer, newTime);
            Console.ReadLine();
        }
    }
}

