using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractClass
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public abstract void SayName();
              
    }
}
