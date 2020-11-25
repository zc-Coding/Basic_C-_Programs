using System;
using System.Collections.Generic;
using System.Text;

namespace ChainConstructors
{
    class Person
    {
        // Second constructor calling the first
        public Person(string FName) : this(FName, "none", 1001)
        {
        }
        //First and larger constructor
        public Person(string firstN, string lastN, int ID)
        {
            FName = firstN;
            LName = lastN;
            MyID = ID;
        }
        // properties for Person class
        public string FName { get; set; }
        public string LName { get; set; }
        public int MyID { get; set; }
    }
}
