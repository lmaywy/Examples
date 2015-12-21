using System;

namespace Examples.DesignPatterns.Decorator
{
    public class LogPriorityWarpper : LogWrapper
    {
        public LogPriorityWarpper(ILog log) : base(log)
        {
        }

        public override void Write(string log)
        {
            SetPriority();
            base.Write(log);
        }

        public void SetPriority()
        {
            Console.WriteLine("Set Priority");
        }
    }
}
