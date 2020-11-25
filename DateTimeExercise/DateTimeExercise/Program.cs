using System;

namespace DateTimeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentDT = DateTime.Now;
            Console.WriteLine("Hello the current time is.. " + currentDT);
            Console.WriteLine("\nHow many hours would you like to go into the future?");
            double hours = Convert.ToDouble(Console.ReadLine());
            DateTime newDT = currentDT.AddHours(hours);
            Console.WriteLine("Your destination is... " + newDT);
            
        }
    }
}
