using System;
using Examples.DesignPatterns.Decorator;
using Examples.DesignPatterns.Obeserver;
using Examples.DesignPatterns.Singleton;

namespace Examples.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------Desing Patterns Demo Start----------------");
            ObserverPatternDemo.Demo();
            SingletonPatternDemo.SimpleSingletonDemo();
            DecoratorDemo.Demo();
            Console.WriteLine("------------- ----Desing Patterns Demo End-----------------");
            Console.Read();
        }
    }
}
