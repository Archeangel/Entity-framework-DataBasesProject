using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace CodeFirstLab1
{
    public class Post
    {
        public int PostId { get; set; }
        public String Title { get; set; }
        public String Desc { get; set; }
        public int BlogId { get; set; }
    }
}
