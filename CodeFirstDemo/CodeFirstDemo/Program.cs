using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new StudentContext())
            {

                var stud = new Student() { FirstName = "Tony", LastName = "Bologna", HomePhone = "555-654-9845" };

                ctx.Students.Add(stud);
                ctx.SaveChanges();
            }
        }
    }
}
