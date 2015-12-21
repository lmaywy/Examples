using System;

namespace Examples.DesignPatterns.Obeserver
{
    public class TongHuaShunApp : IObserver
    {
        public string Name { get; set; }

        public void DisplayLatestPrice(Stock stock)
        {
            Console.WriteLine("Hi,{0},Current stock price of {1} is:{2}",this.Name,stock.Name,stock.Price);
        }
    }
}
