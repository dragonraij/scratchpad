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
            //Dummy Student Data
            var students = new List<Student>
            {
                new Student {FirstName ="Yamana", LastName = "Kashalnikov", About ="I love to learn about Contoso" }
               // new Student { FirstMidName = "Carson",   LastName = "Alexander",
                 //   EnrollmentDate = DateTime.Parse("2010-09-01") }
                
            };
            students.ForEach(s => context.Students.AddOrUpdate(p => p.LastName, s));
            context.SaveChanges();

            // Dummy Lecturer Data
            var lecturers = new List<Lecturer>
            {
                new Lecturer { FirstName="John", LastName="Smith", Email="j.smith@contoso.ac.nz",
                    Bio ="John is a world leader in the Science of Contoso", Extension=911, ProfilePic="www.imgur.com/giraffe.jpg" }
            };
            lecturers.ForEach(l => context.Lecturers.AddOrUpdate(p => p.LastName, l));
            context.SaveChanges();

            //Dummy Course Info
            var courses = new List<Course>
            {
                new Course {CourseID = "CS101", Title= "Introduction to Contoso", Description="This course covers the basics of Contoso",
                Department=Department.SchoolofContosso, Level = Level.Undergrad, AssessmentType = AssessmentType.AssignmentA, CoursePic="www.google.com/logo.jpg" }
               // new Course {CourseID = 1050, Title = "Chemistry",      Credits = 3, },
               // new Course {CourseID = 4022, Title = "Microeconomics", Credits = 3, }
            };
            courses.ForEach(s => context.Courses.AddOrUpdate(p => p.Title, s));
            context.SaveChanges();

           
            var enrollments = new List<Enrollment>
            {
                new Enrollment
                {
                    StudentID =students.Single(s => s.LastName == "Kashalnikov").StudentID,
                    CourseID = courses.Single(c => c.Title =="Introduction to Contoso").CourseID,
                    Grade = Grade.A, Status = Status.Enrolled
                }
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
            };

            foreach (Enrollment e in enrollments)
            {
                var enrollmentInDataBase = context.Enrollments.Where(
                    s =>
                         s.Student.StudentID == e.StudentID &&
                         s.Course.CourseID == e.CourseID).SingleOrDefault();
                if (enrollmentInDataBase == null)
                {
                    context.Enrollments.Add(e);
                }
            }
            context.SaveChanges();

            //Enter dummy value for student assessements
            var studentAssessments = new List<StudentAssessment>
            {
                new StudentAssessment
                {
                    SubmissionTime = DateTime.Parse("2001-01-01"),
                    Marks = 91, SubmissionLink = "www.yahoo.com",
                    EnrollmentID=enrollments.Single(e=>e.Status==Status.Enrolled).EnrollmentID

                }

            };

            foreach (StudentAssessment sa in studentAssessments)
            {
               
                   context.StudentAssessments.Add(sa);
               
            }
            context.SaveChanges();


            //eNTER dummy data for Assessments
            var assessments = new List<Assessment>
            {
                new Assessment
                {
                    SubmissionType = SubmissionType.Presentation, DueDate=DateTime.Parse("2016-12-12"),
                     TotalMarks =30, Weight = 0.3F, CourseID=courses.Single(c=>c.Department==Department.SchoolofContosso).CourseID
                }
            };


            foreach (Assessment a in assessments)
            {

                context.Assessments.Add(a);

            }
            context.SaveChanges();
        }
    }
}