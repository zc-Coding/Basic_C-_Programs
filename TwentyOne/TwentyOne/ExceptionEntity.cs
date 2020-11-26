using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyOne
{
    public class ExceptionEntity
    {
        public int ID { get; set; }
        public string ExceptionType { get; set; }
        public string ExceptionMessage { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
