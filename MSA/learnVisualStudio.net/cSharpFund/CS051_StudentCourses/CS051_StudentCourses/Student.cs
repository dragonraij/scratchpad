using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS051_StudentCourses
{
    public class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public List<Course> Courses { get; set; }

        public Student()
        {
            StudentID = 0;
            Name = "undefined";
        }

        public string DisplayStudent() {
            return "Student ID ="+StudentID + " Name=" + Name;
        }

    }
}