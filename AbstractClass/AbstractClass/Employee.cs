using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractClass
{
    public class Employee : Person
    {
        public override void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
