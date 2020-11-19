using System;

namespace OptionalArgumentMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 mathOps = new Class1();
            Console.WriteLine("Hello!\nI will be asking you to enter two numbers one at at time\n" +
                "The second number is not required\nPlease enter your first number...");
            int input1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Now enter the second number, remember it is not required");
            string input2Str = Console.ReadLine();
            if (input2Str == "")
            {
                Console.WriteLine(mathOps.OptionalArgs(input1));
            }
            else
            {
                int input2 = Convert.ToInt32(input2Str);
                Console.WriteLine(mathOps.OptionalArgs(input1, input2));
            }
            
        }
    }
}
