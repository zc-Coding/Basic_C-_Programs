using System;

namespace ChainConstructors
{
    class Program
    {
        static void Main(string[] args)
        {
            // constant variable
            const string constSTR = "The string that is a constant";
            // the errorless use of var method
            string FixesError()
            {
                var person1 = "This could actually be any data type... HOW FUN!";
                return "This also fixes a minor error\n" + person1+ "\n" + constSTR;
            }
            Console.WriteLine(FixesError());
        }
    }
}
