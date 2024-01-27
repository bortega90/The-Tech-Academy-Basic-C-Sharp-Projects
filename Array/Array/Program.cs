using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string array
            string[] Array1 = { "Hi", "Hello", "Welcome", "Bye" };
            // ask user to pick a number between 0-3 since there's 4 words
            Console.WriteLine("Please pick a number between 0-3");
            // convert users answer to integer and saving in variable
            int answer = Convert.ToInt32(Console.ReadLine());
            // check to see if number is in range
            if (answer > 3)
            {
                Console.WriteLine("Number is out of range.");
            }
            else
                if (answer <= 3)
            {
                // integer picked corresponds to words in the array
                Console.WriteLine(Array1[answer]);
            }
            // will read out the word 
            Console.ReadLine();

            // integer array
            int[] Array2 = { 1, 2, 3, 4, 5, 6 };
            // ask user to pick a number between 0-5
            Console.WriteLine("Please pick a number between 0-5");
            // conver user's answer to integer and saving in variable
            int answer2 = Convert.ToInt32(Console.ReadLine());
            // check to see if answer2 is in range
            if (answer2 > 5)
            {
                Console.WriteLine("Number is out of range.");
            }
            else
                if (answer2 <= 5)
            {
                // integer picked corresponds to number in array
                Console.WriteLine(Array2[answer2]);
            }
            Console.ReadLine();

            // list of strings
            List<string> myList = new List<string>();
            myList.Add("Orange");
            myList.Add("Apple");
            myList.Add("Grape");
            myList.Add("Pineapple");
            // ask user to pick a number
            Console.WriteLine("Pick a number between 0-3");
            int answer3 = Convert.ToInt32(Console.ReadLine());
            // check to see if answer3 is in range
            if (answer3 > 3)
            {
                Console.WriteLine("Number is out of range");
            }
            else
                if (answer3 <= 3)
            {
                //integer picked corresponds to fruit in list
                Console.WriteLine(myList[answer3]);
            }
            Console.ReadLine ();
        }
    }
}
