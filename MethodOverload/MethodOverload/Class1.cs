using System;
using System.Collections.Generic;
using System.Text;

namespace MethodOverload
{
    class Class1
    {

        public int Operation1(int i)
        {
            int numb = i;
            return numb * 7 + 21;
        }

        public double Operation1(double j)
        {
            int numb = Convert.ToInt32(j);
            return numb + 2 / 3;
        }

        public int Operation1(string k)
        {
            int numb = Convert.ToInt32(k);
            return (numb * 7) + (7 / 7);
        }
    }
}
