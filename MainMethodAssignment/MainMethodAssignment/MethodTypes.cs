using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    public class MethodTypes
    {
        //integer method
        public int Methods(int x) { return x + 5; }
        //decimal method
        public int Methods(decimal x) { return Convert.ToInt32(x)/3; }
        //string method
        public int Methods(string x) { return Convert.ToInt32(x)*6; }
    }
}
