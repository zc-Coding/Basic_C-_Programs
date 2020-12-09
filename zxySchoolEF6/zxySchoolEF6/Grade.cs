using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;

namespace zxySchoolEF6
{
    public class Grade
    {
        public int GradeID { get; set; }
        public string GradeName { get; set; }
        public string Section { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
