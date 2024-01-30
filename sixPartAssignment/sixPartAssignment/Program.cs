using System;
using System.Collections;
using System.Collections.Generic;




class Program
{
    static void Main(string[] args)
    {
        //pt 1 ------------------------------------------------------
        // 1-d string array
        string[] names = { "Ollie", "Britny", "Emily", "Gemini", "Peter" };
        string[] updateNames = new string[names.Length + 1];
        // asking user to input a string
        Console.WriteLine("Add your name to the list: ");
        string addName = Console.ReadLine();
        // copy elements in names to updateName
        Array.Copy(names, updateNames, names.Length);
        // insert addName at the end ot updateNames
        updateNames[updateNames.Length - 1] = addName;
        // print new array
        Console.WriteLine("Update Names: ");
        for (int i = 0; i < updateNames.Length; i++)
        {
            Console.WriteLine(updateNames[i] + " ");         
        }
        Console.ReadLine();
        // end of pt1 ----------------------------------------------

        // pt 2 ----------------------------------------------------
        // infinity loop
        while (true)
        {
            string name = string.Join(" ", updateNames);
            // print array infinite times
            Console.WriteLine(name);
            // stops loop
            break;
        }
        Console.ReadLine() ;
  
        string name1 = string.Join(addName, updateNames);
        foreach (string name in updateNames)
        {
            Console.WriteLine(name1);
        }
        Console.ReadLine();
        // end pt 2 -----------------------------------------------
       
        // pt 3 ----------------------------------------------------
        Console.WriteLine("Pick a number between 0-7");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number > 7)
        {
            Console.WriteLine("error");
        }
        else
            if (number <= 7)
        {
            Console.WriteLine(number);
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
               
        //
        for (int i = 0; i < fruits.Count; i++)
        {
            if (fruits[i] == fruitSearch)
            {
                Console.WriteLine(i);
                break;
            }
            else
                if (fruits[i] !=  fruitSearch)
            {
                Console.WriteLine("Error");
            }
        }
        
        
        Console.ReadLine();

        //pt 5 ------------------------------------------------------
        List<string> movies = new List<string>() { "Titanic", "Black Swan", "Shrek", "Prince Of Egypt", "Shrek" };
        string moviesSearch = Console.ReadLine();
        

    }

}
