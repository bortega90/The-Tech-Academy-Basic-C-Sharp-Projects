﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidClasses
{
    //declaring class static?
    public class Class1
    {
        //create void method() that outputs an integer
        public void Method(int x)
        {
            Console.WriteLine(x / 2);
        }

        public void Method(int x= 4, int y= 6)
        {
            Console.WriteLine(x * y);
        }

       
    }
}
