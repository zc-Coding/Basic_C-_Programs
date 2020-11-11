using System;
using System.Collections.Generic;
using System.Globalization;

namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Zach", "Beans", "Means", "Mae" };

            for (int j = 0; j < names.Length; j++)
                if (names[j] == "Means")
                {
                    Console.WriteLine(j);
                }



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
}
