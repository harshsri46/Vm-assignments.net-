using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace DatabaseFirst_Approach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BlogInfoEntities1 blogentries = new BlogInfoEntities1();

            List<Blog>blogs = blogentries.Blogs.ToList();
            Console.WriteLine("Printing Blog values:");
            foreach (Blog blog in blogs)
            {
                Console.WriteLine($"BlogId: {blog.Blog_Id},Blog Name:{blog.Blog_Name} ,Blog Type: {blog.Blog_Type},Blog Description: {blog.Blog_Description}");
            }
            Console.WriteLine();
            Console.WriteLine("Printing Post values:");
           List<Post> posts =blogentries.Posts.ToList();
            foreach (Post post in posts)
            {
                Console.WriteLine($"PostId: {post.Post_Id},Post Description: {post.Post_Description},Creation Date: {post.Creation_Date},BlogId :{post.Blog_Id}");

            }

        }
    }
}
