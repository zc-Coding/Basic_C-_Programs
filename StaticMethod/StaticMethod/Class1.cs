using System;
using System.Collections.Generic;
using System.Text;

namespace StaticMethod
{
    class Class1
    {
        public void Operation(string a)
        {
            int aInt = Convert.ToInt32(a);
            int answer = aInt / 2;
            Console.WriteLine(answer);
        }

        public double Operation(double a)
        {
            double answer = (a) / 2;
            return answer;
        }

    }
}
