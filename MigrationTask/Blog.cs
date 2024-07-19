using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace MigrationTask
{
   public class Blog
    {
        [Key]   
        public int BlogId { get; set; }
        [Column("Blog_name")]
        public string BlogName { get; set; }
        public string BlogType { get; set; }
        public string BlogHeader { get; set; }
        public string BlogDescription { get; set; }

        public List<Post> post;


    }
}
