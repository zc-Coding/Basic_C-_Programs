﻿using System;


namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            int height;
            int weight;
            int width;
            int length;
            int tooBig;
            Console.WriteLine("Welcome to Package Express.\nPlease follow the instructions below.\n\n" +
               "Please enter the package weight:");
            weight = Convert.ToInt32(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day!");
                Environment.Exit(1);
            }
            Console.WriteLine("Please enter the package width:");
            width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter package height");
            height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the package length:");
            length = Convert.ToInt32(Console.ReadLine());
            tooBig = height + width + length;
            
            if (tooBig > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express");
            }
            else
            {
                decimal quote = Convert.ToDecimal(height * width * length * weight / 100);
                Console.WriteLine("Your estimated total for shipping this package is: $" + quote + ".00\nThank you!");
            }
            Console.ReadLine();




            //int roomTemperature = 70;

            //Console.WriteLine("Hi, what is your name?");
            //string name = Console.ReadLine();

            //Console.WriteLine("Hi, " + name + ", what is the temperature where you are?");
            //int currentTemperature = Convert.ToInt32(Console.ReadLine());

            //string roomTemp = currentTemperature > roomTemperature ? "it hotter than room temp" : "it it's colder than room temp";
            //Console.WriteLine(roomTemp);


            //{
            //    Console.WriteLine("it is exactly room temperature");
            //}
            //else if (currentTemperature > roomTemperature)
            //{
            //    Console.WriteLine("it is hotter than room temperature " + name);
            //}
            //else
            //{
            //    Console.WriteLine("Hey, " + name + " wear something warm");
            //}
            //Console.ReadLine();


            //int currentTemperature = 70;
            //int roomTemperature = 70;

            //if (currentTemperature == roomTemperature)
            //{
            //    Console.WriteLine("it is exactly room temperature");
            //}
            //else
            //{
            //    Console.WriteLine("It is not exactly room temperature");
            //}

            //string comparisonResult = currentTemperature == roomTemperature ? "it is room temp" : "it is not room temp";
            //Console.WriteLine(comparisonResult);
        }
    }
}
