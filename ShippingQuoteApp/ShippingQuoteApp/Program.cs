using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingQuoteApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express");
            //input weight of package
            Console.WriteLine("What is the weight of your package?");
            int weight = Convert.ToInt32(Console.ReadLine());
            //package wight limit is 50
            if (weight > 50)
            {
                Console.WriteLine("Package is too heavy to ship via Package Express. Have a good day.");
            }
            else if (weight <= 50)
            {
                Console.WriteLine("We can help");
                //input package dimensions
                Console.WriteLine("What is your package width?");
                int width = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is your package height?");
                int height = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is your package length?");
                int length = Convert.ToInt32(Console.ReadLine());
                int dimensions = width + height + length;
                //package dimensions limit is 50
                if (dimensions > 50)
                {
                    Console.WriteLine("Your package is too big, sorry");
                }
                else
                {
                    if (dimensions <= 50)
                    {
                        Console.WriteLine("Your quote is on the way");
                           //calculating quote
                        decimal quote = (width * height * length * weight) / 100.00m;
                        Console.WriteLine("Your quote is " + quote);
                    }
                }
                Console.ReadLine();


            }
        }
    }
}
