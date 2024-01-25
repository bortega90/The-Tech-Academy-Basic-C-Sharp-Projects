using System;


namespace IncomeComparisonProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("Person 1");
            // input hrly rate
            Console.WriteLine("Hourly Rate: ");
            int hourlyRate = Convert.ToInt32(Console.ReadLine());
            // input hrs/wk
            Console.WriteLine("Hours worked per week: ");
            int weeklyHrs = Convert.ToInt32(Console.ReadLine());
            // calculating yrly earnings
            int P1salary = hourlyRate * weeklyHrs * 52;
            Console.WriteLine("Annual Salary of Person 1: " + P1salary);
            Console.ReadLine();

            Console.WriteLine("Person 2");
            // input hrly rate
            Console.WriteLine("Hourly Rate: ");
            int hourlyRate2 = Convert.ToInt32(Console.ReadLine());
            // input hrs/wk
            Console.WriteLine("Hours worked per week: ");
            int weeklyHrs2 = Convert.ToInt32(Console.ReadLine());
            // calculating yrly earnings
            int P2salary = hourlyRate2 * weeklyHrs2 * 52;
            Console.WriteLine("Annual Salary of Person 2: " + P2salary);
            Console.ReadLine();

            // comparing Person 1's and Person 2's salary
            bool greater = P1salary > P2salary;
            Console.WriteLine("Person 1's salary greater? " + greater);
            Console.ReadLine();

        }
    }
}
