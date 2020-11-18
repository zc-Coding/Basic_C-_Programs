using System;
using System.Collections.Generic;
using System.Text;

namespace OptionalArgumentMethod
{
    class Class1
    {
        public int OptionalArgs(int a, int b = 2)
        {
            return a * b;
        }
    }
}
