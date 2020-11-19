using System;
using System.Collections.Generic;
using System.Text;

namespace SuperClass
{
    class Employee : Person, IQuittable
    {
        public int Id { get; set; }

        public void Quit()
        {
            Console.WriteLine("THAT'S IT I'M OUT OF HERE");
        }
    }
}
