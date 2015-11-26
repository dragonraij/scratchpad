namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Assessment",
                c => new
                    {
                        AssessmentID = c.Int(nullable: false, identity: true),
                        SubmissionType = c.Int(nullable: false),
                        TotalMarks = c.Single(nullable: false),
                        Weight = c.Single(nullable: false),
                        DueDate = c.DateTime(nullable: false, storeType: "date"),
                        Course_CourseID = c.Int(),
                    })
                .PrimaryKey(t => t.AssessmentID)
                .ForeignKey("dbo.Course", t => t.Course_CourseID)
                .Index(t => t.Course_CourseID);
            
            CreateTable(
                "dbo.Course",
                c => new
                    {
                        CourseID = c.Int(nullable: false),
                        Title = c.String(maxLength: 30, storeType: "nvarchar"),
                        Description = c.String(unicode: false),
                        Department = c.Int(nullable: false),
                        Level = c.Int(nullable: false),
                        AssessmentType = c.Int(nullable: false),
                        CoursePic = c.String(unicode: false),
                        Lecturer_LecturerID = c.Int(),
                    })
                .PrimaryKey(t => t.CourseID)
                .ForeignKey("dbo.Lecturer", t => t.Lecturer_LecturerID)
                .Index(t => t.Lecturer_LecturerID);
            
            CreateTable(
                "dbo.Enrollment",
                c => new
                    {
                        EnrollmentID = c.Int(nullable: false, identity: true),
                        Grade = c.Int(),
                        Status = c.Int(nullable: false),
                        Course_CourseID = c.Int(),
                        Student_StudentID = c.Int(),
                    })
                .PrimaryKey(t => t.EnrollmentID)
                .ForeignKey("dbo.Course", t => t.Course_CourseID)
                .ForeignKey("dbo.Student", t => t.Student_StudentID)
                .Index(t => t.Course_CourseID)
                .Index(t => t.Student_StudentID);
            
            CreateTable(
                "dbo.Student",
                c => new
                    {
                        StudentID = c.Int(nullable: false, identity: true),
                        LastName = c.String(nullable: false, maxLength: 40, storeType: "nvarchar"),
                        FirstName = c.String(nullable: false, maxLength: 40, storeType: "nvarchar"),
                        About = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.StudentID);
            
            CreateTable(
                "dbo.StudentAssessment",
                c => new
                    {
                        StudentAssessmentID = c.Int(nullable: false, identity: true),
                        SubmissionTime = c.DateTime(nullable: false, precision: 0),
                        Marks = c.Single(),
                        SubmissionLink = c.String(unicode: false),
                        Enrollment_EnrollmentID = c.Int(),
                    })
                .PrimaryKey(t => t.StudentAssessmentID)
                .ForeignKey("dbo.Enrollment", t => t.Enrollment_EnrollmentID)
                .Index(t => t.Enrollment_EnrollmentID);
            
            CreateTable(
                "dbo.Lecturer",
                c => new
                    {
                        LecturerID = c.Int(nullable: false, identity: true),
                        LastName = c.String(nullable: false, unicode: false),
                        FirstName = c.String(nullable: false, unicode: false),
                        Email = c.String(unicode: false),
                        Extension = c.Short(),
                        Bio = c.String(unicode: false),
                        ProfilePic = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.LecturerID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Course", "Lecturer_LecturerID", "dbo.Lecturer");
            DropForeignKey("dbo.StudentAssessment", "Enrollment_EnrollmentID", "dbo.Enrollment");
            DropForeignKey("dbo.Enrollment", "Student_StudentID", "dbo.Student");
            DropForeignKey("dbo.Enrollment", "Course_CourseID", "dbo.Course");
            DropForeignKey("dbo.Assessment", "Course_CourseID", "dbo.Course");
            DropIndex("dbo.StudentAssessment", new[] { "Enrollment_EnrollmentID" });
            DropIndex("dbo.Enrollment", new[] { "Student_StudentID" });
            DropIndex("dbo.Enrollment", new[] { "Course_CourseID" });
            DropIndex("dbo.Course", new[] { "Lecturer_LecturerID" });
            DropIndex("dbo.Assessment", new[] { "Course_CourseID" });
            DropTable("dbo.Lecturer");
            DropTable("dbo.StudentAssessment");
            DropTable("dbo.Student");
            DropTable("dbo.Enrollment");
            DropTable("dbo.Course");
            DropTable("dbo.Assessment");
        }
    }
}
