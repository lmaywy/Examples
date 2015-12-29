namespace Examples.DesignPatterns.Bridge
{
    class DatabaseLog:Log
    {
        public override void Write()
        {
          Implementor.Excute("test for database");
        }
    }
}
