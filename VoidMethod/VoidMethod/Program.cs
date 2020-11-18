using System;

namespace VoidMethod
{
    class Program
    {
        static void Main(string[] args)
        {

            Class1 twoInput = new Class1();
            twoInput.Operations(3, 8);

            int x = 7;
            int y = 2;
            twoInput.Operations(x, y);
        }
    }
}
