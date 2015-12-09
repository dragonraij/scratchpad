using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS051_StudentCourses
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //Add a dictionary of students, each student should have at least two courses in them
            //use object and collection initializers, then list through course details and print students
            //use student id as the key
            Dictionary<string, Student> studentDir = new Dictionary<string, Student>();

            studentDir.Add("S11", new Student { Name = "Mike", StudentID = 11, Courses = new List<Course>() { 
            new Course{ CourseID=1, Name="Major in Music"},
            new Course{ CourseID=3, Name="Financial Study"}
            
            } 
            });

            studentDir.Add("S14", new Student
            {
                Name = "Maurice",
                StudentID = 14,
                Courses = new List<Course>()
                {
                    new Course{ CourseID=12, Name="Pencil Art"},
                    new Course{ CourseID=14, Name="Art History"}
                }
            });

            resultLabel.Text = "";
            foreach (var student in studentDir)
            {
                resultLabel.Text += "<p><b>" + student.Value.DisplayStudent() + "</p></b>";
                foreach (var course in student.Value.Courses)
                {
                    resultLabel.Text += "<p>"+course.DisplayCourse()+"</p>";
                }
            }

        }

        protected void AssignmentButton1_Click(object sender, EventArgs e)
        {
            //Add a list of courses, each course should have at least two students in them
            //use object and collection initializers, then list through course details and print students

            Student bob = new Student { StudentID = 1, Name = "Bob Jones" };
            Student henry = new Student { StudentID = 2, Name = "Sam Smee" };
            
            List<Course> courses = new List<Course>();

            courses.Add(new Course { CourseID = 1, Name = "Business 101", Students = new List<Student>(){
                           new Student(){ Name="Bob", StudentID=11},
                           new Student(){ Name="Alan", StudentID=13}
                           
                           } });

            courses.Add(new Course { CourseID = 4, Name = "Intro to Macroeconomics 100", Students = new List<Student>() { 
                new Student(){ Name="Steve", StudentID=13},
                new Student(){ Name  = "Matthew", StudentID=16}
            } });


            //clear result label
            resultLabel.Text = "";

            //display course data
            for (int i = 0; i < courses.Count; i++)
            {
 
                resultLabel.Text += "<p><b>" +courses.ElementAt(i).DisplayCourse()+"</b></p>";
                
                Course currentCourse = courses.ElementAt(i);
                for (int j = 0; j < currentCourse.Students.Count; j++)
                {
                    resultLabel.Text += "<p>  " + currentCourse.Students.ElementAt(j).DisplayStudent() + "</p>";
                }
            }
        }

        protected void AssignmentButton3_Click(object sender, EventArgs e)
        {
            //for each student add a grade for each class they are taking
            // cycle through and print the grades
            List<Enrollment> Enrollments = new List<Enrollment>();
            Enrollments.Add(new Enrollment { Grade = 'A', Course = new Course { Name = "Intro to Contoso", CourseID = 100 }, Student = new Student { Name="Bob Jones", StudentID=111 } });
            Enrollments.Add(new Enrollment { Grade = 'B', Student = new Student { Name = "Steven Hawk", StudentID = 123 }, Course = new Course { CourseID=211, Name="Advanced Contoso" } });

        }
    }
}