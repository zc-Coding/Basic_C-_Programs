using System;
using System.Collections.Generic;
using System.Text;

namespace MethodOverload
{
    class Class1
    {
        public static int Operation1(int i)
        {
            int numb = i;
            return numb * 7 + 21;
        }

        public static double Operation1(double j)
        {
            int numb = Convert.ToInt32(j);
            return numb + 2 / 3;
        }

        public static int Operation1(string k)
        {
            int numb = Convert.ToInt32(k);
            return (numb * 7) + (7 / 7);


            // Attempted return of an error message if the string couldn't be converted to a integer
            //try
            //{
            //    int numb = Convert.ToInt32(k);
            //    return (numb * 7) + (7 / 7);
            //}
            //catch (Exception ex)
            //{
            //    return ex.meessage;
            //}


        }
    }
}
