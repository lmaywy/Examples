namespace Examples.DesignPatterns.Factory
{
    public class FileFactory : ILogFactory
    {
        public Log Create()
        {
           return new FileLog();
        }
    }
}
