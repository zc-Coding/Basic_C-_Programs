using System;
using System.Collections;
using System.Collections.Generic;

namespace LambdaExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            

            list.Add(new Employee() { ID = 1, Fname = "Joe", Lname = "Walsh" });
            list.Add(new Employee() { ID = 2, Fname = "Joe", Lname = "Cocker" });
            list.Add(new Employee() { ID = 3, Fname = "Mick", Lname = "Jager" });
            list.Add(new Employee() { ID = 4, Fname = "Trey", Lname = "Anistasio" });
            list.Add(new Employee() { ID = 5, Fname = "Cat", Lname = "Stevens" });
            list.Add(new Employee() { ID = 6, Fname = "Justin", Lname = "Beiber" });
            list.Add(new Employee() { ID = 7, Fname = "Stevie", Lname = "Wonder" });
            list.Add(new Employee() { ID = 8, Fname = "Herbie", Lname = "Hancock" });
            list.Add(new Employee() { ID = 9, Fname = "Neil", Lname = "Pert" });
            list.Add(new Employee() { ID = 10, Fname = "Dee", Lname = "Snyder" });

            List<Employee> joes = new List<Employee>();

            foreach (Employee employee in list)
            {
                if (employee.Fname == "Joe")
                {
                    joes.Add(new Employee() { ID = employee.ID, Fname = employee.Fname, Lname = employee.Lname });
                }
            }

            List<Employee> LambdaExp = list.FindAll(x => x.ID > 5);
        }
    }
}
