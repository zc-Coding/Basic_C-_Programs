using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace OperatorOverloading
{
    public class Employee
    {
        public int ID { get; set; }
        public string FName { get; set; }

        public static bool operator== (Employee emp1, Employee emp2)
        {
            bool answer = emp1.ID == emp2.ID;
            return answer;
        }

        public static bool operator!= (Employee ID1, Employee ID2)
        {
            bool answer = ID1 != ID2;
            return answer;
        }
    }
}
