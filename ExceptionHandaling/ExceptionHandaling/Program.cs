using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ExceptionHandaling
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() {24, 677, 987, 241, 64, 73, 65222, 1354 };
            List<int> answers = new List<int> { };
            int i = 0;
            int divisor = 0;
            Console.WriteLine("Please enter a number for the division machine");
            string divisorStr = Console.ReadLine();
            try
            {
                divisor = Convert.ToInt32(divisorStr);
                while (i < numbers.Count)
                {
                    answers.Add(numbers[i] / divisor);
                    Console.WriteLine(answers[i]);
                    i++;
                }
            }
            catch (FormatException formEx)
            {
                Console.WriteLine(formEx.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("try\\catch complete resuming program execution");
            }





            //try
            //{

            //        while (i < numbers.Count)
            //        {
            //            answers.Add(numbers[i] / divisor);
            //            Console.WriteLine(answers[i]);
            //            i++;
            //        }

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("try\\catch complete resuming program execution");
            //}


            //try
            //{
            //    Console.WriteLine("Pick a number");
            //    int numberOne = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Pick a second number");
            //    int numberTwo = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Dividng the two...");
            //    int numberThree = numberOne / numberTwo;
            //    Console.WriteLine(numberOne + " Divided by " + numberTwo + " equals " + numberThree);
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine("Please type a whole number");
            //    return;
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.Write("PLease don't divide by zero");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //Console.ReadLine();
            //}
        }
    }
}
