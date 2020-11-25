using System;

namespace ExceptionsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 0;
            Console.WriteLine("How old are you?");
            try
            {
                age = Convert.ToInt32(Console.ReadLine());
                if (age <= 0)
                {
                    Console.WriteLine("Your age is a whole positive non-zero number");
                    return;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("You really messed up this time");
                return;
            }
            DateTime today = DateTime.Now;
            int year = today.Year;
            int birthYear = year - age;
            
            Console.WriteLine(birthYear);

        }
    }
}
