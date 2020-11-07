using System;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number less than 10,000,001");
            string input1 = Console.ReadLine();
            int integ1 = Convert.ToInt32(input1);
            int results1 = integ1 * 50;
            Console.WriteLine("Your number multiplied by 50 is " + results1.ToString() + "\n");

            Console.WriteLine("May I have another number please?");
            string input2 = Console.ReadLine();
            int integ2 = Convert.ToInt32(input2);
            int results2 = integ2 + 25;
            Console.WriteLine("This is that number plus twenty five " + results2.ToString() + "\n");

            Console.WriteLine("Gimme another one!");
            string input3 = Console.ReadLine();
            int integ3 = Convert.ToInt32(input3);
            double results3 = integ3 / 12.5;
            Console.WriteLine("This number was divided by 12.5 " + results3 + "\n");

            Console.WriteLine("YOU KNOW THE DRILL!!!!");
            string input4 = Console.ReadLine();
            int integ4 = Convert.ToInt32(input4);
            bool results4 = integ4 > 50;
            Console.WriteLine("Is your number greater than 50? " + (results4 ? "Yes" : "No") + "\n");

            Console.WriteLine("One more number?");
            string input5 = Console.ReadLine();
            int integ5 = Convert.ToInt32(input5);
            int results5 = integ5 % 7;
            Console.WriteLine("The remainder of your number divided by 7 is " + results5.ToString());
            Console.Read();
        }
    }
}
