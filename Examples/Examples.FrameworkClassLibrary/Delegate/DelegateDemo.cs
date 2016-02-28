using System;
using System.Threading;

namespace Examples.FrameworkClassLibrary.Delegate
{
    /*
        【1】.当我们在C#中需要类似函数指针这样东西时。

        【2】.当我们需要使用回调函数的时候。

        【3】.需要异步调用的时候。

        【4】.实现观察者模式的时候。

        【5】.处理事件响应的时候。
    */
    public class DelegateDemo
    {
        private delegate int Calculate(int a, int b);

        public static void Demo()
        {
            Calculate d = Add; // or new Calculate(Add);
            d += Substract;  // bind one more method to the delegate
            var ret = d(1, 2);  // excute the delegate will excute all the methods in order: excute add then substract
            Console.WriteLine(ret);
            d += Multiply;
            d += Add;
            Console.WriteLine(d(2, 3));
            d -= Add;   // remove 'Add' method from delegate, just remove the last Add, first in last out
            Console.WriteLine(d(2, 3));

            Car car = new Car { Gas = 5 };
            new Alerter(car);
            car.Run();
        }

        //
        private static int Add(int a, int b)
        {
            return a + b;
        }

        private static int Substract(int a, int b)
        {
            return a - b;
        }

        private static int Multiply(int a, int b)
        {
            return a * b;
        }
    }

    #region Observer Pattern: delegate & event Demo : using delegate like a callback
    class Car
    {
        public delegate void Alert();
        public event Alert AlertGas;

        private int gas;
        public int Gas
        {
            get { return gas; }

            set
            {
                if (value <= 0)
                {
                    AlertGas.Invoke();  // don't call Alerter.RunOutOfGasAlerting to loose coupling Alerter and Car is two different objects
                }

                gas = value;
            }
        }

        public void Run()
        {
            while (Gas > 0)
            {
                Thread.Sleep(1000);
                Console.WriteLine("The car is running,the gas is {0}", Gas);
                Gas--;
            }
        }
    }

    class Alerter
    {
        public Alerter(Car car)
        {
            car.AlertGas += RunOutOfGasAlerting;
        }

        public void RunOutOfGasAlerting()
        {
            Console.WriteLine("the gas is running out,please add it in time");
        }
    }
    #endregion
}
