using System;
using System.Collections.Generic;

namespace GenericsAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee<int> Numbers = new Employee<int>();
            Numbers.Things = new List<int>() { 3, 5, 7 };
            Numbers.Things.Add(3);
            
        }
    }
}
