using System;

namespace BasicMethodsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!\n" +
                "Please enter a number, we will be doing a few math operations to it");
            int numb = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(MathOperations.Addition(numb));
            Console.WriteLine(MathOperations.Multiply(numb));
            Console.WriteLine(MathOperations.DivideByFive(numb));
        }
    }
}
