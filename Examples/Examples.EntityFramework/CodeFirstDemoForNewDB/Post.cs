namespace Examples.EntityFramework.CodeFirstDemoForNewDB
{
    public class Post
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public int BlogID { get; set; }
        public virtual Blog Blog { get; set; }
    }

}