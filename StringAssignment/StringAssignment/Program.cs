using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // three string variables
            string fName = "Britny";
            string mName = "Lynn";
            string lName = "Ortega";
            
            // turning lName to all capital letters
            lName = lName.ToUpper();
            // putting together all three strings
            Console.WriteLine(" My first name is "+ fName +", my middle name is "+ mName +", and my last name is "+ lName);
            Console.ReadLine();

            // StringBuilder
            StringBuilder paragraph = new StringBuilder();
                              //tab                     //new lines
            paragraph.Append("\tI am writing a paragraph. \n I tabbed my first sentence.\n With each new sentence I am creating a new line. \n Okay, that is all now");
                              //calling paragraph function
            Console.WriteLine(paragraph);
            Console.ReadLine() ;

        }
    }
}
