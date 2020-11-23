using System;
using System.Collections.Generic;
using System.Collections;

namespace EnumsAssigment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the current day of the week");
            string dayOfWeek = Console.ReadLine();                 
            
            try
            {
                Weekday answer = (Weekday)Enum.Parse(typeof(Weekday), dayOfWeek, true);
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter an actual day of the week");
            }
            
        }
    }
}
