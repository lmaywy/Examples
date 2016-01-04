using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Examples.EntityFramework.CodeFirstDemoForNewDB
{
    public class BloggingDemo
    {
        public static void Demo()
        {
            using (var db = new BlogContext())
            {
                Console.WriteLine("please enter the blog name:");
                var name = Console.ReadLine();
                db.Blogs.Add(new Blog { Name = name });
                db.SaveChanges();

                var blogs = from blog in db.Blogs
                            orderby blog.Name
                            select blog;

                foreach (var item in blogs)
                {
                    Console.WriteLine(item.Name);
                }
            }
        }
    }
}
