using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Code_First
{
    //context classes inhereted by DbContext
    internal class SchoolContext : DbContext
    {
        public SchoolContext(): base() 
        {
        }
        //DbSet is collection of entity classes (entity set)
        //since its a collection the prop names are plural
        public DbSet<Student> Students { get; set; }

    }
}
