namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLecturerTableandAnnotation : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Student", name: "FirstMidName", newName: "FirstName");
            CreateTable(
                "dbo.Lecturer",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        LastName = c.String(maxLength: 50),
                        FirstName = c.String(maxLength: 50),
                        Bio = c.String(),
                        Picture = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.LecturerCourse",
                c => new
                    {
                        Lecturer_ID = c.Int(nullable: false),
                        Course_CourseID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Lecturer_ID, t.Course_CourseID })
                .ForeignKey("dbo.Lecturer", t => t.Lecturer_ID, cascadeDelete: true)
                .ForeignKey("dbo.Course", t => t.Course_CourseID, cascadeDelete: true)
                .Index(t => t.Lecturer_ID)
                .Index(t => t.Course_CourseID);
            
            AddColumn("dbo.Course", "DepartmentID", c => c.Int(nullable: false));
            AlterColumn("dbo.Course", "Title", c => c.String(maxLength: 50));
            AlterColumn("dbo.Student", "LastName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Student", "FirstName", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LecturerCourse", "Course_CourseID", "dbo.Course");
            DropForeignKey("dbo.LecturerCourse", "Lecturer_ID", "dbo.Lecturer");
            DropIndex("dbo.LecturerCourse", new[] { "Course_CourseID" });
            DropIndex("dbo.LecturerCourse", new[] { "Lecturer_ID" });
            AlterColumn("dbo.Student", "FirstName", c => c.String(maxLength: 50));
            AlterColumn("dbo.Student", "LastName", c => c.String(maxLength: 50));
            AlterColumn("dbo.Course", "Title", c => c.String());
            DropColumn("dbo.Course", "DepartmentID");
            DropTable("dbo.LecturerCourse");
            DropTable("dbo.Lecturer");
            RenameColumn(table: "dbo.Student", name: "FirstName", newName: "FirstMidName");
        }
    }
}
