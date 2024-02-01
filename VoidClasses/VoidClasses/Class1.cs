using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidClasses
{
    //declaring class static?
    static class Class1
    {   
        //create void method() that outputs an integer
        public void Method(int x, out int result)
        {
            result = x / 2;
        }
        //create method() w/ output parameters
        public int Method(int x) { return x; }
    }
}
