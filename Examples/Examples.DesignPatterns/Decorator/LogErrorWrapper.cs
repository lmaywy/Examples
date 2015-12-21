using System;

namespace Examples.DesignPatterns.Decorator
{
    public class LogErrorWrapper : LogWrapper
    {
        public LogErrorWrapper(ILog log) : base(log)
        {
        }

        public override void Write(string log)
        {
            SetError();
            base.Write(log);
        }

        public void SetError()
        {
            Console.WriteLine("Set Error");
        }
    }
}
