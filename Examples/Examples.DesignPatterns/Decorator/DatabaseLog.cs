using System;

namespace Examples.DesignPatterns.Decorator
{
    class DatabaseLog : ILog
    {
        public void Write(string log)
        {
            Console.WriteLine("Write log to database:" + log);
        }
    }
}
