namespace ContosoUniversity.Migrations
{
    using ContosoUniversity.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ContosoUniversity.DAL.SchoolContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ContosoUniversity.DAL.SchoolContext context)
        {
            var students = new List<Student>
            {
                new Student {FirstName ="Yamana", LastName = "Kashalnikov", About ="I love to learn about Contoso" }
               // new Student { FirstMidName = "Carson",   LastName = "Alexander",
                 //   EnrollmentDate = DateTime.Parse("2010-09-01") }
                
            };
            students.ForEach(s => context.Students.AddOrUpdate(p => p.LastName, s));
            context.SaveChanges();

            var courses = new List<Course>
            {
                new Course {CourseID = "CS101", Title= "Introduction to Contoso", Description="This course covers the basics of Contoso",
                Department=Department.SchoolofContosso, Level = Level.Undergrad, AssessmentType = AssessmentType.AssignmentA, CoursePic="www.google.com/logo.jpg" }
               // new Course {CourseID = 1050, Title = "Chemistry",      Credits = 3, },
               // new Course {CourseID = 4022, Title = "Microeconomics", Credits = 3, }
            };
            courses.ForEach(s => context.Courses.AddOrUpdate(p => p.Title, s));
            context.SaveChanges();

            //var enrollments = new List<Enrollment>
            //{
            //    new Enrollment
            //    {
            //        StudentID =students.Single(s => s.LastName == "Kashalnikov").StudentID
            //    }
            //    new Enrollment {
            //        StudentID = students.Single(s => s.LastName == "Alexander").ID,
            //        CourseID = courses.Single(c => c.Title == "Chemistry" ).CourseID,
            //        Grade = Grade.A
            //    },
            //     new Enrollment {
            //        StudentID = students.Single(s => s.LastName == "Alexander").ID,
            //        CourseID = courses.Single(c => c.Title == "Microeconomics" ).CourseID,
            //        Grade = Grade.C
            //     }
            //};

            //foreach (Enrollment e in enrollments)
            //{
            //    var enrollmentInDataBase = context.Enrollments.Where(
            //        s =>
            //             s.Student.ID == e.StudentID &&
            //             s.Course.CourseID == e.CourseID).SingleOrDefault();
            //    if (enrollmentInDataBase == null)
            //    {
            //        context.Enrollments.Add(e);
            //    }
            //}
            //context.SaveChanges();
        }
    }
}