using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        // Part one of assignment array of strings with a return of the index the user input
           string[] strArray = { "Wrong!", "Nothing", "A BRAND NEW CAR!!", "One year supply of cat food", "Whammy!" };
           Console.WriteLine("Pick a door 0-4 for a chance of a prize");
           int strNum = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine(strArray[strNum]);


        // Part two of assignment array of integers with a return of the index the user input
        try
        {
            int[] numArray = { 3, 6, 18, 108, 1064 };
            Console.WriteLine("\nLucky Number Machine\nEnter number 0-4...");
            int numNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your lucky number is " + numArray[numNum]);
        }
        catch
        {
            Console.WriteLine("incorrect input, no luck to be had");
        }

        // Part 4 of assinfment list of strings with returned user input as index
        List<string> strList = new List<string>()
            {"zero","one","two","three","four" };
        Console.WriteLine("\nplease enter an integer 0-4");
        int listNum = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("it is now a word..." + strList[listNum]);

        


        //Notes from the videos

        //List<int> intList = new List<int>();
        //intList.Add(4);
        //intList.Add(10);

        //Console.WriteLine(intList[0]);



        //int[] numArray = new int[5];
        //numArray[0] = 5;
        //numArray[1] = 7;
        //numArray[2] = 35;
        //numArray[3] = 987;
        //numArray[4] = 19;

        //int[] numArray1 = new int[] { 5, 12, 354, 678, 333 };


        //int[] numArray2 = { 5, 2, 10, 20, 200 };
        //numArray2[0] = 2;
        //Console.WriteLine(numArray2[0]);
    }
}
