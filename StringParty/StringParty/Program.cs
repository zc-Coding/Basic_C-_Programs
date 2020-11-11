using System;
using System.Text;

namespace StringParty
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "When put together ";
            string str2 = "you will get ";
            string str3 = "a whole concatenated string.";

            Console.WriteLine(str1 + str2 + str3);
            Console.WriteLine(str3.ToUpper());

            StringBuilder sb = new StringBuilder();
            sb.Append("This was builded by the string builder");
            Console.WriteLine(sb);
            Console.ReadLine();
            sb.Replace('d', 't');
            Console.WriteLine(sb);
        }
    }
}
