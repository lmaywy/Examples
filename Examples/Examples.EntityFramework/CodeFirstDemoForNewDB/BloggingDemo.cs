using System;
using System.Linq;

namespace Examples.EntityFramework.CodeFirstDemoForNewDB
{
    public class BloggingDemo
    {
        public static void Demo()
        {
            using (var db = new BlogContext())
            {
                // get the connectionstring to check where the db created while code first(SQLEXPRESS always takes precedence if it is installed)
                //var connection = ((IObjectContextAdapter)db).ObjectContext.Connection.ConnectionString;

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
