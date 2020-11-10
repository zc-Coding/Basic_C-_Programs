using System;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Insurance Bot X15\nWhat's your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What's your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI?(True/False)");
            bool DUI = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());
            bool qualified = (age >= 25 && DUI == false && tickets < 3);
            Console.WriteLine(name + " are you qualified?\n" + qualified);


        }
    }
}
