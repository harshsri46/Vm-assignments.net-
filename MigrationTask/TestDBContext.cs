using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigrationTask
{
    public  class TestDBContext:DbContext
    {
        public TestDBContext() : base("name=BloggingInfo")
        {

        //    Database.SetInitializer(new DropCreateDatabaseIfModelChanges<TestDBContext>());
        //    Database.SetInitializer(new SeedDefaultData());
        }
        public DbSet<Blog>Blog{ get; set; }
        public DbSet<Post>Post { get; set; }
    }
    public class SeedDefaultData:DropCreateDatabaseIfModelChanges<TestDBContext>
    {
        protected override void Seed(TestDBContext context)
        {
            Blog blog1 = new Blog();
            blog1.BlogId = 1;
            blog1.BlogName = "abc";
            blog1.BlogHeader = "written by harsh";
            blog1.BlogDescription = "this is my first blog";

            Blog blog2 = new Blog();
            blog2.BlogId = 2;
            blog2.BlogName = "xyz";
            blog2.BlogHeader = "written by ankita";
            blog2.BlogDescription = "this is my second blog";

            context.Blog.Add(blog1);
            context.Blog.Add(blog2);    
            context.SaveChanges();
            base.Seed(context);
        }
    }

}
