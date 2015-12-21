using System.Threading;

namespace Examples.DesignPatterns.Singleton
{
    public class SingletonPatternDemo
    {
        public static void SimpleSingletonDemo()
        {
            //var single = SimpleSingleton.GetInstance();
            //var single = SimpleSingleton.GetInstance();
            var single = StaticSingleton.Instance;
            Thread thread0 = Thread.CurrentThread;
            Thread thread1 = new Thread(new ThreadStart(single.Add));
            Thread thread2 = new Thread(new ThreadStart(single.Add));
            Thread thread3 = new Thread(new ThreadStart(single.Add));
            Thread thread4 = new Thread(new ThreadStart(single.Add));

            thread0.Name = "thread0";
            thread1.Name = "thread1";
            thread2.Name = "thread2";
            thread3.Name = "thread3";
            thread4.Name = "thread4";

            thread1.Start();
            thread2.Start();
            thread3.Start();
            thread4.Start();

            single.Add();
            single.Count();
        }
    }
}
