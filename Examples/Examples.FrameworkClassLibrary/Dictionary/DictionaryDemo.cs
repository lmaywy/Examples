using System;
using System.Collections.Generic;
using System.Linq;

namespace Examples.FrameworkClassLibrary.Dictionary
{
    public class DictionaryDemo
    {
        /// <summary>
        /// Dictionary demos~
        /// basic CRUD and extension method which extended by IEnumerable in static Enumerable class
        /// </summary>
        public static void Demo()
        {
            /*
                It returns error if we try to find a key which does not exist.
                It is faster than a Hashtable because there is no boxing and unboxing.
                Only public static members are thread safe.
                Dictionary is a generic type which means we can use it with any data type.
            */
            var dic = new Dictionary<string, int> 
            {
                {"A", 65},
                {"B", 66},
                {"C", 67},
                {"D", 68}
            };

            // query: get value by all the given key
            var keys = "ABC";

            var values = dic.Select(c =>
              {
                  if (keys.Contains(c.Key))
                      return c.Value.ToString();
                  else return string.Empty;
              }).ToArray();
            var values2 = keys.Select(c => dic[c.ToString()]).ToArray();

            // Create a new dictionary of strings, with string keys.
            Dictionary<string, string> openWith = new Dictionary<string, string>();

            // add: Add some elements to the dictionary. There are no 
            // duplicate keys, but some of the values are duplicates.
            openWith.Add("txt", "notepad.exe");
            openWith.Add("bmp", "paint.exe");
            openWith.Add("dib", "paint.exe");
            openWith.Add("rtf", "wordpad.exe");

            // update
            openWith["txt"] = "window.exe";

            // delete
            openWith.Remove("txt");
            //openWith.Clear();


            var t = openWith.GetEnumerator();

            do
            {
                Console.WriteLine(t.Current.Key + "" + t.Current.Value);
            } while (t.MoveNext());

            while (t.MoveNext())
            {
                Console.WriteLine(t.Current.Key + "" + t.Current.Value);
            }

            openWith.OrderByDescending(o => o.Key);

            foreach (var item in openWith)
            {
                Console.WriteLine("key:{0},Value:{1}", item.Key, item.Value);
            }
          
            // The Add method throws an exception if the new key is 
            // already in the dictionary.
            try
            {
                openWith.Add("txt", "winword.exe");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("An element with Key = \"txt\" already exists.");
            }

            //Console.WriteLine(openWith["test"]); throw key not found exception
        }
    }
}
