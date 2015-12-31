using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.DesignPatterns.Factory
{
    public class DatabaseLog : Log
    {
        public override void Write(string message)
        {
            Console.WriteLine("Write log to database" + message);
        }
    }
}
