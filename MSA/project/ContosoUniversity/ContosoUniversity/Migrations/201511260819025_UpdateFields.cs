namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateFields : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Course", "Lecturer_LecturerID", "dbo.Lecturer");
            DropForeignKey("dbo.Enrollment", "Student_StudentID", "dbo.Student");
            DropForeignKey("dbo.StudentAssessment", "Enrollment_EnrollmentID", "dbo.Enrollment");
            DropForeignKey("dbo.Assessment", "Course_CourseID", "dbo.Course");
            DropForeignKey("dbo.Enrollment", "Course_CourseID", "dbo.Course");
            DropIndex("dbo.Assessment", new[] { "Course_CourseID" });
            DropIndex("dbo.Course", new[] { "Lecturer_LecturerID" });
            DropIndex("dbo.Enrollment", new[] { "Course_CourseID" });
            DropIndex("dbo.Enrollment", new[] { "Student_StudentID" });
            DropIndex("dbo.StudentAssessment", new[] { "Enrollment_EnrollmentID" });
            RenameColumn(table: "dbo.Assessment", name: "Course_CourseID", newName: "CourseID");
            RenameColumn(table: "dbo.Enrollment", name: "Course_CourseID", newName: "CourseID");
            RenameColumn(table: "dbo.Course", name: "Lecturer_LecturerID", newName: "LecturerID");
            RenameColumn(table: "dbo.Enrollment", name: "Student_StudentID", newName: "StudentID");
            RenameColumn(table: "dbo.StudentAssessment", name: "Enrollment_EnrollmentID", newName: "EnrollmentID");
            DropPrimaryKey("dbo.Course");
            AlterColumn("dbo.Assessment", "CourseID", c => c.String(maxLength: 128, storeType: "nvarchar"));
            AlterColumn("dbo.Course", "CourseID", c => c.String(nullable: false, maxLength: 128, storeType: "nvarchar"));
            AlterColumn("dbo.Course", "LecturerID", c => c.Int(nullable: false));
            AlterColumn("dbo.Enrollment", "CourseID", c => c.String(maxLength: 128, storeType: "nvarchar"));
            AlterColumn("dbo.Enrollment", "StudentID", c => c.Int(nullable: false));
            AlterColumn("dbo.StudentAssessment", "EnrollmentID", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Course", "CourseID");
            CreateIndex("dbo.Assessment", "CourseID");
            CreateIndex("dbo.Course", "LecturerID");
            CreateIndex("dbo.Enrollment", "CourseID");
            CreateIndex("dbo.Enrollment", "StudentID");
            CreateIndex("dbo.StudentAssessment", "EnrollmentID");
            AddForeignKey("dbo.Course", "LecturerID", "dbo.Lecturer", "LecturerID", cascadeDelete: true);
            AddForeignKey("dbo.Enrollment", "StudentID", "dbo.Student", "StudentID", cascadeDelete: true);
            AddForeignKey("dbo.StudentAssessment", "EnrollmentID", "dbo.Enrollment", "EnrollmentID", cascadeDelete: true);
            AddForeignKey("dbo.Assessment", "CourseID", "dbo.Course", "CourseID");
            AddForeignKey("dbo.Enrollment", "CourseID", "dbo.Course", "CourseID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Enrollment", "CourseID", "dbo.Course");
            DropForeignKey("dbo.Assessment", "CourseID", "dbo.Course");
            DropForeignKey("dbo.StudentAssessment", "EnrollmentID", "dbo.Enrollment");
            DropForeignKey("dbo.Enrollment", "StudentID", "dbo.Student");
            DropForeignKey("dbo.Course", "LecturerID", "dbo.Lecturer");
            DropIndex("dbo.StudentAssessment", new[] { "EnrollmentID" });
            DropIndex("dbo.Enrollment", new[] { "StudentID" });
            DropIndex("dbo.Enrollment", new[] { "CourseID" });
            DropIndex("dbo.Course", new[] { "LecturerID" });
            DropIndex("dbo.Assessment", new[] { "CourseID" });
            DropPrimaryKey("dbo.Course");
            AlterColumn("dbo.StudentAssessment", "EnrollmentID", c => c.Int());
            AlterColumn("dbo.Enrollment", "StudentID", c => c.Int());
            AlterColumn("dbo.Enrollment", "CourseID", c => c.Int());
            AlterColumn("dbo.Course", "LecturerID", c => c.Int());
            AlterColumn("dbo.Course", "CourseID", c => c.Int(nullable: false));
            AlterColumn("dbo.Assessment", "CourseID", c => c.Int());
            AddPrimaryKey("dbo.Course", "CourseID");
            RenameColumn(table: "dbo.StudentAssessment", name: "EnrollmentID", newName: "Enrollment_EnrollmentID");
            RenameColumn(table: "dbo.Enrollment", name: "StudentID", newName: "Student_StudentID");
            RenameColumn(table: "dbo.Course", name: "LecturerID", newName: "Lecturer_LecturerID");
            RenameColumn(table: "dbo.Enrollment", name: "CourseID", newName: "Course_CourseID");
            RenameColumn(table: "dbo.Assessment", name: "CourseID", newName: "Course_CourseID");
            CreateIndex("dbo.StudentAssessment", "Enrollment_EnrollmentID");
            CreateIndex("dbo.Enrollment", "Student_StudentID");
            CreateIndex("dbo.Enrollment", "Course_CourseID");
            CreateIndex("dbo.Course", "Lecturer_LecturerID");
            CreateIndex("dbo.Assessment", "Course_CourseID");
            AddForeignKey("dbo.Enrollment", "Course_CourseID", "dbo.Course", "CourseID");
            AddForeignKey("dbo.Assessment", "Course_CourseID", "dbo.Course", "CourseID");
            AddForeignKey("dbo.StudentAssessment", "Enrollment_EnrollmentID", "dbo.Enrollment", "EnrollmentID");
            AddForeignKey("dbo.Enrollment", "Student_StudentID", "dbo.Student", "StudentID");
            AddForeignKey("dbo.Course", "Lecturer_LecturerID", "dbo.Lecturer", "LecturerID");
        }
    }
}
