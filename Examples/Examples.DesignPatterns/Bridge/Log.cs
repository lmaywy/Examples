using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.DesignPatterns.Bridge
{
    public abstract class Log
    {
        public LogImpl Implementor { get; set; }

        public virtual void Write()
        {
            Implementor.Excute("base test");
        }
    }
}
