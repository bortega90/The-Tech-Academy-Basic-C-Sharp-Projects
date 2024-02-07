using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment1
{
    public class ChainConstructor
    {
        //setting properties for class
        private int id;
        private string name;

        //constructor              //assigning id to 001 and name to bob
        public ChainConstructor() : this (001, "Bob")
        {

        }
        // calling constructor passing two parameters
        public ChainConstructor(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }   
    
}
