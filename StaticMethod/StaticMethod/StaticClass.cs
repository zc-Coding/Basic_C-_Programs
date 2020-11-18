using System;
using System.Collections.Generic;
using System.Text;

namespace StaticMethod
{
    static class StaticClass
    {
        public static int Adder(out int i)
        {
            i = 30;
            i += i;
            return i;
        }

    }
}
