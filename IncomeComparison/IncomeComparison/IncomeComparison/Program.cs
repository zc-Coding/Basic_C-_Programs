using System;

namespace IncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program\npress enter key to continue...");
            Console.Read();
            // Begin Person 1
            Console.WriteLine("Person 1\nHourly Rate?");
            Console.ReadLine();
            //string person1HRate = Console.ReadLine();
            int p1Rate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours workes per week?");
            //string person1Hours = Console.ReadLine();
            int p1Hours = Convert.ToInt32(Console.ReadLine());
            // Person 1 Salary Calculations
            int p1Salary = (p1Hours * p1Rate * 52);
            //Begin Person 2
            Console.WriteLine("Person 2\nHourly Rate?");
            //string person2HRate = Console.ReadLine();
            int p2Rate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            //string person2Hours = Console.ReadLine();
            int p2Hours = Convert.ToInt32(Console.ReadLine());
            // Person 2 Salary Caluations
            int p2Salary = (p2Hours * p2Rate * 52);
            // Salaries Comparison
            bool salaryBool = (p1Salary > p2Salary);
            // Begin Salary display
            Console.WriteLine("Annual salary of Person 1:\n" + p1Salary);
            Console.WriteLine("Annual salary of Person 2:\n" + p2Salary);
            // Comparison Statement
            Console.WriteLine("Does Person 1 make more money than Person 2?\n" + salaryBool);
        }
    }
}
