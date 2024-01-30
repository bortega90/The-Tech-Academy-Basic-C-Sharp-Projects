using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> numbers = new List<int> { 5, 10, 15, 20, 25 };
                Console.WriteLine("Pick a number.");
                int userNumber = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < numbers.Count; i++)
                {
                    Console.WriteLine("Dividing the pick picked number to the numbers in the list");
                    int divideBy = numbers[i] / userNumber;
                    Console.WriteLine(numbers[i] + " divide by " + userNumber + " equals " + divideBy);
                    Console.ReadLine();
                }
                Console.ReadLine();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please type a number");
                Console.ReadLine();
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Cannot divide by zero.");
                Console.ReadLine();
            }
            
        }
    }
}
