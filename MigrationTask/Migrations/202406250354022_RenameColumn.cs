namespace MigrationTask.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameColumn : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Blogs", name: "BlogName", newName: "Blog_name");
            RenameColumn(table: "dbo.Posts", name: "CreationDate", newName: "DateOfCreation");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.Posts", name: "DateOfCreation", newName: "CreationDate");
            RenameColumn(table: "dbo.Blogs", name: "Blog_name", newName: "BlogName");
        }
    }
}
