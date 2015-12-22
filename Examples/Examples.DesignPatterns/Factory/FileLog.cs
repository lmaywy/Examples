using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.DesignPatterns.Factory
{
    public class FileLog : Log
    {
        public override void Write(string message)
        {
            Console.WriteLine("Write log to file:" + message);
        }
    }
}
