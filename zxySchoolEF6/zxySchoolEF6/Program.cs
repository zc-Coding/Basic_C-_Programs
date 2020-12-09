using System;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;


namespace zxySchoolEF6
{
    class Program
    {
        static void Main(string[] args)
        {
            
            using (var ctx = new SchoolContext())
            {
                var stud = new Student() { StudentName = "Bill" };

                ctx.Students.Add(stud);
                ctx.SaveChanges();
            }
        }
    }
}
