namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMoreTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Assessment",
                c => new
                    {
                        AssessmentID = c.Int(nullable: false, identity: true),
                        EnrollmentID = c.Int(nullable: false),
                        SubmissionTime = c.String(),
                        SubmissionLink = c.String(),
                        Marks = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.AssessmentID)
                .ForeignKey("dbo.Enrollment", t => t.EnrollmentID, cascadeDelete: true)
                .Index(t => t.EnrollmentID);
            
            DropColumn("dbo.Course", "DepartmentID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Course", "DepartmentID", c => c.Int(nullable: false));
            DropForeignKey("dbo.Assessment", "EnrollmentID", "dbo.Enrollment");
            DropIndex("dbo.Assessment", new[] { "EnrollmentID" });
            DropTable("dbo.Assessment");
        }
    }
}
