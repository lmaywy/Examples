using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Examples.FrameworkClassLibrary.Dictionary
{
    public class DictionaryDemo
    {
        /// <summary>
        /// Dictionary demos~
        /// </summary>
        public static void Demo()
        {
            var dic = new Dictionary<string, int>
            {
                {"A", 65},
                {"B", 66},
                {"C", 67},
                {"D", 68}
            };

            // get value by all the given key
            var keys = "ABC";

            var values = dic.Select(c =>
              {
                  if (keys.Contains(c.Key))
                      return c.Value.ToString();
                  else return string.Empty;
              }).ToArray();

            var values2 = keys.Select(c => dic[c.ToString()]).ToArray();

        }
    }
}
