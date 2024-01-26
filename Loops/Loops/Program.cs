using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess my favorite number!");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 7;
            //while loop flawed if you guessed correctly the first time so put cases inside do{} and place the while () at the end
            do
            {
                //some guesses with outputs
                switch (number)
                {
                    case 62:
                        Console.WriteLine("You guessed 62. Try again");
                        Console.WriteLine("Guess again?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 29:
                        Console.WriteLine("You guessed 29. That is not correct");
                        Console.WriteLine("Guess again?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 55:
                        Console.WriteLine("You guessed 55. Try again");
                        Console.WriteLine("Guess again?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                        //correct guess gets a correct statement and will stop the program letting you guess again
                    case 7:
                        Console.WriteLine("You guessed 7. That is correct!");
                        isGuessed = true;
                        break;
                        //default output when wrong
                    default:
                        Console.WriteLine("You are wrong.");
                        Console.WriteLine("Guess again?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            //will loop thru all the cases until the right one is picked
            while (!isGuessed); 
            Console.ReadLine();
        }
    }
}
