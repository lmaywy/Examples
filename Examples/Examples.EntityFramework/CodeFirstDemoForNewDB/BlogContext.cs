using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.EntityFramework.CodeFirstDemoForNewDB
{
    public class BlogContext : DbContext
    {
        // call base constructor to set the connection string for db info
        public BlogContext() : base("Data Source=.;Initial Catalog=EFCodeFirst;Integrated Security=SSPI;")
        {
            
        }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
