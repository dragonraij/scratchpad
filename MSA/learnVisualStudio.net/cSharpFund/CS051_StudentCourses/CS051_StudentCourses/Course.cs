using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS051_StudentCourses
{
    public class Course
    {
        public int CourseID { get; set; }
        public String Name { get; set; }
        public List<Student> Students { get; set; }

        public string DisplayCourse(){
            return CourseID + " " + Name;
        }

        public Course()
        {
            CourseID = 0;
            Name = "undefined";
        }



    }
}