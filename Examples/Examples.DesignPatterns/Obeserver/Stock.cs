using Examples.DesignPatterns.Obeserver;
using System.Collections.Generic;

namespace Examples.DesignPatterns
{
    public abstract class Stock
    {
        private string _name;
        private double _price;

        protected Stock(string name,double price)
        {
            _name = name;
            _price = price;
        }

        public string Name { get { return _name; } }

        public double Price { get { return _price; } }

        private List<IObserver> observers = new List<IObserver>();

        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            observers.ForEach(o => o.DisplayLatestPrice(this));
        }
    }
}
