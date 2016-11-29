using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstLab1
{
    public class Blog
    {
        public int BlogId { get; set; }
        public String Name { get; set; }
        public String Url { get; set; }
        public double Marks { get; set; }
        public int AmountOfMarks { get; set; }
        public virtual List<Post> Posts { get; set; }

    }
}
