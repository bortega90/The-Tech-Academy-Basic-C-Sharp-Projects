using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace VoidClasses
{
    public class Class2
    {
        //create static method() with out parameters
        public static void Method(out string b)
        {
            b = " ";
            Console.WriteLine(b);
        }
    }
}

