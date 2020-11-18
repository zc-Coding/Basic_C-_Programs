using System;

namespace MethodOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 mathOps = new Class1();

            Console.WriteLine(mathOps.Operation1(7));
            
            Console.WriteLine(mathOps.Operation1(7.34));

            Console.WriteLine(mathOps.Operation1("7"));
        }
    }
}
