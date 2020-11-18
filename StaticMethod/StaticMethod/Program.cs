using System;

namespace StaticMethod
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Class1 mathOp = new Class1();
            Console.WriteLine("enter a number");
            string input = Console.ReadLine();
            mathOp.Operation(input);

            Console.WriteLine(mathOp.NoParameter());

        }

        
        
    }
}
