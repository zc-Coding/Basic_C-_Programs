﻿using System;

namespace Scores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter in your first name");
            string date = DateTime.Today.ToShortDateString();
            string uName = Console.ReadLine();
            string msg = $"\nWelcome back {uName}. today is {date}.";
            Console.WriteLine(msg);

            string path = @"C:\Users\zachc\Documents\TechAcademy\C# .NET\Basic_C#_Programs\Scores\Scores\StudentScores.txt";
            string[] lines = System.IO.File.ReadAllLines(path);

            double tScore = 0.0;

            Console.WriteLine("\nStudent Scores: \n");
            foreach (string line in lines)
            {
                Console.WriteLine(line);
                    double score = Convert.ToDouble(line);
                tScore += score;
            }

            double avgScore = tScore / lines.Length;
            Console.WriteLine("\nTotal of " + lines.Length + " student scores. \tAverage score: " + avgScore);

            Console.WriteLine("\n\nPress any key to exit");
        }
    }
}
