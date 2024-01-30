using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;



class Program
{
    static void Main(string[] args)
    {
        //pt 1 ------------------------------------------------------
        // 1-d string array
        string[] names = { "Ollie", "Britny", "Emily", "Gemini", "Peter" };
        StringBuilder sb = new StringBuilder();
        // asking user to input a string
        Console.WriteLine("Add text: ");
        sb.AppendLine(Console.ReadLine());
        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine(names[i] + sb);
        }
        Console.ReadLine();
        // end of pt1 ----------------------------------------------

        // pt 2 ----------------------------------------------------
        // infinity loop
        while (true)
        {
            string name = string.Join(" ", names);
            // print array infinite times
            Console.WriteLine(name);
            // stops loop
            break;
        }
        Console.ReadLine() ;
        // end pt 2 -----------------------------------------------
       
        // pt 3 ----------------------------------------------------
        Console.WriteLine("Pick a number between 0-7");
        int number = Convert.ToInt32(Console.ReadLine());

        for ( int i = 0; i < number;)
        {
            if (number < 7)
            {
                Console.WriteLine("This number works");
                break;
            }
            else
            {
                Console.WriteLine("error");
                break;
            }
        }

        Console.WriteLine("Pick another number");
        int number1 = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i <= number1;)
        {
            if (number1 <= 7)
            {
                Console.WriteLine("This works");
                break;
            }
            else
            {
                Console.WriteLine("error");
                break;
            }
        }
        Console.ReadLine();
        // end pt 3 -------------------------------------------------


        // pt 4 -----------------------------------------------------
        // string list
        List<string> fruits = new List<string>() { "Orange", "Apple", "Grape", "Pineapple" }; 
        // Ask user to search from list of fruit
        Console.WriteLine("Search through list of fruits");
        // user's string input
        string fruitSearch = Console.ReadLine();
        bool found = false;       
        //
        for (int i = 0; i < fruits.Count; i++)
        {
            if (fruits[i] == fruitSearch)
            {
                found = true;
                Console.WriteLine(i);
                break;
            }  
        }
        if (found == false)
        {
            Console.WriteLine("Fruit not found.");
        }
        
        Console.ReadLine();

        //pt 5 ------------------------------------------------------
        List<string> movies = new List<string>() { "Titanic", "Black Swan", "Shrek", "Prince Of Egypt", "Shrek" };
        Console.WriteLine("Pick a movie from the list");
        string moviesSearch = Console.ReadLine();
        bool pick = false;
        for (int i = 0; i < movies.Count;i++)
            if (movies[i] == moviesSearch)
        {
                pick = true;
            Console.WriteLine(i);
             
        }
        if  (pick == false)
        {
            Console.WriteLine("Movie not found.");
        }
        Console.ReadLine();

        //pt 6 ------------------------------------------------------
        List<string> animals = new List<string>() { "zebra", "cat", "dog", "zebra", "elephant" };
        List<string> newList = new List<string>();
        foreach (string animal in animals)
        {
            if (newList.Contains(animal))
            {
                Console.WriteLine(animal + "- I have seen this animal");
            }
            else
            {
                Console.WriteLine(animal + "- I have not seen this animal");
                newList.Add(animal);
            }
                
        }
        Console.ReadLine();

    }

}
