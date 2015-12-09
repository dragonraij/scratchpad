using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS051_StudentCourses
{
    public class Enrollment
    {
        public char Grade { get; set; }
        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}