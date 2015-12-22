namespace Examples.DesignPatterns.Factory
{
    public class DatabaseFactory:ILogFactory
    {
        public Log Create()
        {
            return new DatabaseLog();
        }
    }
}
