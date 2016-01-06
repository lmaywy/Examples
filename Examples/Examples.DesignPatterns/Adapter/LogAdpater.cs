using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.DesignPatterns.Adapter
{
    public class LogAdpater : ILogTarget
    {
        private readonly LogAdaptee _adaptee;

        public LogAdpater(LogAdaptee adpatee)
        {
            _adaptee = adpatee;
        }

        public void Write(string message)
        {
            _adaptee.WriteLog(message);
        }
    }
}
