using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.DesignPatterns.Adapter
{
    public interface ILogTarget
    {
        void Write(string message);
    }
}
