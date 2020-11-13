using System;
using System.Collections.Generic;
using System.Globalization;

namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> testScores = new List<int>() { 98, 94, 78, 87, 97, 89, 48, 87, 65 };
            List<int> passingScores = new List<int>();

            foreach (int score in testScores)
            {
                if (score > 90)
                {
                    passingScores.Add(score);
                }

                Console.WriteLine(passingScores);

            }

        }








            //List<string> names = new List<string>() { "Gina", "Mae", "Devin", "Todoroki", "Walt" };

            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
                
            //}





            //List<int> testScores = new List<int>();
            //testScores.Add(87);
            //testScores.Add(97);
            //testScores.Add(67);
            //testScores.Add(77);
            //testScores.Add(88);
            //testScores.Add(89);

            //foreach (int score in testScores)
            //{
            //    if (score > 95)
            //    {
            //        Console.WriteLine("Passing test score: " + score);
            //    }
            //}

            //string[] names = { "Zach", "Beans", "Means", "Mae" };

            //for (int j = 0; j < names.Length; j++)
            //    if (names[j] == "Means")
            //    {
            //        Console.WriteLine(j);
            //    }



            //int[] testScores = { 98, 94, 78, 87, 97, 89, 48, 87, 65 };

            //for (int i = 0; i < testScores.Length; i++)
            //{
            //    if (testScores[i] > 85)
            //    {
            //        Console.WriteLine("Passing test score: " + testScores[i]);
            //    }
            //}
        
    }
}
