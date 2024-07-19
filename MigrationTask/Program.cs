using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigrationTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestDBContext testdb = new TestDBContext();

            List<Blog> blog = testdb.Blog.ToList();

            List<Post> post = testdb.Post.ToList();

          
        }
    }
}



