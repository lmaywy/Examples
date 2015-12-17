using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.DesignPatterns.Obeserver
{
    public interface IObserver
    {
        void DisplayLatestPrice(Stock stock);
    }
}
