using System;
using System.Threading;

namespace Examples.DesignPatterns.Singleton
{
    /// <summary>
    /// simple singleton : not safe under mutiple threads,but can lazy loading, avoid to instantiation at the first run time
    /// </summary>
    public sealed class SimpleSingleton: Counter
    {
        private static SimpleSingleton _instance;

        public static SimpleSingleton GetInstance()
        {
            return _instance ?? (_instance = new SimpleSingleton());
        }

    }

    public class Counter
    {
        private int _count = 0;

        public void Add()
        {
            _count++;
            if (Thread.CurrentThread.Name != null)
                Console.WriteLine("线程：{0}，当前计数为：{1}", Thread.CurrentThread.Name.ToString(), _count);

        }

        public int Count()
        {
            Console.WriteLine("最终计数器值：" + _count);
            return _count;
        }
    }
}
