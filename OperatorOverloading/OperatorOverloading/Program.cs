using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace OperatorOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Zach = new Employee() { ID = 1, FName = "Zach" };
            Employee Mark = new Employee() { ID = 2, FName = "Mark" };

            Console.WriteLine(Zach == Mark);
        }
    }
}
