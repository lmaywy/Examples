using System;
using System.Collections.Generic;

namespace Examples.Algorithm.String
{
    public class StringAlgorithm
    {
        public static string ToString(int num)
        {
            var i = 10;
            var ret = string.Empty;

            var absNum = Math.Abs(num);
            do
            {
                ret = absNum % i + ret;
                absNum = absNum / i;
            } while (absNum > 0);

            if (num < 0)
            {
                ret = "-" + ret;
            }
            return ret;
        }

        public static string Inverse(string text)
        {
            var arr = text.ToCharArray();
            var ret = string.Empty;

            for (var i = arr.Length - 1; i >= 0; i--)
            {
                ret += arr[i];
            }

            return ret;
        }

        public static Dictionary<string, int> GetCharsCount(string text)
        {
            var ret = new Dictionary<string, int>();
            var arr = text.ToCharArray();

            foreach (var item in arr)
            {
                var str = item.ToString();
                if (ret.ContainsKey(str))
                {
                    ret[str]++;
                }
                else
                {
                    ret.Add(str, 1);
                }
            }

            return ret;
        }
    }
}
