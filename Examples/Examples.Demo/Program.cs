using System;
using Examples.DesignPatterns.Decorator;
using Examples.DesignPatterns.Obeserver;
using Examples.DesignPatterns.Singleton;
using System.Collections.Generic;
using System.Linq;
using Examples.Algorithm;
using Examples.DesignPatterns.Factory;

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
            Console.WriteLine("------------------Desing Patterns Demo End-----------------");
            var result = Pailie("abcd");

            Console.WriteLine("--------------------Algorithm Demo Start-------------------");
            BubbleSort.Sort(new int[] { 1, 3, 7, 9, 8, 4, 8, 5, 6 }, "desc");
            BubbleSort.Sort(new int[] { 1, 3, 7, 9, 8, 4, 8, 5, 6 }, "asc");
            Console.WriteLine("---------------------Algorithm Demo End--------------------");

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
