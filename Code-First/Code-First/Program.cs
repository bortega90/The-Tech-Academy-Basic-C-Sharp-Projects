using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_First
{
    internal class Program
    {
        static void Main(string[] args)
        {

            using (var ctx = new SchoolContext())
            {
                //creating student "Britny Ortega"
                var student = new Student() {Id = 1, FirstName = "Britny", LastName = "Ortega" };
                //adding student to db
                ctx.Students.Add(student);
                //saving changes to the db
                ctx.SaveChanges();
            }
        }
    }
}
