namespace EntityframeworkWithMosh.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCourseAuthorTagTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        AuthorID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.AuthorID);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        Level = c.Int(nullable: false),
                        FullPrice = c.Single(nullable: false),
                        Author_AuthorID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Authors", t => t.Author_AuthorID)
                .Index(t => t.Author_AuthorID);
            
            CreateTable(
                "dbo.Tags",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TagCourses",
                c => new
                    {
                        Tag_ID = c.Int(nullable: false),
                        Course_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Tag_ID, t.Course_ID })
                .ForeignKey("dbo.Tags", t => t.Tag_ID, cascadeDelete: true)
                .ForeignKey("dbo.Courses", t => t.Course_ID, cascadeDelete: true)
                .Index(t => t.Tag_ID)
                .Index(t => t.Course_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TagCourses", "Course_ID", "dbo.Courses");
            DropForeignKey("dbo.TagCourses", "Tag_ID", "dbo.Tags");
            DropForeignKey("dbo.Courses", "Author_AuthorID", "dbo.Authors");
            DropIndex("dbo.TagCourses", new[] { "Course_ID" });
            DropIndex("dbo.TagCourses", new[] { "Tag_ID" });
            DropIndex("dbo.Courses", new[] { "Author_AuthorID" });
            DropTable("dbo.TagCourses");
            DropTable("dbo.Tags");
            DropTable("dbo.Courses");
            DropTable("dbo.Authors");
        }
    }
}
