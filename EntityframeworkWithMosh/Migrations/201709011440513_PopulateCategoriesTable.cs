namespace EntityframeworkWithMosh.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategoriesTable : DbMigration
    {
        public override void Up()
        {

            Sql("Insert into Categories values('Web Development')");
            Sql("Insert into Categories values('Programming Language')");
           
        }
        
        public override void Down()
        {
        }
    }
}
