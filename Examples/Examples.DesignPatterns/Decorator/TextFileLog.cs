using System;

namespace Examples.DesignPatterns.Decorator
{
    class TextFileLog : ILog
    {
        public void Write(string log)
        {
            Console.WriteLine("Write log to textfile:" + log);
        }
    }
}
