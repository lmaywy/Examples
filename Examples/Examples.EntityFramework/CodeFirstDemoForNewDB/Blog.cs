using System.Collections.Generic;

namespace Examples.EntityFramework.CodeFirstDemoForNewDB
{
    public class Blog
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public virtual List<Post> Posts { get; set; }
    }
}