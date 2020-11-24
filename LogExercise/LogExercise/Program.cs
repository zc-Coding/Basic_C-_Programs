using System;
using System.IO;

namespace LogExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("YOU KNOW WHAT THIS IS GIVE ME A NUMBER NOOOWWWWWW...");
            string numb = Convert.ToString(Console.ReadLine());
            using StreamWriter file = new StreamWriter(@"C:\Users\zachc\Documents\TechAcademy\C# .NET\Basic_C#_Programs\LogExercise\Log.txt", true);
            file.WriteLine(numb);
            Console.WriteLine(numb + " THAT'S ALL YOU GOT?!?!");
        }
    }
}
