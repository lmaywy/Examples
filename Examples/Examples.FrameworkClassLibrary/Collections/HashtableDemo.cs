
using System;
using System.Collections;

namespace Examples.FrameworkClassLibrary.Collections
{
    /// <summary>
    /// Hashtable basic demos
    /// CRUD
    /// </summary>
    public class HashtableDemo
    {
        public static void Demo()
        {
            /*Scr33n21
            It returns null if we try to find a key which does not exist.
            It is slower than dictionary because it requires boxing and unboxing.
            All the members in a Hashtable are thread safe,
            Hashtable is not a generic type,
            */
            var hashtable = new System.Collections.Hashtable 
            {
                {"A", "a"},
                {"B", "b"},
                {"C", "c"},
                {"D", "d"},
                {"E", "e"}
            };

            // add
            hashtable.Add(1, 2);

            // remove if exsisted
            if (hashtable.ContainsKey(1))
            {
                hashtable.Remove(1);
            }

            var arr = new object[hashtable.Count];
            
            // copy to array
            hashtable.CopyTo(arr, 0);

            var code = hashtable.GetHashCode();

            // Traversal
            foreach (DictionaryEntry item in hashtable)
            {
                Console.WriteLine(item.Key + ":" + item.Value);
            }

            Console.WriteLine(hashtable["test"]); // return null value while the key is not exist
        }
    }
}
