using System;
using Examples.DesignPatterns.Obeserver;
//using Examples.DesignPatterns.Singleton;

namespace Examples.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------Desing Patterns Demo Start----------------");
            ObserverPatternDemo.Demo();
            //SingletonPatternDemo.SimpleSingletonDemo(); 
            Console.WriteLine("------------- ----Desing Patterns Demo End-----------------");
            Console.Read();
        }
    }
}
