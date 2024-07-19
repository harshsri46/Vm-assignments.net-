using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigrationTask
{
    public class Post
    {
        [Key]
        public int PostId { get; set; }
        public string PostDesciption { get; set; }

        [Column("DateOfCreation")]
        public DateTime CreationDate { get; set; }

        public Blog blogId { get; set; }


    }
}
