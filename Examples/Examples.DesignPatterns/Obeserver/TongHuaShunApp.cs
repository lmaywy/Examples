using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.DesignPatterns.Obeserver
{
    public class TongHuaShunApp : IObserver
    {
        public void DisplayLatestPrice(Stock stock)
        {
            Console.WriteLine("Current stock price of {0} is:{2}",stock.Name,stock.Price);
        }
    }
}
