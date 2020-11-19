using System;

namespace SuperClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee empSamp = new Employee();
            empSamp.FirstName = "Sample";
            empSamp.LastName = "Student";
            empSamp.SayName();

            Employee iQuit = new Employee();
            iQuit.Quit();
        }
    }
}
