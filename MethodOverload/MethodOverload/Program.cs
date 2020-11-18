using System;

namespace MethodOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(Class1.Operation1(7));

            Console.WriteLine(Class1.Operation1(7.34));

            Console.WriteLine(Class1.Operation1("7"));
        }
    }
}
