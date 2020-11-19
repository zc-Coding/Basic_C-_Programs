using System;

namespace VoidMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiation 
            Class1 twoInput = new Class1();
            //passing in two numbers
            twoInput.Operations(3, 8);
            //specifying parameters by name
            twoInput.Operations(a:6, b:27);
        }
    }
}
