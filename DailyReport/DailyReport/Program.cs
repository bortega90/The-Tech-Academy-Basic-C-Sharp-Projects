using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Title of the program
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            // asking your name and letting you put name in
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            // asking what course you're on and letting you type course
            Console.WriteLine("What course are you on?");
            string yourCourse = Console.ReadLine();
            // asking what page on the course and letting type the page number
            Console.WriteLine("What page number?");
            string yourPage = Console.ReadLine();
            // asking if you need help and letting you answer with True or False
            Console.WriteLine("Do you need help on anything? Answer 'true' or 'false'.");
            bool needHelp = false;
            Console.ReadLine();
            //Asking about experiences
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics");
            string yourResponse = Console.ReadLine();   
            // asking for feedback
            Console.WriteLine("Is there any feedback you'd like to provide? Please be specific.");
            string yourExperience = Console.ReadLine();
            // asking how many hours you studied
            Console.WriteLine("How many hours did you study today?");
            string studyHours = Console.ReadLine();
            // endy the program 
            Console.WriteLine("Thank you for all your answers. An Instructor will respond to this shortly. Have a great Day!");
            Console.ReadLine();



        }
    }
}
