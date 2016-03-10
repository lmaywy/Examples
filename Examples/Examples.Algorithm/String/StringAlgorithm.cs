using System;
using System.Collections.Generic;

namespace Examples.Algorithm.String
{
    public class StringAlgorithm
    {
        /// <summary>
        /// 将数字转化为字符串
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
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

        /// <summary>
        /// 将字符串倒置
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
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

        /// <summary>
        /// 判断两个字符创是否相等
        /// </summary>
        /// <param name="source"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static bool StringEqual(string source, string target)
        {
            if (source == null && target == null)
            {
                return true;
            }
            else if ((source == null && target != null) || (target == null && source != null))
            {
                return false;
            }
            else if (source != null && target != null && source.Length != target.Length)
            {
                return false;
            }
            else
            {
                var arr1 = source.ToCharArray();
                var arr2 = target.ToCharArray();

                for (int i = 0; i < source.Length; i++)
                {
                    if (arr1[i] != arr2[i])
                    {
                        return false;
                    }
                }

                return true;
            }
        }

        /// <summary>
        /// 查看字符串中各个字符出现的次数
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
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
