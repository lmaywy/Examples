using System;
using Examples.DesignPatterns.Decorator;
using Examples.DesignPatterns.Obeserver;
using Examples.DesignPatterns.Singleton;
using System.Collections.Generic;
using System.Linq;
using Examples.Algorithm;
using Examples.DesignPatterns.Factory;
using Examples.Algorithm.Sort;
using Examples.DesignPatterns.AbstractFactory;
using Examples.DesignPatterns.Bridge;
using Examples.DesignPatterns.Builder;
using Examples.DesignPatterns.Facade;
using Examples.FrameworkClassLibrary.Reflection;
using Examples.DesignPatterns.Prototype;
using Examples.EntityFramework.CodeFirstDemoForNewDB;
using Examples.FrameworkClassLibrary.Indexers;
using Examples.FrameworkClassLibrary.Comparison;
using Examples.FrameworkClassLibrary.DateTimeEg;
using Examples.FrameworkClassLibrary.Dictionary;
using Examples.FrameworkClassLibrary.Hashtable;
using Examples.FrameworkClassLibrary.Struct;

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
            FactoryDemo.Demo();
            AbstractFactoryDemo.Demo();
            BuilderDemo.Demo();
            PrototypeDemo.Demo();
            BridgeDemo.Demo();
            FacadeDemo.DemoWithFacade();
            FacadeDemo.DemoWithoutFacade();
            Console.WriteLine("------------------Desing Patterns Demo End-----------------");
            var result = Pailie("abcd");

            Console.WriteLine("--------------------Algorithm Demo Start-------------------");
            BubbleSort.Sort(new int[] { 1, 3, 7, 9, 8, 4, 8, 5, 6 }, "desc");
            BubbleSort.Sort(new int[] { 1, 3, 7, 9, 8, 4, 8, 5, 6 }, "asc");
            SelectSort.Sort(new int[] { 1, 3, 7, 9, 8, 4, 8, 5, 6 }, "desc");
            SelectSort.Sort(new int[] { 1, 3, 7, 9, 8, 4, 8, 5, 6 }, "asc");
            Console.WriteLine("---------------------Algorithm Demo End--------------------");

            Console.WriteLine("----------.Net Framework class library Demo start------------");
            TypeDemo.Demo();
            IndexersDemo.Demo();
            ComparisonDemo.Demo();
            DictionaryDemo.Demo();
            HashtableDemo.Demo();
            DateTimeDemo.Demo();
            StructDemo.Demo();
            Console.WriteLine("----------.Net Framework class library Demo End--------------");

            Console.WriteLine("----------Entity Framework start------------");
            BloggingDemo.Demo();
            Console.WriteLine("----------Entity Framework end------------");

            Console.Read();

        }

        /*
        a a
        a b:ab ba
        a b c: abc bac bca acb cab cba

             */
        public static List<string> Pailie(string letters)
        {
            var combination = new List<string>();
            if (letters.Length <= 1)
            {
                combination.Add(letters);
            }
            else
            {
                var arr = letters.ToCharArray();
                for (int j = 0; j < arr.Length; j++)
                {
                    var letter = arr[j].ToString();
                    var others = letters.Replace(letter, "");
                    for (int i = 0; i < arr.Length; i++)
                    {
                        combination.Add(others.Insert(i, letter));
                    }
                }
            }
            return combination.Distinct().ToList();
        }
    }
}
