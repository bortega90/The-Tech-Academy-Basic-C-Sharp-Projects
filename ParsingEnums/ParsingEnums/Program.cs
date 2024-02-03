using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //ask user to enter current day
                Console.WriteLine("What day is today?");
                //dayofweektype is data type
                DayOfWeekType input = (DayOfWeekType) Enum.Parse(typeof(DayOfWeekType),Console.ReadLine());
                Console.WriteLine(input);
            }
            catch(FormatException)
            {
                Console.WriteLine("Please type day of the week.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error");
            }
            
            Console.ReadLine();
        }
    }
}
