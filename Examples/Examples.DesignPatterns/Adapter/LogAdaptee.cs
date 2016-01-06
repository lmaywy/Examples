using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.DesignPatterns.Adapter
{
    public abstract class LogAdaptee
    {
       public abstract  void WriteLog(string message);
    }

    public class DBLog : LogAdaptee
    {
        public override void WriteLog(string message)
        {
            Console.WriteLine("DB log:{0}",message);
        }
    }

    public class FileLog : LogAdaptee
    {
        public override void WriteLog(string message)
        {
            Console.WriteLine("File log:{0}", message);
        }
    }
}
