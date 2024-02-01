using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassSubmissionAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //class and instantiate 
            Parameters obj = new Parameters();

            //calling method() for passing numbers
            obj.Parameter(5, 6); 
            //calling method() by parameter name
            obj.Parameter(x: 3, y: 5);
            Console.ReadLine();
            

        }
    }
}
