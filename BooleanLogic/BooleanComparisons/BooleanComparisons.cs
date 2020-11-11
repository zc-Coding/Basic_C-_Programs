using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            while (number < 5)
            {
                Console.WriteLine(number);
                number++;
            }


            int i = 0;
            do
            {
                Console.WriteLine("Going up");
                i++;
            }
            while (i < 10);
          
        }
    }
}
