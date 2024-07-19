namespace MigrationTask.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Blogs",
                c => new
                    {
                        BlogId = c.Int(nullable: false, identity: true),
                        BlogName = c.String(),
                        BlogType = c.String(),
                        BlogHeader = c.String(),
                        BlogDescription = c.String(),
                    })
                .PrimaryKey(t => t.BlogId);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        PostId = c.Int(nullable: false, identity: true),
                        PostDesciption = c.String(),
                        CreationDate = c.DateTime(nullable: false),
                        blogId_BlogId = c.Int(),
                    })
                .PrimaryKey(t => t.PostId)
                .ForeignKey("dbo.Blogs", t => t.blogId_BlogId)
                .Index(t => t.blogId_BlogId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Posts", "blogId_BlogId", "dbo.Blogs");
            DropIndex("dbo.Posts", new[] { "blogId_BlogId" });
            DropTable("dbo.Posts");
            DropTable("dbo.Blogs");
        }
    }
}
