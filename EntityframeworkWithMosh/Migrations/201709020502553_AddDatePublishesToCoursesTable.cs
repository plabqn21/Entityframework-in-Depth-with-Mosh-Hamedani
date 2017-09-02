namespace EntityframeworkWithMosh.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDatePublishesToCoursesTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Courses", "Author_AuthorID", "dbo.Authors");
            DropIndex("dbo.Courses", new[] { "Author_AuthorID" });
            RenameColumn(table: "dbo.Courses", name: "Author_AuthorID", newName: "AuthorId");
            AddColumn("dbo.Courses", "DatePublished", c => c.DateTime());
            AlterColumn("dbo.Courses", "AuthorId", c => c.Int(nullable: false));
            CreateIndex("dbo.Courses", "AuthorId");
            AddForeignKey("dbo.Courses", "AuthorId", "dbo.Authors", "AuthorID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "AuthorId", "dbo.Authors");
            DropIndex("dbo.Courses", new[] { "AuthorId" });
            AlterColumn("dbo.Courses", "AuthorId", c => c.Int());
            DropColumn("dbo.Courses", "DatePublished");
            RenameColumn(table: "dbo.Courses", name: "AuthorId", newName: "Author_AuthorID");
            CreateIndex("dbo.Courses", "Author_AuthorID");
            AddForeignKey("dbo.Courses", "Author_AuthorID", "dbo.Authors", "AuthorID");
        }
    }
}
