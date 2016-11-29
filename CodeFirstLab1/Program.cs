using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstLab1
{
    class Program
    {
        static void Main(string[] args)
        {
            String name;

            Console.WriteLine("Na wstępie stworzymy testowo nowego bloga");
            Console.WriteLine("Podaj nazwe nowego bloga:");

            name = Console.ReadLine();

            using (BlogContext context = new BlogContext())
            {
                context.Database.Log = message => Trace.WriteLine(message);

                Blog blog = new Blog { Name = name };
                context.Blogs.Add(blog);
                context.SaveChanges();

                var query = context.Blogs.Select(b => b).OrderBy(b => b.Name);

                foreach (var item in query)
                {
                    Console.WriteLine("Nazwa bloga: " + item.Name + "\n");
                }

                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("MB::Console:");

                var mbQuery = context.Blogs.Select(b => b.Name).OrderBy(n => n);

                foreach (var item in mbQuery)
                {
                    Console.WriteLine("* " + item);
                }

                BlogForm bf = new BlogForm();
                bf.ShowDialog();
            }

            Console.ReadLine();
        }
    }
}
