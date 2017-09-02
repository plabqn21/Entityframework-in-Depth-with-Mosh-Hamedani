namespace EntityframeworkWithMosh.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameTitleToNameInCourseTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "Name", c => c.String(nullable:false));

            Sql("Update dbo.Courses set Name=Title");
            DropColumn("dbo.Courses", "Title");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Courses", "Title", c => c.String(nullable:false));
            Sql("Update dbo.Courses set Title=Name");

            DropColumn("dbo.Courses", "Name");
        }
    }
}
