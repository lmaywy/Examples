using System;
using System.Collections;

namespace Examples.DesignPatterns.Builder
{
    public class Food
    {
        Hashtable food = new Hashtable();
        public void Add(string name, string price)
        {
            food.Add(name, price);
        }

        public void Show()
        {
            Console.WriteLine("Food List:");

            foreach (DictionaryEntry item in food)
            {
                Console.WriteLine("{0}:{1}", item.Key, item.Value);
            }
        }
    }
}
