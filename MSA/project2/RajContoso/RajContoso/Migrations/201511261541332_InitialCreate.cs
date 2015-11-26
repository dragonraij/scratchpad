namespace RajContoso.Migrations
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
                        DueDate = c.DateTime(nullable: false, precision: 0),
                        CourseID = c.String(maxLength: 128, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.AssessmentID)
                .ForeignKey("dbo.Course", t => t.CourseID)
                .Index(t => t.CourseID);
            
            CreateTable(
                "dbo.Course",
                c => new
                    {
                        CourseID = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                        Title = c.String(maxLength: 30, storeType: "nvarchar"),
                        Description = c.String(unicode: false),
                        Department = c.Int(nullable: false),
                        Level = c.Int(nullable: false),
                        AssessmentType = c.Int(nullable: false),
                        CoursePic = c.String(unicode: false),
                        LecturerID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CourseID)
                .ForeignKey("dbo.Lecturer", t => t.LecturerID, cascadeDelete: true)
                .Index(t => t.LecturerID);
            
            CreateTable(
                "dbo.Enrollment",
                c => new
                    {
                        EnrollmentID = c.Int(nullable: false, identity: true),
                        Grade = c.Int(),
                        Status = c.Int(nullable: false),
                        CourseID = c.String(maxLength: 128, storeType: "nvarchar"),
                        StudentID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EnrollmentID)
                .ForeignKey("dbo.Course", t => t.CourseID)
                .ForeignKey("dbo.Student", t => t.StudentID, cascadeDelete: true)
                .Index(t => t.CourseID)
                .Index(t => t.StudentID);
            
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
                        SubmissionTime = c.DateTime(precision: 0),
                        Marks = c.Single(),
                        SubmissionLink = c.String(unicode: false),
                        EnrollmentID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StudentAssessmentID)
                .ForeignKey("dbo.Enrollment", t => t.EnrollmentID, cascadeDelete: true)
                .Index(t => t.EnrollmentID);
            
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
            DropForeignKey("dbo.Course", "LecturerID", "dbo.Lecturer");
            DropForeignKey("dbo.StudentAssessment", "EnrollmentID", "dbo.Enrollment");
            DropForeignKey("dbo.Enrollment", "StudentID", "dbo.Student");
            DropForeignKey("dbo.Enrollment", "CourseID", "dbo.Course");
            DropForeignKey("dbo.Assessment", "CourseID", "dbo.Course");
            DropIndex("dbo.StudentAssessment", new[] { "EnrollmentID" });
            DropIndex("dbo.Enrollment", new[] { "StudentID" });
            DropIndex("dbo.Enrollment", new[] { "CourseID" });
            DropIndex("dbo.Course", new[] { "LecturerID" });
            DropIndex("dbo.Assessment", new[] { "CourseID" });
            DropTable("dbo.Lecturer");
            DropTable("dbo.StudentAssessment");
            DropTable("dbo.Student");
            DropTable("dbo.Enrollment");
            DropTable("dbo.Course");
            DropTable("dbo.Assessment");
        }
    }
}
