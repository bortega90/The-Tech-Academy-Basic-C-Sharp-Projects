using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //constant variable
            const string fName = "Britny";
            // var variable
            var lName = "Ortega";
            Console.WriteLine("My name is {0} {1}.",  fName, lName);
            ChainConstructor chainConstructor = new ChainConstructor();
            Console.ReadLine();
        }
    }
    
}
