using System;

namespace Examples.DesignPatterns.Bridge
{
    public abstract class LogImpl
    {
        public abstract void Excute(string msg);
    }

    public class NImpLog : LogImpl
    {
        public override void Excute(string msg)
        {
            Console.WriteLine(".net platform~ {0}", msg);
        }

    }

    public class JImpLog : LogImpl
    {
        public override void Excute(string msg)
        {
            Console.WriteLine("java platform~ {0} ", msg);
        }
    }
}
